using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTRDesktopApplication
{
    public partial class BookingSeatEdit : Form
    {
        private Button previouslySelectedSeatButton;
        public BusSeatsBookedDetails SelectedSeatDetails;
        private string seatingPlan;
        private int bookingID;
        public event EventHandler SaveComplete;
        private readonly HttpClient httpClient = new HttpClient();
        private readonly string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private SeatingPlanControl seatingPlanControl;
        public string _sittingPlanType;
        public string _noOfSeats;
        private Domain.gettaxiusa.com.Entities.BusSeatsBookedDetails currentSelectedSeat;
        private List<Domain.gettaxiusa.com.Entities.BusSeatsBookedDetails> seatingPlanData;
        private Domain.gettaxiusa.com.Entities.BusSeatsBookedDetails previousSelectedSeat; 

        public BookingSeatEdit()
        {
            InitializeComponent();
        }
        public void loadFromChangeSeat(string seatingPlan1, int bookingID1)
        {
            seatingPlan = seatingPlan1;
            bookingID = bookingID1;
            InitializeSeatingPlans();
            InitializeSelectedSeatsPanel();

        }

        private async void InitializeSeatingPlans()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(flowLayoutPanel);
            seatingPlanControl = new SeatingPlanControl();
            flowLayoutPanel.Controls.Add(seatingPlanControl);
            seatingPlanData = await FetchSeatingPlanFromAPI();
            if (seatingPlanData != null)
            {
                seatingPlanControl.SetSeatingPlan(seatingPlanData, _sittingPlanType, _noOfSeats, null);
                UpdateSelectedSeatsPanel(seatingPlanData);
            }
        }

        private async Task<List<Domain.gettaxiusa.com.Entities.BusSeatsBookedDetails>> FetchSeatingPlanFromAPI()
        {
            try
            {
                BookingDetails bookingDetails = await MakeHttpGetRequest<BookingDetails>($"api/Booking/GetBookingById/{bookingID}");
                var sittingPlan = bookingDetails.Vehicle.SeatingPlan;
                _sittingPlanType = sittingPlan;
                var numberOfSeats = bookingDetails.Vehicle.NumberOfSeatsAvailable;
                _noOfSeats = numberOfSeats;
                if (bookingDetails != null)
                {
                    return bookingDetails.BusSeatsBookedDetailsList;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching seating plan: {ex.Message}");
                return null;
            }
        }

        private async Task<T> MakeHttpGetRequest<T>(string endpoint)
        {
            string url = $"{baseUrl}{endpoint}";
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseData);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"HTTP GET Request Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return default;
        }

        private void InitializeSelectedSeatsPanel()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Right,
                Width = 200,
                Height = 300,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BorderStyle = BorderStyle.None
            };
            panelSelectedSeats = flowLayoutPanel;
            this.Controls.Add(panelSelectedSeats);
        }
        private void UpdateSelectedSeatsPanel(List<Domain.gettaxiusa.com.Entities.BusSeatsBookedDetails> seats)
        {
            panelSelectedSeats.Controls.Clear();
            var selectedSeats = seats.Where(seat => seat.IsSelected).ToList();

            foreach (var seat in selectedSeats)
            {
                CheckBox checkBox = new CheckBox
                {
                    Text = $"Seat No {seat.SeatNumber}",
                    Tag = seat,
                    Checked = false,
                    Name = seat.SeatNumber.ToString()
                };

                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                panelSelectedSeats.Controls.Add(checkBox);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = sender as CheckBox;
            if (clickedCheckBox == null)
                return;
            Domain.gettaxiusa.com.Entities.BusSeatsBookedDetails seat = clickedCheckBox.Tag as Domain.gettaxiusa.com.Entities.BusSeatsBookedDetails;
            if (seat != null)
            {
                if (clickedCheckBox.Checked)
                {
                    foreach (CheckBox checkBox in panelSelectedSeats.Controls.OfType<CheckBox>())
                    {
                        if (checkBox != clickedCheckBox)
                        {
                            checkBox.Checked = false;
                        }
                    }
                    if (currentSelectedSeat != null && currentSelectedSeat.SeatNumber != seat.SeatNumber)
                    {
                        currentSelectedSeat.IsSelected = false;
                    }
                    currentSelectedSeat = seat;
                    seat.IsSelected = true;
                }
                else
                {
                    if (currentSelectedSeat != null && currentSelectedSeat.SeatNumber == seat.SeatNumber)
                    {
                        currentSelectedSeat = null;
                    }

                    seat.IsSelected = false;
                }
                seatingPlanControl.setSelectedSeatNumber(seat.SeatNumber);
            }
        }
        public void updateCheckBoxLabel(int seatNo, int oldSeatNo)
        {

            foreach (CheckBox checkBox in panelSelectedSeats.Controls.OfType<CheckBox>())
            {
                if (checkBox.Name == oldSeatNo.ToString())
                {
                    checkBox.Text = $"Seat No {seatNo}";
                    checkBox.Checked = false;

                }
            }
        }

        private int? ExtractSeatNumberFromText(string text)
        {
            const string pattern = "Seat No ";
            if (text.StartsWith(pattern))
            {
                string seatNumberPart = text.Substring(pattern.Length);
                if (int.TryParse(seatNumberPart, out int seatNumber))
                {
                    return seatNumber;
                }
            }
            return null;
        }

        private async void Savebutton_Click(object sender, EventArgs e)
        {
            StringBuilder seatNumbersBuilder = new StringBuilder();
            foreach (CheckBox checkBox in panelSelectedSeats.Controls.OfType<CheckBox>())
            {
                int? seatNumber = ExtractSeatNumberFromText(checkBox.Text);

                if (seatNumber.HasValue)
                {
                    if (seatNumbersBuilder.Length > 0)
                    {
                        seatNumbersBuilder.Append(",");
                    }
                    seatNumbersBuilder.Append(seatNumber.Value);
                }
            }
            string seatNumbers = seatNumbersBuilder.ToString();
            string encodedSeatNumbers = Uri.EscapeDataString(seatNumbers);
            string url = $"{baseUrl}api/Booking/UpdateBookingSeatNumber/{bookingID}/{encodedSeatNumbers}";
            HttpContent content = new StringContent("", Encoding.UTF8, "application/json");
            try
            {
                using (HttpResponseMessage response = await httpClient.PutAsync(url, content))
                {
                    response.EnsureSuccessStatusCode();
                    var editbookingform = EditBookingForm();
                    editbookingform.updateFromSeatChangeScreen(seatNumbers);
                    SaveComplete?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private EditBooking EditBookingForm()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is EditBooking)
                {
                    return (EditBooking)openForm;
                }
            }
            return null;
        }


        private void clearSelectionBtn_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in panelSelectedSeats.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }
        }
    }
}
