using Domain.gettaxiusa.com.Entities;
using MTRDesktopApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTRDesktopApplication.Dtos;
using System.DirectoryServices.ActiveDirectory;

namespace MTRDesktopApplication
{
    public partial class MainLayoutScreen : Form
    {
        private string domainId;
        public MainLayoutScreen()
        {
            InitializeComponent();
            LoadFormIntoPanel(new Login());
            SetRoundPanel(logOutBtn, 5, Color.LightGray);
        }
        public void LoadFormIntoPanel(object form)
        {
            if (this.NavigationPanel.Controls.Count > 0)
                this.NavigationPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            if (f.Text == "Form1")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                ScreenLabel.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                panel3.Visible = true;
                ScreenLabel.Visible = true;
            }
            this.NavigationPanel.Controls.Add(f);
            this.NavigationPanel.Tag = f;
            f.Show();
            if (f.Text == "Dash Board")
            {
                ScreenLabel.Text = "Home";
                ScreenLabel.Visible = true;
                label1.Text = "Admin Panel";

            }
            else
            {
                ScreenLabel.Visible = false;
                label1.Text = f.Text;
            }
        }
        private void SetRoundPanel(Panel panel, int radius, Color borderColor)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(borderColor, 1))
                {
                    Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                    DrawRoundedRectangle(g, pen, rect, radius);
                }
            };
        }
        private void DrawRoundedRectangle(Graphics g, Pen pen, Rectangle bounds, int cornerRadius)
        {
            int diameter = cornerRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            g.DrawArc(pen, arc, 180, 90);
            arc.X = bounds.Right - diameter;
            g.DrawArc(pen, arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            g.DrawArc(pen, arc, 0, 90);
            arc.X = bounds.Left;
            g.DrawArc(pen, arc, 90, 90);
            g.DrawLine(pen, bounds.Left + cornerRadius, bounds.Top, bounds.Right - cornerRadius, bounds.Top);
            g.DrawLine(pen, bounds.Right, bounds.Top + cornerRadius, bounds.Right, bounds.Bottom - cornerRadius);
            g.DrawLine(pen, bounds.Left + cornerRadius, bounds.Bottom, bounds.Right - cornerRadius, bounds.Bottom);
            g.DrawLine(pen, bounds.Left, bounds.Top + cornerRadius, bounds.Left, bounds.Bottom - cornerRadius);
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Login());
        }
        public void StaffListScreen()
        {
            StaffList staffList = new StaffList();
            staffList.Dock = DockStyle.Fill;
            LoadFormIntoPanel(staffList);
        }
        public void AddStaff()
        {
            AddStaff addStaff = new AddStaff();
            addStaff.Dock = DockStyle.Fill;
            LoadFormIntoPanel(addStaff);
        }
        public void DashBoard(EmployeeLoginResponce empinfo)
        {
            this.Text = $"MTR_ReceptionDeskOps - {empinfo.domainName} - {empinfo.nickName} ({empinfo.domainId})";
            welcomeLbl.Text = $"Welcome : {GlobalServices.FirstName}";
            if (GlobalServices.Status == 1)
            {
                statusLbl.Text = "Online";
                statusLbl.ForeColor= Color.Green;
            }
            else
            {
                statusLbl.Text = "Offline";
                statusLbl.ForeColor= Color.Red;
            }
            DashBoard dashBoard = new DashBoard();
            dashBoard.Dock = DockStyle.Fill;
            LoadFormIntoPanel(dashBoard);
        }
        public void HotelListScreen()
        {
            HotelList hotelList = new HotelList();
            hotelList.Dock = DockStyle.Fill;
            LoadFormIntoPanel(hotelList);
        }
        public void PaymentSettings()
        {
            CustomToggle paymentSettings = new CustomToggle();
            paymentSettings.Dock = DockStyle.Fill;
            LoadFormIntoPanel(paymentSettings);
        }
        public void BusTiming()
        {
            BusTiming busTimingDetails = new BusTiming();
            busTimingDetails.Dock = DockStyle.Fill;
            LoadFormIntoPanel(busTimingDetails);
        }
        public void AddHotel()
        {
            AddHotelForm addHotel = new AddHotelForm();
            addHotel.Dock = DockStyle.Fill;
            LoadFormIntoPanel(addHotel);
        }
        public void AddBus()
        {
            AddBusForm addBusForm = new AddBusForm();
            addBusForm.Dock = DockStyle.Fill;
            LoadFormIntoPanel(addBusForm);
        }
        public void EditBusDetail(long Id)
        {
            AddBusForm editBusDetail = new AddBusForm();
            editBusDetail.Dock = DockStyle.Fill;
            editBusDetail.GetSelectedBusId(Id);
            LoadFormIntoPanel(editBusDetail);
        }
        public void EditBustimingDetail(int Id)
        {
            AddBusTiming editBustimingDetail = new AddBusTiming();
            editBustimingDetail.Dock = DockStyle.Fill;
            editBustimingDetail.GetSelectedBusId(Id);
            LoadFormIntoPanel(editBustimingDetail);
        }
        public void HotelDetail(long Id)
        {
            HotelDetail hotelDetail = new HotelDetail();
            hotelDetail.Dock = DockStyle.Fill;
            hotelDetail.GetSelectedHotelId(Id);
            LoadFormIntoPanel(hotelDetail);
        }
        public void BookingList()
        {
            BookingLists bookingList = new BookingLists();
            bookingList.Dock = DockStyle.Fill;
            LoadFormIntoPanel(bookingList);
        }
        public void AddBusRoutes(long Id)
        {
            AddBusRoute addBusRoute = new AddBusRoute();
            addBusRoute.Dock = DockStyle.Fill;
            addBusRoute.GetSelectedBusRouteId(Id);
            LoadFormIntoPanel(addBusRoute);
        }
        public void AddBusRoute()
        {
            AddBusRoute addBusRoute = new AddBusRoute();
            addBusRoute.Dock = DockStyle.Fill;
            LoadFormIntoPanel(addBusRoute);
        }
        public void BusListScreen()
        {
            BusList busList = new BusList();
            busList.Dock = DockStyle.Fill;
            LoadFormIntoPanel(busList);
        }
        public void VehicleListScreen()
        {
            BusList busList = new BusList();
            busList.Dock = DockStyle.Fill;
            LoadFormIntoPanel(busList);
        }
        public void BusDetailForm(int Id)
        {
            BusDetailForm busDetailForm = new BusDetailForm();
            busDetailForm.Dock = DockStyle.Fill;
            busDetailForm.GetSelectedVehicleId(Id);
            LoadFormIntoPanel(busDetailForm);
        }
        public void BookingDetailForm(int Id)
        {
            BookingDetailForm bookingDetailForm = new BookingDetailForm();
            bookingDetailForm.Dock = DockStyle.Fill;
            bookingDetailForm.GetSelectedVehicleId(Id);
            LoadFormIntoPanel(bookingDetailForm);
        }
        public void BusTimingDetailForm(int Id)
        {
            BusTimingDetails busDetailForm = new BusTimingDetails();
            busDetailForm.Dock = DockStyle.Fill;
            busDetailForm.GetSelectedBusTimingId(Id);
            LoadFormIntoPanel(busDetailForm);
        }
        public void BusRouteScreen()
        {
            BusRoute busRoute = new BusRoute();
            busRoute.Dock = DockStyle.Fill;
            LoadFormIntoPanel(busRoute);
        }
        public void Home()
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Dock = DockStyle.Fill;
            LoadFormIntoPanel(dashBoard);
        }
        public void AddBusTimingScreen()
        {
            AddBusTiming addBusTiming = new AddBusTiming();
            addBusTiming.Dock = DockStyle.Fill;
            LoadFormIntoPanel(addBusTiming);
        }
        public void StaffDetails(int Id)
        {
            StaffDetails staffDetails = new StaffDetails();
            staffDetails.Dock = DockStyle.Fill;
            staffDetails.GetSelectedStaffId(Id);
            LoadFormIntoPanel(staffDetails);
        }
        public void StaffDetail()
        {
            StaffDetails staffDetail = new StaffDetails();
            staffDetail.Dock = DockStyle.Fill;
            LoadFormIntoPanel(staffDetail);
        }
        public void payment()
        {
            Settings payment = new Settings();
            payment.Dock = DockStyle.Fill;
            LoadFormIntoPanel(payment);
        }

        private void logOutBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainLayoutScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
