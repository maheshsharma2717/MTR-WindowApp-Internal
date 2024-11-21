namespace MTRDesktopApplication
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            mainPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            StaffListpanel = new Panel();
            StaffListPictureBox = new PictureBox();
            StaffListLabel = new Label();
            HotelListPanel = new Panel();
            HotelListLabel = new Label();
            HotelListPictureBox = new PictureBox();
            BusRoutePanel = new Panel();
            BusRouteLabel = new Label();
            BusRoutePictureBox = new PictureBox();
            AddBuspanel = new Panel();
            busList = new Label();
            AddbusPictureBox = new PictureBox();
            BusTimingPanel = new Panel();
            BusTimngPanelLabel = new Label();
            BusTimingPictureBox = new PictureBox();
            Bookingpanel = new Panel();
            Bookinglabel = new Label();
            BookingpictureBox = new PictureBox();
            Paymentpanel = new Panel();
            Paymentlabel = new Label();
            PaymentpictureBox = new PictureBox();
            mainPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            StaffListpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StaffListPictureBox).BeginInit();
            HotelListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HotelListPictureBox).BeginInit();
            BusRoutePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BusRoutePictureBox).BeginInit();
            AddBuspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddbusPictureBox).BeginInit();
            BusTimingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BusTimingPictureBox).BeginInit();
            Bookingpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookingpictureBox).BeginInit();
            Paymentpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentpictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(flowLayoutPanel1);
            mainPanel.Location = new Point(17, 16);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(893, 729);
            mainPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(StaffListpanel);
            flowLayoutPanel1.Controls.Add(HotelListPanel);
            flowLayoutPanel1.Controls.Add(BusRoutePanel);
            flowLayoutPanel1.Controls.Add(AddBuspanel);
            flowLayoutPanel1.Controls.Add(BusTimingPanel);
            flowLayoutPanel1.Controls.Add(Bookingpanel);
            flowLayoutPanel1.Controls.Add(Paymentpanel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(893, 729);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // StaffListpanel
            // 
            StaffListpanel.Anchor = AnchorStyles.None;
            StaffListpanel.AutoScroll = true;
            StaffListpanel.BackColor = Color.FromArgb(244, 255, 255);
            StaffListpanel.BorderStyle = BorderStyle.FixedSingle;
            StaffListpanel.Controls.Add(StaffListPictureBox);
            StaffListpanel.Controls.Add(StaffListLabel);
            StaffListpanel.Location = new Point(17, 20);
            StaffListpanel.Margin = new Padding(17, 20, 17, 20);
            StaffListpanel.Name = "StaffListpanel";
            StaffListpanel.Size = new Size(196, 199);
            StaffListpanel.TabIndex = 0;
            StaffListpanel.Click += StaffListpanel_Click;
            // 
            // StaffListPictureBox
            // 
            StaffListPictureBox.Image = (Image)resources.GetObject("StaffListPictureBox.Image");
            StaffListPictureBox.Location = new Point(71, 53);
            StaffListPictureBox.Margin = new Padding(3, 4, 3, 4);
            StaffListPictureBox.Name = "StaffListPictureBox";
            StaffListPictureBox.Size = new Size(39, 39);
            StaffListPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            StaffListPictureBox.TabIndex = 1;
            StaffListPictureBox.TabStop = false;
            StaffListPictureBox.Click += StaffListPictureBox_Click;
            // 
            // StaffListLabel
            // 
            StaffListLabel.AutoSize = true;
            StaffListLabel.Font = new Font("Inter", 12F);
            StaffListLabel.ForeColor = Color.FromArgb(115, 115, 115);
            StaffListLabel.Location = new Point(48, 107);
            StaffListLabel.Name = "StaffListLabel";
            StaffListLabel.Size = new Size(94, 24);
            StaffListLabel.TabIndex = 0;
            StaffListLabel.Text = "Staff List";
            StaffListLabel.Click += StaffListLabel_Click;
            // 
            // HotelListPanel
            // 
            HotelListPanel.BackColor = Color.FromArgb(244, 255, 255);
            HotelListPanel.BorderStyle = BorderStyle.FixedSingle;
            HotelListPanel.Controls.Add(HotelListLabel);
            HotelListPanel.Controls.Add(HotelListPictureBox);
            HotelListPanel.Location = new Point(247, 20);
            HotelListPanel.Margin = new Padding(17, 20, 17, 20);
            HotelListPanel.Name = "HotelListPanel";
            HotelListPanel.Size = new Size(196, 199);
            HotelListPanel.TabIndex = 2;
            HotelListPanel.Click += HotelListPanel_Click;
            // 
            // HotelListLabel
            // 
            HotelListLabel.AutoSize = true;
            HotelListLabel.Font = new Font("Inter", 12F);
            HotelListLabel.ForeColor = Color.FromArgb(115, 115, 115);
            HotelListLabel.Location = new Point(52, 111);
            HotelListLabel.Name = "HotelListLabel";
            HotelListLabel.Size = new Size(100, 24);
            HotelListLabel.TabIndex = 3;
            HotelListLabel.Text = "Hotel List";
            HotelListLabel.Click += HotelListLabel_Click;
            // 
            // HotelListPictureBox
            // 
            HotelListPictureBox.Image = (Image)resources.GetObject("HotelListPictureBox.Image");
            HotelListPictureBox.Location = new Point(79, 53);
            HotelListPictureBox.Margin = new Padding(3, 4, 3, 4);
            HotelListPictureBox.Name = "HotelListPictureBox";
            HotelListPictureBox.Size = new Size(39, 39);
            HotelListPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            HotelListPictureBox.TabIndex = 2;
            HotelListPictureBox.TabStop = false;
            HotelListPictureBox.Click += HotelListPictureBox_Click;
            // 
            // BusRoutePanel
            // 
            BusRoutePanel.BackColor = Color.FromArgb(244, 255, 255);
            BusRoutePanel.BorderStyle = BorderStyle.FixedSingle;
            BusRoutePanel.Controls.Add(BusRouteLabel);
            BusRoutePanel.Controls.Add(BusRoutePictureBox);
            BusRoutePanel.Location = new Point(477, 20);
            BusRoutePanel.Margin = new Padding(17, 20, 17, 20);
            BusRoutePanel.Name = "BusRoutePanel";
            BusRoutePanel.Size = new Size(196, 199);
            BusRoutePanel.TabIndex = 3;
            BusRoutePanel.Click += BusRoutePanel_Click;
            // 
            // BusRouteLabel
            // 
            BusRouteLabel.AutoSize = true;
            BusRouteLabel.Font = new Font("Inter", 12F);
            BusRouteLabel.ForeColor = Color.FromArgb(115, 115, 115);
            BusRouteLabel.Location = new Point(44, 111);
            BusRouteLabel.Name = "BusRouteLabel";
            BusRouteLabel.Size = new Size(107, 24);
            BusRouteLabel.TabIndex = 3;
            BusRouteLabel.Text = "Bus Route";
            BusRouteLabel.Click += BusRouteLabel_Click;
            // 
            // BusRoutePictureBox
            // 
            BusRoutePictureBox.Image = (Image)resources.GetObject("BusRoutePictureBox.Image");
            BusRoutePictureBox.Location = new Point(75, 53);
            BusRoutePictureBox.Margin = new Padding(3, 4, 3, 4);
            BusRoutePictureBox.Name = "BusRoutePictureBox";
            BusRoutePictureBox.Size = new Size(39, 39);
            BusRoutePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BusRoutePictureBox.TabIndex = 2;
            BusRoutePictureBox.TabStop = false;
            BusRoutePictureBox.Click += BusRoutePictureBox_Click;
            // 
            // AddBuspanel
            // 
            AddBuspanel.BackColor = Color.FromArgb(244, 255, 255);
            AddBuspanel.BorderStyle = BorderStyle.FixedSingle;
            AddBuspanel.Controls.Add(busList);
            AddBuspanel.Controls.Add(AddbusPictureBox);
            AddBuspanel.Location = new Point(17, 259);
            AddBuspanel.Margin = new Padding(17, 20, 17, 20);
            AddBuspanel.Name = "AddBuspanel";
            AddBuspanel.Size = new Size(196, 199);
            AddBuspanel.TabIndex = 5;
            AddBuspanel.Click += AddbusPanel_Click;
            // 
            // busList
            // 
            busList.AutoSize = true;
            busList.Font = new Font("Inter", 12F);
            busList.ForeColor = Color.FromArgb(115, 115, 115);
            busList.Location = new Point(48, 113);
            busList.Name = "busList";
            busList.Size = new Size(84, 24);
            busList.TabIndex = 3;
            busList.Text = "Bus List";
            busList.Click += AddBusLabel_Click;
            // 
            // AddbusPictureBox
            // 
            AddbusPictureBox.Image = (Image)resources.GetObject("AddbusPictureBox.Image");
            AddbusPictureBox.Location = new Point(69, 61);
            AddbusPictureBox.Margin = new Padding(3, 4, 3, 4);
            AddbusPictureBox.Name = "AddbusPictureBox";
            AddbusPictureBox.Size = new Size(39, 39);
            AddbusPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AddbusPictureBox.TabIndex = 2;
            AddbusPictureBox.TabStop = false;
            AddbusPictureBox.Click += AddbusPictureBox_Click;
            // 
            // BusTimingPanel
            // 
            BusTimingPanel.BackColor = Color.FromArgb(244, 255, 255);
            BusTimingPanel.BorderStyle = BorderStyle.FixedSingle;
            BusTimingPanel.Controls.Add(BusTimngPanelLabel);
            BusTimingPanel.Controls.Add(BusTimingPictureBox);
            BusTimingPanel.Location = new Point(247, 259);
            BusTimingPanel.Margin = new Padding(17, 20, 17, 20);
            BusTimingPanel.Name = "BusTimingPanel";
            BusTimingPanel.Size = new Size(196, 199);
            BusTimingPanel.TabIndex = 4;
            BusTimingPanel.Click += BusTimingPanel_Click;
            // 
            // BusTimngPanelLabel
            // 
            BusTimngPanelLabel.AutoSize = true;
            BusTimngPanelLabel.Font = new Font("Inter", 12F);
            BusTimngPanelLabel.ForeColor = Color.FromArgb(115, 115, 115);
            BusTimngPanelLabel.Location = new Point(4, 109);
            BusTimngPanelLabel.Name = "BusTimngPanelLabel";
            BusTimngPanelLabel.Size = new Size(185, 24);
            BusTimngPanelLabel.TabIndex = 3;
            BusTimngPanelLabel.Text = "Bus Timing Details";
            BusTimngPanelLabel.Click += BusTimngPanelLabel_Click;
            // 
            // BusTimingPictureBox
            // 
            BusTimingPictureBox.Image = (Image)resources.GetObject("BusTimingPictureBox.Image");
            BusTimingPictureBox.Location = new Point(70, 61);
            BusTimingPictureBox.Margin = new Padding(3, 4, 3, 4);
            BusTimingPictureBox.Name = "BusTimingPictureBox";
            BusTimingPictureBox.Size = new Size(39, 39);
            BusTimingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BusTimingPictureBox.TabIndex = 2;
            BusTimingPictureBox.TabStop = false;
            BusTimingPictureBox.Click += BusTimingPictureBox_Click;
            // 
            // Bookingpanel
            // 
            Bookingpanel.BackColor = Color.FromArgb(244, 255, 255);
            Bookingpanel.BorderStyle = BorderStyle.FixedSingle;
            Bookingpanel.Controls.Add(Bookinglabel);
            Bookingpanel.Controls.Add(BookingpictureBox);
            Bookingpanel.Location = new Point(477, 259);
            Bookingpanel.Margin = new Padding(17, 20, 17, 20);
            Bookingpanel.Name = "Bookingpanel";
            Bookingpanel.Size = new Size(196, 199);
            Bookingpanel.TabIndex = 6;
            Bookingpanel.Click += Bookingpanel_Click;
            // 
            // Bookinglabel
            // 
            Bookinglabel.AutoSize = true;
            Bookinglabel.Font = new Font("Inter", 12F);
            Bookinglabel.ForeColor = Color.FromArgb(115, 115, 115);
            Bookinglabel.Location = new Point(38, 113);
            Bookinglabel.Name = "Bookinglabel";
            Bookinglabel.Size = new Size(126, 24);
            Bookinglabel.TabIndex = 3;
            Bookinglabel.Text = "Booking List";
            Bookinglabel.Click += Bookinglabel_Click;
            // 
            // BookingpictureBox
            // 
            BookingpictureBox.Image = (Image)resources.GetObject("BookingpictureBox.Image");
            BookingpictureBox.Location = new Point(75, 61);
            BookingpictureBox.Margin = new Padding(3, 4, 3, 4);
            BookingpictureBox.Name = "BookingpictureBox";
            BookingpictureBox.Size = new Size(39, 39);
            BookingpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BookingpictureBox.TabIndex = 2;
            BookingpictureBox.TabStop = false;
            BookingpictureBox.Click += BookingpictureBox_Click;
            // 
            // Paymentpanel
            // 
            Paymentpanel.BackColor = Color.FromArgb(244, 255, 255);
            Paymentpanel.BorderStyle = BorderStyle.FixedSingle;
            Paymentpanel.Controls.Add(Paymentlabel);
            Paymentpanel.Controls.Add(PaymentpictureBox);
            Paymentpanel.Location = new Point(17, 498);
            Paymentpanel.Margin = new Padding(17, 20, 17, 20);
            Paymentpanel.Name = "Paymentpanel";
            Paymentpanel.Size = new Size(196, 199);
            Paymentpanel.TabIndex = 7;
            Paymentpanel.Click += Paymentpanel_Click;
            // 
            // Paymentlabel
            // 
            Paymentlabel.AutoSize = true;
            Paymentlabel.Font = new Font("Inter", 12F);
            Paymentlabel.ForeColor = Color.FromArgb(115, 115, 115);
            Paymentlabel.Location = new Point(49, 113);
            Paymentlabel.Name = "Paymentlabel";
            Paymentlabel.Size = new Size(94, 24);
            Paymentlabel.TabIndex = 3;
            Paymentlabel.Text = " Settings";
            Paymentlabel.Click += Paymentlabel_Click;
            // 
            // PaymentpictureBox
            // 
            PaymentpictureBox.Image = (Image)resources.GetObject("PaymentpictureBox.Image");
            PaymentpictureBox.Location = new Point(77, 58);
            PaymentpictureBox.Margin = new Padding(3, 4, 3, 4);
            PaymentpictureBox.Name = "PaymentpictureBox";
            PaymentpictureBox.Size = new Size(39, 39);
            PaymentpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PaymentpictureBox.TabIndex = 2;
            PaymentpictureBox.TabStop = false;
            PaymentpictureBox.Click += PaymentpictureBox_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(922, 757);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoard";
            Text = "Dash Board";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            StaffListpanel.ResumeLayout(false);
            StaffListpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StaffListPictureBox).EndInit();
            HotelListPanel.ResumeLayout(false);
            HotelListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HotelListPictureBox).EndInit();
            BusRoutePanel.ResumeLayout(false);
            BusRoutePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BusRoutePictureBox).EndInit();
            AddBuspanel.ResumeLayout(false);
            AddBuspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddbusPictureBox).EndInit();
            BusTimingPanel.ResumeLayout(false);
            BusTimingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BusTimingPictureBox).EndInit();
            Bookingpanel.ResumeLayout(false);
            Bookingpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookingpictureBox).EndInit();
            Paymentpanel.ResumeLayout(false);
            Paymentpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentpictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private PictureBox StaffListPictureBox;
        private Label StaffListLabel;
        private Panel HotelListPanel;
        private Label HotelListLabel;
        private PictureBox HotelListPictureBox;
        private Panel BusRoutePanel;
        private Label BusRouteLabel;
        private PictureBox BusRoutePictureBox;
        private Panel panel6;
        private Label label4;
        private PictureBox pictureBox4;
        private Panel panel7;
        private Label label5;
        private PictureBox pictureBox5;
        private Panel panel9;
        private Label label7;
        private PictureBox pictureBox7;
        private Panel panel10;
        private Label label8;
        private PictureBox pictureBox8;
        private Panel insidepanel;
        private Panel mainPanel;
        private Panel StaffListpanel;
        private Panel AddBuspanel;
        private Label AddBusLabel;
        private PictureBox AddbusPictureBox;
        private Panel BusTimngPanel;
        private Panel BusTimingPanel;
        private Label BusTimngPanelLabel;
        private PictureBox BusTimingPictureBox;
        private Panel Bookingpanel;
        private Label Bookinglabel;
        private PictureBox BookingpictureBox;
        private Panel Paymentpanel;
        private Label Paymentlabel;
        private PictureBox PaymentpictureBox;
        private Label busList;
    }
}