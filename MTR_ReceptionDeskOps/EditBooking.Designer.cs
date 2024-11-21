namespace MTRDesktopApplication
{
    partial class EditBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBooking));
            panel1 = new Panel();
            seatChangeBtn = new Button();
            panel20 = new Panel();
            dateTimePickerArrivalTime = new CustomControls.CustomTimePicker();
            label18 = new Label();
            panel19 = new Panel();
            bookingDatePicker = new CustomControls.CustomDateTimePicker();
            label17 = new Label();
            label16 = new Label();
            label13 = new Label();
            label12 = new Label();
            panel13 = new Panel();
            kidsUnder2YearsTextBox = new TextBox();
            panel14 = new Panel();
            comboBoxDestination = new ComboBox();
            panel18 = new Panel();
            totalAmountTextBox = new TextBox();
            panel5 = new Panel();
            vehicleTextBox = new TextBox();
            panel8 = new Panel();
            totalNumberOfPersonTextBox = new TextBox();
            panel9 = new Panel();
            roomNumberTextBox = new TextBox();
            panel10 = new Panel();
            numberOfGuestTextBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel11 = new Panel();
            numberOfSeatsBookedTextBox = new TextBox();
            panel12 = new Panel();
            paymentStatusTextBox = new TextBox();
            errorPaymentMethod = new Label();
            errorDeparture = new Label();
            errorSeat = new Label();
            errorDestination = new Label();
            errorName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel7 = new Panel();
            dateTimePickerDepartureTime = new CustomControls.CustomTimePicker();
            Savebutton = new Button();
            Heading = new Label();
            closeButton = new Panel();
            bookingStatusCheckBox = new CheckBox();
            panel2 = new Panel();
            comboBoxPickup = new ComboBox();
            panel4 = new Panel();
            seatNumberTextBox = new TextBox();
            panel6 = new Panel();
            paymentMethodTextBox = new TextBox();
            panel3 = new Panel();
            bookingNameTextBox = new TextBox();
            tickButtonPictureBox = new PictureBox();
            panel1.SuspendLayout();
            panel20.SuspendLayout();
            panel19.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel18.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(seatChangeBtn);
            panel1.Controls.Add(panel20);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(panel19);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(panel14);
            panel1.Controls.Add(panel18);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(errorPaymentMethod);
            panel1.Controls.Add(errorDeparture);
            panel1.Controls.Add(errorSeat);
            panel1.Controls.Add(errorDestination);
            panel1.Controls.Add(errorName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(Savebutton);
            panel1.Controls.Add(Heading);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(bookingStatusCheckBox);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tickButtonPictureBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 1124);
            panel1.TabIndex = 0;
            // 
            // seatChangeBtn
            // 
            seatChangeBtn.Anchor = AnchorStyles.None;
            seatChangeBtn.BackColor = Color.MediumAquamarine;
            seatChangeBtn.FlatStyle = FlatStyle.Flat;
            seatChangeBtn.Font = new Font("Inter", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seatChangeBtn.ForeColor = Color.White;
            seatChangeBtn.Location = new Point(305, 345);
            seatChangeBtn.Margin = new Padding(3, 2, 3, 2);
            seatChangeBtn.Name = "seatChangeBtn";
            seatChangeBtn.Size = new Size(106, 52);
            seatChangeBtn.TabIndex = 111;
            seatChangeBtn.Text = "Change";
            seatChangeBtn.UseVisualStyleBackColor = false;
            seatChangeBtn.Click += seatChangeBtn_Click;
            // 
            // panel20
            // 
            panel20.Anchor = AnchorStyles.None;
            panel20.BackColor = Color.FromArgb(249, 249, 249);
            panel20.Controls.Add(dateTimePickerArrivalTime);
            panel20.Location = new Point(445, 803);
            panel20.Name = "panel20";
            panel20.Size = new Size(382, 52);
            panel20.TabIndex = 69;
            // 
            // dateTimePickerArrivalTime
            // 
            dateTimePickerArrivalTime.BorderColor = Color.PaleVioletRed;
            dateTimePickerArrivalTime.BorderSize = 0;
            dateTimePickerArrivalTime.CustomFormat = "hh:mm tt";
            dateTimePickerArrivalTime.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerArrivalTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerArrivalTime.Location = new Point(6, 9);
            dateTimePickerArrivalTime.MinimumSize = new Size(0, 35);
            dateTimePickerArrivalTime.Name = "dateTimePickerArrivalTime";
            dateTimePickerArrivalTime.ShowUpDown = true;
            dateTimePickerArrivalTime.Size = new Size(370, 35);
            dateTimePickerArrivalTime.SkinColor = Color.FromArgb(249, 249, 249);
            dateTimePickerArrivalTime.TabIndex = 1;
            dateTimePickerArrivalTime.TextColor = Color.Black;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label18.Location = new Point(446, 431);
            label18.Name = "label18";
            label18.Size = new Size(185, 21);
            label18.TabIndex = 109;
            label18.Text = "Booking Date Picker";
            // 
            // panel19
            // 
            panel19.Anchor = AnchorStyles.None;
            panel19.BackColor = Color.FromArgb(249, 249, 249);
            panel19.Controls.Add(bookingDatePicker);
            panel19.Location = new Point(446, 462);
            panel19.Name = "panel19";
            panel19.Size = new Size(382, 52);
            panel19.TabIndex = 69;
            // 
            // bookingDatePicker
            // 
            bookingDatePicker.BorderColor = Color.PaleVioletRed;
            bookingDatePicker.BorderSize = 0;
            bookingDatePicker.CalendarTitleForeColor = Color.AliceBlue;
            bookingDatePicker.Font = new Font("Segoe UI", 10F);
            bookingDatePicker.Location = new Point(8, 9);
            bookingDatePicker.MinimumSize = new Size(0, 35);
            bookingDatePicker.Name = "bookingDatePicker";
            bookingDatePicker.Size = new Size(368, 35);
            bookingDatePicker.SkinColor = Color.FromArgb(249, 249, 249);
            bookingDatePicker.TabIndex = 111;
            bookingDatePicker.TextColor = SystemColors.WindowText;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label17.Location = new Point(30, 771);
            label17.Name = "label17";
            label17.Size = new Size(161, 21);
            label17.TabIndex = 108;
            label17.Text = "Kids under 2 year";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label16.Location = new Point(446, 886);
            label16.Name = "label16";
            label16.Size = new Size(115, 21);
            label16.TabIndex = 107;
            label16.Text = "Destination ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label13.Location = new Point(446, 771);
            label13.Name = "label13";
            label13.Size = new Size(127, 21);
            label13.TabIndex = 104;
            label13.Text = "Pick Up Time ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label12.Location = new Point(446, 658);
            label12.Name = "label12";
            label12.Size = new Size(127, 21);
            label12.TabIndex = 103;
            label12.Text = "Total Amount";
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.None;
            panel13.BackColor = Color.FromArgb(249, 249, 249);
            panel13.Controls.Add(kidsUnder2YearsTextBox);
            panel13.Location = new Point(28, 803);
            panel13.Name = "panel13";
            panel13.Size = new Size(382, 52);
            panel13.TabIndex = 45;
            // 
            // kidsUnder2YearsTextBox
            // 
            kidsUnder2YearsTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kidsUnder2YearsTextBox.BackColor = Color.FromArgb(249, 249, 249);
            kidsUnder2YearsTextBox.BorderStyle = BorderStyle.None;
            kidsUnder2YearsTextBox.Cursor = Cursors.IBeam;
            kidsUnder2YearsTextBox.Font = new Font("Inter", 10F);
            kidsUnder2YearsTextBox.Location = new Point(12, 17);
            kidsUnder2YearsTextBox.Name = "kidsUnder2YearsTextBox";
            kidsUnder2YearsTextBox.PlaceholderText = "Enter Kids Under 2yr";
            kidsUnder2YearsTextBox.ReadOnly = true;
            kidsUnder2YearsTextBox.Size = new Size(362, 21);
            kidsUnder2YearsTextBox.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.None;
            panel14.BackColor = Color.FromArgb(249, 249, 249);
            panel14.Controls.Add(comboBoxDestination);
            panel14.Location = new Point(446, 918);
            panel14.Name = "panel14";
            panel14.Size = new Size(382, 52);
            panel14.TabIndex = 45;
            // 
            // comboBoxDestination
            // 
            comboBoxDestination.BackColor = Color.FromArgb(249, 249, 249);
            comboBoxDestination.FlatStyle = FlatStyle.Flat;
            comboBoxDestination.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDestination.FormattingEnabled = true;
            comboBoxDestination.Location = new Point(9, 12);
            comboBoxDestination.Name = "comboBoxDestination";
            comboBoxDestination.Size = new Size(365, 29);
            comboBoxDestination.TabIndex = 2;
            comboBoxDestination.SelectedIndexChanged += comboBoxDestination_SelectedIndexChanged;
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.None;
            panel18.BackColor = Color.FromArgb(249, 249, 249);
            panel18.Controls.Add(totalAmountTextBox);
            panel18.Location = new Point(446, 689);
            panel18.Name = "panel18";
            panel18.Size = new Size(382, 52);
            panel18.TabIndex = 45;
            // 
            // totalAmountTextBox
            // 
            totalAmountTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalAmountTextBox.BackColor = Color.FromArgb(249, 249, 249);
            totalAmountTextBox.BorderStyle = BorderStyle.None;
            totalAmountTextBox.Cursor = Cursors.IBeam;
            totalAmountTextBox.Font = new Font("Inter", 10F);
            totalAmountTextBox.Location = new Point(13, 16);
            totalAmountTextBox.Name = "totalAmountTextBox";
            totalAmountTextBox.PlaceholderText = "Enter Total Amount";
            totalAmountTextBox.Size = new Size(363, 21);
            totalAmountTextBox.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(249, 249, 249);
            panel5.Controls.Add(vehicleTextBox);
            panel5.Location = new Point(446, 576);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 52);
            panel5.TabIndex = 44;
            // 
            // vehicleTextBox
            // 
            vehicleTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            vehicleTextBox.BackColor = Color.FromArgb(249, 249, 249);
            vehicleTextBox.BorderStyle = BorderStyle.None;
            vehicleTextBox.Cursor = Cursors.IBeam;
            vehicleTextBox.Font = new Font("Inter", 10F);
            vehicleTextBox.Location = new Point(13, 17);
            vehicleTextBox.Name = "vehicleTextBox";
            vehicleTextBox.PlaceholderText = "Bus Name";
            vehicleTextBox.ReadOnly = true;
            vehicleTextBox.Size = new Size(357, 21);
            vehicleTextBox.TabIndex = 0;
            vehicleTextBox.TextChanged += vehicleTextBox_TextChanged;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = Color.FromArgb(249, 249, 249);
            panel8.Controls.Add(totalNumberOfPersonTextBox);
            panel8.Location = new Point(446, 345);
            panel8.Name = "panel8";
            panel8.Size = new Size(382, 52);
            panel8.TabIndex = 44;
            // 
            // totalNumberOfPersonTextBox
            // 
            totalNumberOfPersonTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalNumberOfPersonTextBox.BackColor = Color.FromArgb(249, 249, 249);
            totalNumberOfPersonTextBox.BorderStyle = BorderStyle.None;
            totalNumberOfPersonTextBox.Cursor = Cursors.IBeam;
            totalNumberOfPersonTextBox.Font = new Font("Inter", 10F);
            totalNumberOfPersonTextBox.Location = new Point(13, 16);
            totalNumberOfPersonTextBox.Name = "totalNumberOfPersonTextBox";
            totalNumberOfPersonTextBox.PlaceholderText = "Enter Total Number Of Person";
            totalNumberOfPersonTextBox.ReadOnly = true;
            totalNumberOfPersonTextBox.Size = new Size(363, 21);
            totalNumberOfPersonTextBox.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.BackColor = Color.FromArgb(249, 249, 249);
            panel9.Controls.Add(roomNumberTextBox);
            panel9.Location = new Point(446, 232);
            panel9.Name = "panel9";
            panel9.Size = new Size(382, 52);
            panel9.TabIndex = 44;
            // 
            // roomNumberTextBox
            // 
            roomNumberTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            roomNumberTextBox.BackColor = Color.FromArgb(249, 249, 249);
            roomNumberTextBox.BorderStyle = BorderStyle.None;
            roomNumberTextBox.Cursor = Cursors.IBeam;
            roomNumberTextBox.Font = new Font("Inter", 10F);
            roomNumberTextBox.Location = new Point(13, 16);
            roomNumberTextBox.Name = "roomNumberTextBox";
            roomNumberTextBox.PlaceholderText = "Enter Room Number";
            roomNumberTextBox.ReadOnly = true;
            roomNumberTextBox.Size = new Size(363, 21);
            roomNumberTextBox.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.BackColor = Color.FromArgb(249, 249, 249);
            panel10.Controls.Add(numberOfGuestTextBox);
            panel10.Location = new Point(446, 116);
            panel10.Name = "panel10";
            panel10.Size = new Size(382, 52);
            panel10.TabIndex = 44;
            // 
            // numberOfGuestTextBox
            // 
            numberOfGuestTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numberOfGuestTextBox.BackColor = Color.FromArgb(249, 249, 249);
            numberOfGuestTextBox.BorderStyle = BorderStyle.None;
            numberOfGuestTextBox.Cursor = Cursors.IBeam;
            numberOfGuestTextBox.Font = new Font("Inter", 10F);
            numberOfGuestTextBox.Location = new Point(14, 16);
            numberOfGuestTextBox.Name = "numberOfGuestTextBox";
            numberOfGuestTextBox.PlaceholderText = "Number Of Guest";
            numberOfGuestTextBox.ReadOnly = true;
            numberOfGuestTextBox.Size = new Size(362, 21);
            numberOfGuestTextBox.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label11.Location = new Point(30, 658);
            label11.Name = "label11";
            label11.Size = new Size(148, 21);
            label11.TabIndex = 102;
            label11.Text = "Payment Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label10.Location = new Point(28, 198);
            label10.Name = "label10";
            label10.Size = new Size(158, 21);
            label10.TabIndex = 101;
            label10.Text = "Number Of Seats";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label9.Location = new Point(449, 314);
            label9.Name = "label9";
            label9.Size = new Size(122, 21);
            label9.TabIndex = 100;
            label9.Text = "No of Person";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label8.Location = new Point(446, 545);
            label8.Name = "label8";
            label8.Size = new Size(97, 21);
            label8.TabIndex = 99;
            label8.Text = "Bus Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label7.Location = new Point(448, 198);
            label7.Name = "label7";
            label7.Size = new Size(133, 21);
            label7.TabIndex = 98;
            label7.Text = "Room Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(446, 83);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 97;
            label6.Text = "No of Guest";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.None;
            panel11.BackColor = Color.FromArgb(249, 249, 249);
            panel11.Controls.Add(numberOfSeatsBookedTextBox);
            panel11.Location = new Point(28, 232);
            panel11.Name = "panel11";
            panel11.Size = new Size(382, 52);
            panel11.TabIndex = 44;
            // 
            // numberOfSeatsBookedTextBox
            // 
            numberOfSeatsBookedTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numberOfSeatsBookedTextBox.BackColor = Color.FromArgb(249, 249, 249);
            numberOfSeatsBookedTextBox.BorderStyle = BorderStyle.None;
            numberOfSeatsBookedTextBox.Cursor = Cursors.IBeam;
            numberOfSeatsBookedTextBox.Font = new Font("Inter", 10F);
            numberOfSeatsBookedTextBox.Location = new Point(13, 16);
            numberOfSeatsBookedTextBox.Name = "numberOfSeatsBookedTextBox";
            numberOfSeatsBookedTextBox.PlaceholderText = "Enter Number Of Seats ";
            numberOfSeatsBookedTextBox.ReadOnly = true;
            numberOfSeatsBookedTextBox.Size = new Size(357, 21);
            numberOfSeatsBookedTextBox.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.None;
            panel12.BackColor = Color.FromArgb(249, 249, 249);
            panel12.Controls.Add(paymentStatusTextBox);
            panel12.Location = new Point(28, 689);
            panel12.Name = "panel12";
            panel12.Size = new Size(382, 52);
            panel12.TabIndex = 44;
            // 
            // paymentStatusTextBox
            // 
            paymentStatusTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paymentStatusTextBox.BackColor = Color.FromArgb(249, 249, 249);
            paymentStatusTextBox.BorderStyle = BorderStyle.None;
            paymentStatusTextBox.Cursor = Cursors.IBeam;
            paymentStatusTextBox.Font = new Font("Inter", 10F);
            paymentStatusTextBox.Location = new Point(11, 16);
            paymentStatusTextBox.Name = "paymentStatusTextBox";
            paymentStatusTextBox.PlaceholderText = "Enter Payment Status";
            paymentStatusTextBox.ReadOnly = true;
            paymentStatusTextBox.Size = new Size(364, 21);
            paymentStatusTextBox.TabIndex = 0;
            paymentStatusTextBox.TextChanged += paymentStatusTextBox_TextChanged;
            // 
            // errorPaymentMethod
            // 
            errorPaymentMethod.Anchor = AnchorStyles.None;
            errorPaymentMethod.AutoSize = true;
            errorPaymentMethod.Font = new Font("Inter", 7.8F);
            errorPaymentMethod.ForeColor = Color.Red;
            errorPaymentMethod.Location = new Point(33, 631);
            errorPaymentMethod.Name = "errorPaymentMethod";
            errorPaymentMethod.Size = new Size(110, 16);
            errorPaymentMethod.TabIndex = 94;
            errorPaymentMethod.Text = "PaymentMethod";
            errorPaymentMethod.Visible = false;
            // 
            // errorDeparture
            // 
            errorDeparture.Anchor = AnchorStyles.None;
            errorDeparture.AutoSize = true;
            errorDeparture.Font = new Font("Inter", 7.8F);
            errorDeparture.ForeColor = Color.Red;
            errorDeparture.Location = new Point(30, 518);
            errorDeparture.Name = "errorDeparture";
            errorDeparture.Size = new Size(70, 16);
            errorDeparture.TabIndex = 93;
            errorDeparture.Text = "Departure";
            errorDeparture.Visible = false;
            // 
            // errorSeat
            // 
            errorSeat.Anchor = AnchorStyles.None;
            errorSeat.AutoSize = true;
            errorSeat.Font = new Font("Inter", 7.8F);
            errorSeat.ForeColor = Color.Red;
            errorSeat.Location = new Point(30, 400);
            errorSeat.Name = "errorSeat";
            errorSeat.Size = new Size(53, 16);
            errorSeat.TabIndex = 92;
            errorSeat.Text = "SeatNo";
            errorSeat.Visible = false;
            // 
            // errorDestination
            // 
            errorDestination.Anchor = AnchorStyles.None;
            errorDestination.AutoSize = true;
            errorDestination.Font = new Font("Inter", 7.8F);
            errorDestination.ForeColor = Color.Red;
            errorDestination.Location = new Point(26, 974);
            errorDestination.Name = "errorDestination";
            errorDestination.Size = new Size(96, 16);
            errorDestination.TabIndex = 91;
            errorDestination.Text = "picDestination";
            errorDestination.Visible = false;
            // 
            // errorName
            // 
            errorName.Anchor = AnchorStyles.None;
            errorName.AutoSize = true;
            errorName.Font = new Font("Inter", 7.8F);
            errorName.ForeColor = Color.Red;
            errorName.Location = new Point(30, 171);
            errorName.Name = "errorName";
            errorName.Size = new Size(65, 16);
            errorName.TabIndex = 90;
            errorName.Text = "FullName";
            errorName.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label1.Location = new Point(27, 84);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label2.Location = new Point(28, 887);
            label2.Name = "label2";
            label2.Size = new Size(180, 21);
            label2.TabIndex = 2;
            label2.Text = "Pick Up Destination";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label3.Location = new Point(28, 315);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 3;
            label3.Text = "Seat Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label4.Location = new Point(27, 431);
            label4.Name = "label4";
            label4.Size = new Size(147, 21);
            label4.TabIndex = 4;
            label4.Text = "Departure Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label5.Location = new Point(28, 545);
            label5.Name = "label5";
            label5.Size = new Size(158, 21);
            label5.TabIndex = 5;
            label5.Text = "Payment Method";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.FromArgb(249, 249, 249);
            panel7.Controls.Add(dateTimePickerDepartureTime);
            panel7.Location = new Point(28, 462);
            panel7.Name = "panel7";
            panel7.Size = new Size(382, 52);
            panel7.TabIndex = 68;
            // 
            // dateTimePickerDepartureTime
            // 
            dateTimePickerDepartureTime.BorderColor = Color.PaleVioletRed;
            dateTimePickerDepartureTime.BorderSize = 0;
            dateTimePickerDepartureTime.CustomFormat = "hh:mm tt";
            dateTimePickerDepartureTime.Font = new Font("Segoe UI", 10F);
            dateTimePickerDepartureTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerDepartureTime.Location = new Point(10, 9);
            dateTimePickerDepartureTime.MinimumSize = new Size(0, 35);
            dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
            dateTimePickerDepartureTime.ShowUpDown = true;
            dateTimePickerDepartureTime.Size = new Size(365, 35);
            dateTimePickerDepartureTime.SkinColor = Color.FromArgb(249, 249, 249);
            dateTimePickerDepartureTime.TabIndex = 0;
            dateTimePickerDepartureTime.TextColor = Color.Black;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.FromArgb(0, 214, 220);
            Savebutton.FlatStyle = FlatStyle.Flat;
            Savebutton.Font = new Font("Inter", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(28, 1048);
            Savebutton.Margin = new Padding(3, 2, 3, 2);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(799, 52);
            Savebutton.TabIndex = 67;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.Font = new Font("Inter", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Heading.Location = new Point(309, 17);
            Heading.Name = "Heading";
            Heading.Size = new Size(195, 34);
            Heading.TabIndex = 66;
            Heading.Text = "Edit Booking ";
            Heading.Visible = false;
            // 
            // closeButton
            // 
            closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.Location = new Point(26, 17);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(45, 45);
            closeButton.TabIndex = 47;
            closeButton.Click += closeButton_Click;
            // 
            // bookingStatusCheckBox
            // 
            bookingStatusCheckBox.AutoSize = true;
            bookingStatusCheckBox.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookingStatusCheckBox.Location = new Point(28, 1008);
            bookingStatusCheckBox.Name = "bookingStatusCheckBox";
            bookingStatusCheckBox.Size = new Size(164, 25);
            bookingStatusCheckBox.TabIndex = 45;
            bookingStatusCheckBox.Text = "Booking Status";
            bookingStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(249, 249, 249);
            panel2.Controls.Add(comboBoxPickup);
            panel2.Location = new Point(28, 919);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 52);
            panel2.TabIndex = 44;
            // 
            // comboBoxPickup
            // 
            comboBoxPickup.BackColor = Color.FromArgb(249, 249, 249);
            comboBoxPickup.FlatStyle = FlatStyle.Flat;
            comboBoxPickup.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPickup.FormattingEnabled = true;
            comboBoxPickup.Location = new Point(5, 11);
            comboBoxPickup.Name = "comboBoxPickup";
            comboBoxPickup.Size = new Size(369, 29);
            comboBoxPickup.TabIndex = 1;
            comboBoxPickup.SelectedIndexChanged += comboBoxPickup_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(249, 249, 249);
            panel4.Controls.Add(seatNumberTextBox);
            panel4.Location = new Point(28, 345);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 52);
            panel4.TabIndex = 44;
            // 
            // seatNumberTextBox
            // 
            seatNumberTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            seatNumberTextBox.BackColor = Color.FromArgb(249, 249, 249);
            seatNumberTextBox.BorderStyle = BorderStyle.None;
            seatNumberTextBox.Cursor = Cursors.IBeam;
            seatNumberTextBox.Font = new Font("Inter", 10F);
            seatNumberTextBox.Location = new Point(11, 17);
            seatNumberTextBox.Name = "seatNumberTextBox";
            seatNumberTextBox.PlaceholderText = "Enter Seat Number";
            seatNumberTextBox.ReadOnly = true;
            seatNumberTextBox.Size = new Size(257, 21);
            seatNumberTextBox.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(249, 249, 249);
            panel6.Controls.Add(paymentMethodTextBox);
            panel6.Location = new Point(28, 576);
            panel6.Name = "panel6";
            panel6.Size = new Size(382, 52);
            panel6.TabIndex = 44;
            // 
            // paymentMethodTextBox
            // 
            paymentMethodTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paymentMethodTextBox.BackColor = Color.FromArgb(249, 249, 249);
            paymentMethodTextBox.BorderStyle = BorderStyle.None;
            paymentMethodTextBox.Cursor = Cursors.IBeam;
            paymentMethodTextBox.Font = new Font("Inter", 10F);
            paymentMethodTextBox.Location = new Point(13, 16);
            paymentMethodTextBox.Name = "paymentMethodTextBox";
            paymentMethodTextBox.PlaceholderText = "Enter Payment Method";
            paymentMethodTextBox.ReadOnly = true;
            paymentMethodTextBox.Size = new Size(361, 21);
            paymentMethodTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(249, 249, 249);
            panel3.Controls.Add(bookingNameTextBox);
            panel3.Location = new Point(28, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 52);
            panel3.TabIndex = 43;
            // 
            // bookingNameTextBox
            // 
            bookingNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bookingNameTextBox.BackColor = Color.FromArgb(249, 249, 249);
            bookingNameTextBox.BorderStyle = BorderStyle.None;
            bookingNameTextBox.Cursor = Cursors.IBeam;
            bookingNameTextBox.Font = new Font("Inter", 10F);
            bookingNameTextBox.Location = new Point(13, 16);
            bookingNameTextBox.Name = "bookingNameTextBox";
            bookingNameTextBox.PlaceholderText = "Enter Name";
            bookingNameTextBox.Size = new Size(363, 21);
            bookingNameTextBox.TabIndex = 0;
            bookingNameTextBox.TextChanged += bookingNameTextBox_TextChanged;
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
            tickButtonPictureBox.Size = new Size(848, 1124);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 110;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // EditBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(244, 255, 255);
            ClientSize = new Size(906, 862);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditBooking";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditBooking";
            TopMost = true;
            Load += EditBooking_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel20.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox BusModeltextBox;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel4;
        private TextBox textBox2;
        private Panel panel6;
        private TextBox paymentStatusTextBox;
        private CheckBox paymentStatus;
        private CheckBox bookingStatus;
        private Panel closeButton;
        private Label Heading;
        private Button Savebutton;
        private Panel panel7;
        private CustomControls.CustomTimePicker dateTimePickerArrivalTime;
        private CustomControls.CustomTimePicker dateTimePickerDepartureTime;
        private CheckBox paymentStatusCheckBox;
        private CheckBox bookingStatusCheckBox;
        private TextBox pickUpDestinationTextBox;
        private TextBox seatNumberTextBox;
        private TextBox paymentMethodTextBox;
        private TextBox bookingNameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label errorPaymentStatus;
        private Label errorBookingStatus;
        private Label errorPaymentMethod;
        private Label errorDeparture;
        private Label errorSeat;
        private Label errorDestination;
        private Label errorName;
        private Panel panel5;
        private Panel panel8;
        private Panel panel9;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox3;
        private Panel panel10;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel11;
        private Panel panel12;
        private Panel panel14;
        private TextBox textBox8;
        private Panel panel15;
        private TextBox textBox9;
        private Panel panel16;
        private TextBox textBox10;
        private Panel panel17;
        private TextBox textBox11;
        private Panel panel18;
        private TextBox textBox12;
        private Panel panel13;
        private TextBox textBox7;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label18;
        private Panel panel19;
        private TextBox numberOfGuestTextBox;
        private TextBox roomNumberTextBox;
        private TextBox totalNumberOfPersonTextBox;
        private TextBox totalAmountTextBox;
        private TextBox kidsUnder2YearsTextBox;
        private TextBox numberOfSeatsBookedTextBox;
        private Panel panel20;
        private TextBox passengerIdTextBox;
        private TextBox staffIdTextBox;
        private TextBox departureTimePicker;
        private TextBox destinationIdTextBox;
        private PictureBox tickButtonPictureBox;
        private TextBox destinationTextBox;
        private TextBox vehicleTextBox;
        private CustomControls.CustomTimePicker pickupTime;
        private CustomControls.CustomDateTimePicker bookingDatePicker;
        private TextBox pickDestinationTextBox;
        private Button nameChangeBtn;
        private Button seatChangeBtn;
        private Button button3;
        private Button button2;
        private Button PickUpDesBtn;
        private Button destinationBtn;
        private ComboBox comboBoxPickup;
        private ComboBox comboBoxDestination;
        private ComboBox comboBoxDropOff;
    }
}