namespace MTRDesktopApplication
{
    partial class BookingDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingDetailForm));
            homeBreadcrumbs = new Label();
            pictureBox2 = new PictureBox();
            bookingDetails = new Label();
            panelBookingDetails = new Panel();
            bookingStatuslbl = new Label();
            label40 = new Label();
            destinationNameLbl = new Label();
            bookingName = new Label();
            departureTimelbl = new Label();
            label11 = new Label();
            paymentMethodlbl = new Label();
            seatNumber = new Label();
            pickUpDestination = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox = new PictureBox();
            editBooking = new Button();
            deletebutton = new Button();
            bredcrumbBookingList = new Label();
            pictureBox1 = new PictureBox();
            tickButtonPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // homeBreadcrumbs
            // 
            homeBreadcrumbs.AutoSize = true;
            homeBreadcrumbs.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            homeBreadcrumbs.ForeColor = Color.Black;
            homeBreadcrumbs.Location = new Point(12, 9);
            homeBreadcrumbs.Name = "homeBreadcrumbs";
            homeBreadcrumbs.Size = new Size(67, 24);
            homeBreadcrumbs.TabIndex = 24;
            homeBreadcrumbs.Text = "Home";
            homeBreadcrumbs.Click += homeBreadcrumbs_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(85, 9);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // bookingDetails
            // 
            bookingDetails.AutoSize = true;
            bookingDetails.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            bookingDetails.ForeColor = Color.FromArgb(0, 121, 124);
            bookingDetails.Location = new Point(275, 9);
            bookingDetails.Name = "bookingDetails";
            bookingDetails.Size = new Size(154, 24);
            bookingDetails.TabIndex = 26;
            bookingDetails.Text = "BookingDetails";
            // 
            // panelBookingDetails
            // 
            panelBookingDetails.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBookingDetails.BackColor = Color.FromArgb(244, 255, 255);
            panelBookingDetails.Controls.Add(bookingStatuslbl);
            panelBookingDetails.Controls.Add(label40);
            panelBookingDetails.Controls.Add(destinationNameLbl);
            panelBookingDetails.Controls.Add(bookingName);
            panelBookingDetails.Controls.Add(departureTimelbl);
            panelBookingDetails.Controls.Add(label11);
            panelBookingDetails.Controls.Add(paymentMethodlbl);
            panelBookingDetails.Controls.Add(seatNumber);
            panelBookingDetails.Controls.Add(pickUpDestination);
            panelBookingDetails.Controls.Add(label5);
            panelBookingDetails.Controls.Add(label4);
            panelBookingDetails.Controls.Add(label2);
            panelBookingDetails.Controls.Add(label1);
            panelBookingDetails.Controls.Add(pictureBox);
            panelBookingDetails.Controls.Add(editBooking);
            panelBookingDetails.Controls.Add(deletebutton);
            panelBookingDetails.Location = new Point(12, 57);
            panelBookingDetails.Name = "panelBookingDetails";
            panelBookingDetails.Size = new Size(1135, 327);
            panelBookingDetails.TabIndex = 0;
            // 
            // bookingStatuslbl
            // 
            bookingStatuslbl.Anchor = AnchorStyles.Left;
            bookingStatuslbl.AutoSize = true;
            bookingStatuslbl.Font = new Font("Inter", 13.8F);
            bookingStatuslbl.Location = new Point(497, 96);
            bookingStatuslbl.Name = "bookingStatuslbl";
            bookingStatuslbl.Size = new Size(196, 28);
            bookingStatuslbl.TabIndex = 71;
            bookingStatuslbl.Text = "Payment Method";
            // 
            // label40
            // 
            label40.Anchor = AnchorStyles.Left;
            label40.AutoSize = true;
            label40.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label40.Location = new Point(692, 161);
            label40.Name = "label40";
            label40.Size = new Size(187, 24);
            label40.TabIndex = 70;
            label40.Text = "Destination Name:";
            // 
            // destinationNameLbl
            // 
            destinationNameLbl.Anchor = AnchorStyles.Left;
            destinationNameLbl.AutoSize = true;
            destinationNameLbl.Font = new Font("Inter", 13.8F);
            destinationNameLbl.Location = new Point(885, 161);
            destinationNameLbl.MaximumSize = new Size(450, 0);
            destinationNameLbl.Name = "destinationNameLbl";
            destinationNameLbl.Size = new Size(225, 28);
            destinationNameLbl.TabIndex = 39;
            destinationNameLbl.Text = "destinationNameLbl";
            // 
            // bookingName
            // 
            bookingName.Anchor = AnchorStyles.Left;
            bookingName.AutoSize = true;
            bookingName.Font = new Font("Inter", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookingName.Location = new Point(348, 19);
            bookingName.MaximumSize = new Size(420, 0);
            bookingName.Name = "bookingName";
            bookingName.Size = new Size(134, 49);
            bookingName.TabIndex = 33;
            bookingName.Text = "Name";
            // 
            // departureTimelbl
            // 
            departureTimelbl.Anchor = AnchorStyles.Left;
            departureTimelbl.AutoSize = true;
            departureTimelbl.Font = new Font("Inter", 13.8F);
            departureTimelbl.Location = new Point(871, 96);
            departureTimelbl.Name = "departureTimelbl";
            departureTimelbl.Size = new Size(181, 28);
            departureTimelbl.TabIndex = 32;
            departureTimelbl.Text = "Departure Time";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label11.Location = new Point(692, 96);
            label11.Name = "label11";
            label11.Size = new Size(173, 24);
            label11.TabIndex = 19;
            label11.Text = "Departure Time :";
            // 
            // paymentMethodlbl
            // 
            paymentMethodlbl.Anchor = AnchorStyles.Left;
            paymentMethodlbl.AutoSize = true;
            paymentMethodlbl.Font = new Font("Inter", 13.8F);
            paymentMethodlbl.Location = new Point(509, 161);
            paymentMethodlbl.Name = "paymentMethodlbl";
            paymentMethodlbl.Size = new Size(196, 28);
            paymentMethodlbl.TabIndex = 18;
            paymentMethodlbl.Text = "Payment Method";
            // 
            // seatNumber
            // 
            seatNumber.Anchor = AnchorStyles.Left;
            seatNumber.AutoSize = true;
            seatNumber.Font = new Font("Inter", 13.8F);
            seatNumber.Location = new Point(473, 222);
            seatNumber.Name = "seatNumber";
            seatNumber.Size = new Size(153, 28);
            seatNumber.TabIndex = 15;
            seatNumber.Text = "Seat Number";
            // 
            // pickUpDestination
            // 
            pickUpDestination.Anchor = AnchorStyles.Left;
            pickUpDestination.AutoSize = true;
            pickUpDestination.Font = new Font("Inter", 13.8F);
            pickUpDestination.Location = new Point(908, 222);
            pickUpDestination.MaximumSize = new Size(450, 0);
            pickUpDestination.Name = "pickUpDestination";
            pickUpDestination.Size = new Size(89, 28);
            pickUpDestination.TabIndex = 14;
            pickUpDestination.Text = "PickUp";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label5.Location = new Point(316, 161);
            label5.Name = "label5";
            label5.Size = new Size(187, 24);
            label5.TabIndex = 10;
            label5.Text = "Payment Method :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label4.Location = new Point(316, 96);
            label4.Name = "label4";
            label4.Size = new Size(175, 24);
            label4.TabIndex = 9;
            label4.Text = "Payment Status :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label2.Location = new Point(319, 222);
            label2.Name = "label2";
            label2.Size = new Size(148, 24);
            label2.TabIndex = 7;
            label2.Text = "Seat Number :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label1.Location = new Point(692, 222);
            label1.Name = "label1";
            label1.Size = new Size(210, 24);
            label1.TabIndex = 6;
            label1.Text = "Pick Up Destination :";
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Left;
            pictureBox.Image = Properties.Resources.BusImage;
            pictureBox.Location = new Point(26, 40);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(258, 215);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 72;
            pictureBox.TabStop = false;
            // 
            // editBooking
            // 
            editBooking.Anchor = AnchorStyles.Right;
            editBooking.BackColor = Color.FromArgb(61, 61, 61);
            editBooking.FlatStyle = FlatStyle.Flat;
            editBooking.Font = new Font("Inter", 12F);
            editBooking.ForeColor = Color.White;
            editBooking.Location = new Point(934, 71);
            editBooking.Margin = new Padding(3, 4, 3, 4);
            editBooking.Name = "editBooking";
            editBooking.Size = new Size(169, 60);
            editBooking.TabIndex = 34;
            editBooking.Text = "Edit Booking";
            editBooking.UseVisualStyleBackColor = false;
            editBooking.Click += editBooking_Click;
            // 
            // deletebutton
            // 
            deletebutton.Anchor = AnchorStyles.Right;
            deletebutton.BackColor = Color.FromArgb(248, 10, 25);
            deletebutton.FlatStyle = FlatStyle.Flat;
            deletebutton.Font = new Font("Inter", 12F);
            deletebutton.ForeColor = Color.White;
            deletebutton.Location = new Point(934, 170);
            deletebutton.Margin = new Padding(3, 4, 3, 4);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(169, 60);
            deletebutton.TabIndex = 35;
            deletebutton.Text = "Cancel Booking";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // bredcrumbBookingList
            // 
            bredcrumbBookingList.AutoSize = true;
            bredcrumbBookingList.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            bredcrumbBookingList.ForeColor = Color.Black;
            bredcrumbBookingList.Location = new Point(117, 9);
            bredcrumbBookingList.Name = "bredcrumbBookingList";
            bredcrumbBookingList.Size = new Size(128, 24);
            bredcrumbBookingList.TabIndex = 27;
            bredcrumbBookingList.Text = "Booking List";
            bredcrumbBookingList.Click += bredcrumbBookingList_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(251, 9);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // tickButtonPictureBox
            // 
            tickButtonPictureBox.BackColor = Color.Transparent;
            tickButtonPictureBox.BackgroundImageLayout = ImageLayout.Center;
            tickButtonPictureBox.Dock = DockStyle.Fill;
            tickButtonPictureBox.Image = (Image)resources.GetObject("tickButtonPictureBox.Image");
            tickButtonPictureBox.Location = new Point(0, 0);
            tickButtonPictureBox.Margin = new Padding(3, 4, 3, 4);
            tickButtonPictureBox.Name = "tickButtonPictureBox";
            tickButtonPictureBox.Size = new Size(1159, 433);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 30;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // BookingDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1159, 433);
            Controls.Add(pictureBox1);
            Controls.Add(bredcrumbBookingList);
            Controls.Add(bookingDetails);
            Controls.Add(pictureBox2);
            Controls.Add(homeBreadcrumbs);
            Controls.Add(panelBookingDetails);
            Controls.Add(tickButtonPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingDetailForm";
            Text = "BookingDetailForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBookingDetails.ResumeLayout(false);
            panelBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label homeBreadcrumbs;
        private PictureBox pictureBox2;
        private Label bookingDetails;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private Label paymentMethodlbl;
        private Label paymentStatuslbl;
      
        private Label seatNumber;
        private Label pickUpDestination;
        private Label departureTimelbl;
        private Label bookingName;
        private Button editBooking;
        private Button deletebutton;
        private Panel panelBookingDetails;
        private Label bredcrumbBookingList;
        private PictureBox pictureBox1;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label passengerNameLbl;
        private Label destinationNameLbl;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label numberOfGuestLbl;
        private Label staffIdLbl;
        private Label roomNumberLbl;
        private Label departureOnLbl;
        private Label totalNumberOfPersonLbl;
        private Label hotelIdLbl;
        private Label totalAmountLbl;
        private Label travelTimeLbl;
        private Label kidsUnder2YearsLbl;
        private Label bookingDateLbl;
        private Label vehicleIdLbl;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label numberOfSeatsBookedLbl;
        private Label destinationIdLbl;
        private Label paymentTypeIdLbl;
        private Label passengerIdLbl;
        private Label bookingStatuslbl;
        private PictureBox tickButtonPictureBox;
        private PictureBox pictureBox;
    }
}