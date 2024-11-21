using Domain.gettaxiusa.com.Entities;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MTRDesktopApplication.Dtos;
namespace MTRDesktopApplication
{
    public partial class SeatingPlanControl : UserControl
    {
        private Button previouslySelectedSeatButton;
        public int? newSeatNumber = 0;
        public BusSeatsBookedDetails SelectedSeatDetails { get; private set; }

        private BookingSeatEdit bookingSeatEdit;

        public List<BusSeatsBookedDetails> busSeatsBookedDetails = new List<BusSeatsBookedDetails>();

        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
        {
            AutoSize = true,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            
        };
        public SeatingPlanControl()
        {
            InitializeComponent();
        }

        private BookingSeatEdit GetOpenedBookingSeatEditForm()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is BookingSeatEdit)
                {
                    return (BookingSeatEdit)openForm;
                }
            }
            return null; // Form is not open
        }

        public void SetSeatingPlan(List<Domain.gettaxiusa.com.Entities.BusSeatsBookedDetails> apiModel, string _sittingPlanType, string _noOfSeats, int? seatNo)
        {
            var seats = MapToUiModel(apiModel);
            newSeatNumber = seatNo;
            int totalSeats = int.Parse(_noOfSeats);
            Controls.Clear();

            Panel scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };


            tableLayoutPanel.RowCount = 0;
            tableLayoutPanel.ColumnCount = 0;
            switch (_sittingPlanType)
            {
                case "1-2":
                    SetUpSeatingPlan1_2(tableLayoutPanel, seats);
                    break;
                case "2-2":
                    SetUpSeatingPlan2_2(tableLayoutPanel, seats);
                    break;
                case "2-3":
                    SetUpSeatingPlan2_3(tableLayoutPanel, seats);
                    break;
                case "2-2-5":
                    SetUpSeatingPlan2_2_5(tableLayoutPanel, seats, totalSeats);
                    break;
                case "2-3-6":
                    SetUpSeatingPlan2_3_6(tableLayoutPanel, seats, totalSeats);
                    break;
                default:
                    MessageBox.Show("Unknown seating plan type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            scrollablePanel.Controls.Add(tableLayoutPanel);
            Controls.Add(scrollablePanel);
        }
        private void SetUpSeatingPlan1_2(TableLayoutPanel tableLayoutPanel, List<BusSeatsBookedDetails> seats)
        {
            busSeatsBookedDetails = seats;
            int[,] basePattern = {
             { 1, 0, 2, 3 }
             };
            int baseRows = basePattern.GetLength(0);
            int baseCols = basePattern.GetLength(1);
            int numRows = (int)Math.Ceiling(seats.Count / (double)(baseCols - 1));
            int numCols = baseCols;
            tableLayoutPanel.RowCount = numRows;
            tableLayoutPanel.ColumnCount = numCols;
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < numRows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }
            for (int i = 0; i < numCols; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            }

            int seatIndex = 0;
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    int patternValue = basePattern[0, col];
                    if (patternValue != 0)
                    {
                        if (seatIndex < seats.Count)
                        {
                            var seat = seats[seatIndex++];
                            AddSeatButtonToTable(tableLayoutPanel, seat, col, row);
                        }
                        else
                        {
                            tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, row);
                        }
                    }
                    else
                    {
                        tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, row);
                    }
                }
            }

            while (seatIndex < seats.Count)
            {
                tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.Red }, seatIndex % numCols, seatIndex / numCols);
                seatIndex++;
            }
        }

        private void SetUpSeatingPlan2_2(TableLayoutPanel tableLayoutPanel, List<BusSeatsBookedDetails> seats)
        {
            busSeatsBookedDetails = seats;
            int[,] basePattern = {
            { 1, 2, 0, 3, 4 }
            };

            int baseRows = basePattern.GetLength(0);
            int baseCols = basePattern.GetLength(1);
            int numRows = (int)Math.Ceiling(seats.Count / (double)(baseCols - 1));
            int numCols = baseCols;

            tableLayoutPanel.RowCount = numRows;
            tableLayoutPanel.ColumnCount = numCols;
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < numRows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }
            for (int i = 0; i < numCols; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            }

            int seatIndex = 0;
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    int patternValue = basePattern[0, col];
                    if (patternValue != 0)
                    {
                        if (seatIndex < seats.Count)
                        {
                            var seat = seats[seatIndex++];
                            AddSeatButtonToTable(tableLayoutPanel, seat, col, row);
                        }
                        else
                        {
                            tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, row);
                        }
                    }
                    else
                    {
                        tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, row);
                    }
                }
            }

            while (seatIndex < seats.Count)
            {
                tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.Red }, seatIndex % numCols, seatIndex / numCols);
                seatIndex++;
            }
        }

        private void SetUpSeatingPlan2_3(TableLayoutPanel tableLayoutPanel, List<BusSeatsBookedDetails> seats)
        {
            busSeatsBookedDetails = seats;
            int[,] basePattern = {
             { 1, 2, 0, 3, 4, 5 }
             };
            int baseRows = basePattern.GetLength(0);
            int baseCols = basePattern.GetLength(1);
            int numRows = (int)Math.Ceiling(seats.Count / (double)(baseCols - 1));
            int numCols = baseCols;
            tableLayoutPanel.RowCount = numRows;
            tableLayoutPanel.ColumnCount = numCols;
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Clear();

            for (int i = 0; i < numRows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }
            for (int i = 0; i < numCols; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            }

            int seatIndex = 0;
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    int patternValue = basePattern[0, col];
                    if (patternValue != 0)
                    {
                        if (seatIndex < seats.Count)
                        {
                            var seat = seats[seatIndex++];
                            AddSeatButtonToTable(tableLayoutPanel, seat, col, row);
                        }
                        else
                        {
                            tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, row);
                        }
                    }
                    else
                    {
                        tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, row);
                    }
                }
            }

            while (seatIndex < seats.Count)
            {
                tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.Red }, seatIndex % numCols, seatIndex / numCols);
                seatIndex++;
            }
        }

        private void SetUpSeatingPlan2_2_5(TableLayoutPanel tableLayoutPanel, List<BusSeatsBookedDetails> seats, int totalSeats)
        {
            busSeatsBookedDetails = seats;
            int columns = 5;
            int patternCols = columns - 1;
            int lastRowSeats = 5;
            int seatsInPatternRows = (totalSeats > lastRowSeats) ? (totalSeats - lastRowSeats) : 0;
            int patternRows = (seatsInPatternRows + patternCols - 1) / patternCols;
            int totalRows = patternRows + ((totalSeats > lastRowSeats) ? 1 : 0);
            tableLayoutPanel.RowCount = totalRows;
            tableLayoutPanel.ColumnCount = columns;
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < totalRows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }
            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            }

            int seatIndex = 0;

            for (int row = 0; row < patternRows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (col == 2)
                    {
                        tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, row);
                    }
                    else
                    {
                        if (seatIndex < seats.Count)
                        {
                            var seat = seats[seatIndex++];
                            AddSeatButtonToTable(tableLayoutPanel, seat, col, row);
                        }
                        else
                        {
                            tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, row);
                        }
                    }
                }
            }

            int lastRow = patternRows;
            for (int col = 0; col < columns; col++)
            {
                if (seatIndex < seats.Count)
                {
                    var seat = seats[seatIndex++];
                    AddSeatButtonToTable(tableLayoutPanel, seat, col, lastRow);
                }
                else
                {
                    tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, lastRow);
                }
            }

            int startRow = patternRows + 1;
            for (int i = seatIndex; i < seats.Count; i++)
            {
                int row = startRow + (i - seatsInPatternRows) / columns;
                int col = (i - seatsInPatternRows) % columns;

                if (col >= 2) col++;

                if (row < totalRows)
                {
                    if (col >= columns) col = columns - 1;
                    tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.Red }, col, row);
                }
            }
        }
        private void SetUpSeatingPlan2_3_6(TableLayoutPanel tableLayoutPanel, List<BusSeatsBookedDetails> seats, int totalSeats)
        {
            busSeatsBookedDetails = seats;
            int columns = 6;
            int patternCols = columns - 1;
            int lastRowSeats = 6;

            int seatsInPatternRows = (totalSeats > lastRowSeats) ? (totalSeats - lastRowSeats) : 0;
            int patternRows = (seatsInPatternRows + patternCols - 1) / patternCols;
            int totalRows = patternRows + ((totalSeats > lastRowSeats) ? 1 : 0);
            tableLayoutPanel.RowCount = totalRows;
            tableLayoutPanel.ColumnCount = columns;
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Clear();

            for (int i = 0; i < totalRows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }
            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            }

            int seatIndex = 0;

            for (int row = 0; row < patternRows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (col == 2)
                    {
                        tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, row);
                    }
                    else
                    {
                        if (seatIndex < seats.Count)
                        {
                            var seat = seats[seatIndex++];
                            AddSeatButtonToTable(tableLayoutPanel, seat, col, row);
                        }
                        else
                        {
                            tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, row);
                        }
                    }
                }
            }

            int lastRow = patternRows;
            for (int col = 0; col < columns; col++)
            {
                if (seatIndex < seats.Count)
                {
                    var seat = seats[seatIndex++];
                    AddSeatButtonToTable(tableLayoutPanel, seat, col, lastRow);
                }
                else
                {
                    tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.White }, col, lastRow);
                }
            }

            int startRow = patternRows + 1;
            for (int i = seatIndex; i < seats.Count; i++)
            {
                int row = startRow + (i - seatsInPatternRows) / columns;
                int col = (i - seatsInPatternRows) % columns;

                if (col >= 2) col++;

                if (row < totalRows)
                {
                    if (col >= columns) col = columns - 1;
                    tableLayoutPanel.Controls.Add(new Panel { Width = 50, Height = 50, BackColor = Color.Red }, col, row);
                }
            }
        }

        private void AddSeatButtonToTable(TableLayoutPanel tableLayoutPanel, BusSeatsBookedDetails seat, int col, int row)
        {
            Color seatColor = seat.IsBooked
                ? (seat.IsSelected ? Color.Green : Color.Orange)
                : (seat.SeatAssiendColor == "Blue" ? Color.Blue : Color.Gray);

            var seatButton = new Button
            {
                Text = seat.SeatNumber.ToString(),
                BackColor = seatColor,
                Enabled = !seat.IsBooked || seat.IsSelected,
                Width = 50,
                Height = 50,
                Tag = seat,
                Margin = new Padding(3),
                Name = seat.SeatNumber.ToString()
            };

            seatButton.Click += (sender, e) =>
            {
                OnSeatButtonClick(seatButton);
            };

            tableLayoutPanel.Controls.Add(seatButton, col, row);
        }
        private void OnSeatButtonClick(Button seatButton)
        {
            var previousSeat = newSeatNumber;
            if (previousSeat == 0 || previousSeat == null)
            {
                MessageBox.Show("Please select checkbox for change seats");
                return;
            }
            seatButton.BackColor = Color.Green;

            Button myButton = FindButtonByName(previousSeat.ToString());
            if (myButton != null)
            {
                myButton.BackColor = Color.Gray;
                myButton.Enabled = true;
                Tag = busSeatsBookedDetails.Where(x => x.SeatNumber == previousSeat).FirstOrDefault();

            }

            bookingSeatEdit = GetOpenedBookingSeatEditForm();

            bookingSeatEdit.updateCheckBoxLabel(int.Parse(seatButton.Name), int.Parse(previousSeat.ToString()));
        }


        private Button FindButtonByName(string buttonName)
        {
            Control[] controls = tableLayoutPanel.Controls.Find(buttonName, true);
            if (controls.Length > 0 && controls[0] is Button)
            {
                return (Button)controls[0];
            }
            return null;
        }

        private List<MTRDesktopApplication.BusSeatsBookedDetails> MapToUiModel(List<Domain.gettaxiusa.com.Entities.BusSeatsBookedDetails> apiModel)
        {
            var uiModel = new List<MTRDesktopApplication.BusSeatsBookedDetails>();
            foreach (var item in apiModel)
            {
                uiModel.Add(new MTRDesktopApplication.BusSeatsBookedDetails
                {
                    SeatNumber = item.SeatNumber,
                    IsBooked = item.IsBooked,
                    IsSelected = item.IsSelected,
                    SeatAssiendColor = item.SeatAssiendColor
                });
            }
            return uiModel;
        }

        public void ClearSelection()
        {
            if (previouslySelectedSeatButton != null)
            {
                var previousSeat = (BusSeatsBookedDetails)previouslySelectedSeatButton.Tag;
                previousSeat.SeatAssiendColor = previousSeat.IsBooked ? "orange" : "gray";
                previouslySelectedSeatButton.BackColor = Color.FromName(previousSeat.SeatAssiendColor);
                previouslySelectedSeatButton = null;
                SelectedSeatDetails = null;
            }
        }
        public void setSelectedSeatNumber(int seatNo)
        {
            newSeatNumber = seatNo;
        }
    }

    public class BusSeatsBookedDetails
    {
        public int SeatNumber { get; set; }
        public string SeatAssiendColor { get; set; }
        public bool IsBooked { get; set; }
        public bool IsSelected { get; set; }

        public void UpdateSeatDetails(int newSeatNumber, string newColor, bool isBooked)
        {
            SeatNumber = newSeatNumber;
            SeatAssiendColor = newColor;
            IsBooked = isBooked;
        }
    }
}
