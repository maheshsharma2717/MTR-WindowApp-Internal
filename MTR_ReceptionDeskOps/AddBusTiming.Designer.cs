namespace MTRDesktopApplication
{
    partial class AddBusTiming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBusTiming));
            panel2 = new Panel();
            label2 = new Label();
            labelBusRouteError = new Label();
            labelBusRoutes = new Label();
            panel9 = new Panel();
            listBoxBusStops = new ListBox();
            panel1 = new Panel();
            AddresspictureBox = new PictureBox();
            busRouteDropdown = new ComboBox();
            Heading = new Label();
            closeButton = new Panel();
            colorPikerTextBox = new Panel();
            labelSeatingPlanError = new Label();
            labelColorPicker = new Label();
            labelNoOFSeatsError = new Label();
            labelPlateNumberError = new Label();
            labelBusModalError = new Label();
            panel8 = new Panel();
            dateTimePickerDepartureTime = new CustomControls.CustomTimePicker();
            panel7 = new Panel();
            dateTimePickerArrivalTime = new CustomControls.CustomTimePicker();
            labelArrivalTime = new Label();
            labelDepartureTime = new Label();
            labelSeatingPlan = new Label();
            labelColor = new Label();
            panel6 = new Panel();
            textBoxSeatingPlan = new TextBox();
            colorPikertiming = new Button();
            label1 = new Label();
            panel5 = new Panel();
            seatsTextBox = new TextBox();
            panel4 = new Panel();
            comboBoxNumberPlate = new ComboBox();
            panel3 = new Panel();
            BusModeltextBox = new TextBox();
            Savebutton = new Button();
            labelBusmodel = new Label();
            labelPlateNumber = new Label();
            tickButtonPictureBox = new PictureBox();
            colorDialog = new ColorDialog();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddresspictureBox).BeginInit();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(237, 255, 255);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(labelBusRouteError);
            panel2.Controls.Add(labelBusRoutes);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(Heading);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(colorPikerTextBox);
            panel2.Controls.Add(labelSeatingPlanError);
            panel2.Controls.Add(labelColorPicker);
            panel2.Controls.Add(labelNoOFSeatsError);
            panel2.Controls.Add(labelPlateNumberError);
            panel2.Controls.Add(labelBusModalError);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(labelArrivalTime);
            panel2.Controls.Add(labelDepartureTime);
            panel2.Controls.Add(labelSeatingPlan);
            panel2.Controls.Add(labelColor);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(colorPikertiming);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(Savebutton);
            panel2.Controls.Add(labelBusmodel);
            panel2.Controls.Add(labelPlateNumber);
            panel2.Controls.Add(tickButtonPictureBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 906);
            panel2.TabIndex = 43;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 396);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 70;
            label2.Text = "Bus Stops List";
            // 
            // labelBusRouteError
            // 
            labelBusRouteError.Anchor = AnchorStyles.None;
            labelBusRouteError.AutoSize = true;
            labelBusRouteError.Font = new Font("Inter", 7.8F);
            labelBusRouteError.ForeColor = Color.Red;
            labelBusRouteError.Location = new Point(24, 376);
            labelBusRouteError.Name = "labelBusRouteError";
            labelBusRouteError.Size = new Size(67, 16);
            labelBusRouteError.TabIndex = 69;
            labelBusRouteError.Text = "BusRoute";
            labelBusRouteError.Visible = false;
            // 
            // labelBusRoutes
            // 
            labelBusRoutes.Anchor = AnchorStyles.None;
            labelBusRoutes.AutoSize = true;
            labelBusRoutes.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBusRoutes.Location = new Point(24, 295);
            labelBusRoutes.Name = "labelBusRoutes";
            labelBusRoutes.Size = new Size(109, 21);
            labelBusRoutes.TabIndex = 68;
            labelBusRoutes.Text = "Bus Routes";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.AutoScroll = true;
            panel9.BackColor = Color.FromArgb(249, 249, 249);
            panel9.Controls.Add(listBoxBusStops);
            panel9.Location = new Point(23, 421);
            panel9.Name = "panel9";
            panel9.Size = new Size(609, 70);
            panel9.TabIndex = 67;
            // 
            // listBoxBusStops
            // 
            listBoxBusStops.BackColor = Color.FromArgb(249, 249, 249);
            listBoxBusStops.BorderStyle = BorderStyle.None;
            listBoxBusStops.Dock = DockStyle.Fill;
            listBoxBusStops.FormattingEnabled = true;
            listBoxBusStops.HorizontalScrollbar = true;
            listBoxBusStops.ItemHeight = 18;
            listBoxBusStops.Location = new Point(0, 0);
            listBoxBusStops.Name = "listBoxBusStops";
            listBoxBusStops.Size = new Size(609, 70);
            listBoxBusStops.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(249, 249, 249);
            panel1.Controls.Add(AddresspictureBox);
            panel1.Controls.Add(busRouteDropdown);
            panel1.Location = new Point(24, 320);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 52);
            panel1.TabIndex = 66;
            // 
            // AddresspictureBox
            // 
            AddresspictureBox.Anchor = AnchorStyles.None;
            AddresspictureBox.Image = (Image)resources.GetObject("AddresspictureBox.Image");
            AddresspictureBox.Location = new Point(11, 11);
            AddresspictureBox.Margin = new Padding(3, 4, 3, 4);
            AddresspictureBox.Name = "AddresspictureBox";
            AddresspictureBox.Size = new Size(25, 29);
            AddresspictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AddresspictureBox.TabIndex = 40;
            AddresspictureBox.TabStop = false;
            // 
            // busRouteDropdown
            // 
            busRouteDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            busRouteDropdown.BackColor = Color.FromArgb(249, 249, 249);
            busRouteDropdown.DropDownHeight = 100;
            busRouteDropdown.FlatStyle = FlatStyle.Flat;
            busRouteDropdown.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            busRouteDropdown.FormattingEnabled = true;
            busRouteDropdown.IntegralHeight = false;
            busRouteDropdown.Location = new Point(48, 12);
            busRouteDropdown.Margin = new Padding(3, 4, 3, 4);
            busRouteDropdown.Name = "busRouteDropdown";
            busRouteDropdown.Size = new Size(553, 28);
            busRouteDropdown.TabIndex = 39;
            busRouteDropdown.SelectedIndexChanged += busRouteDropdown_SelectedIndexChanged;
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.Font = new Font("Inter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Heading.Location = new Point(141, 19);
            Heading.Name = "Heading";
            Heading.Size = new Size(190, 28);
            Heading.TabIndex = 65;
            Heading.Text = "Edit Bus Timing ";
            Heading.Visible = false;
            // 
            // closeButton
            // 
            closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.Location = new Point(23, 8);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(45, 45);
            closeButton.TabIndex = 0;
            closeButton.Click += closeButton_Click;
            // 
            // colorPikerTextBox
            // 
            colorPikerTextBox.Anchor = AnchorStyles.None;
            colorPikerTextBox.Location = new Point(33, 539);
            colorPikerTextBox.Name = "colorPikerTextBox";
            colorPikerTextBox.Size = new Size(24, 24);
            colorPikerTextBox.TabIndex = 64;
            // 
            // labelSeatingPlanError
            // 
            labelSeatingPlanError.Anchor = AnchorStyles.None;
            labelSeatingPlanError.AutoSize = true;
            labelSeatingPlanError.Font = new Font("Inter", 7.8F);
            labelSeatingPlanError.ForeColor = Color.Red;
            labelSeatingPlanError.Location = new Point(23, 690);
            labelSeatingPlanError.Name = "labelSeatingPlanError";
            labelSeatingPlanError.Size = new Size(77, 16);
            labelSeatingPlanError.TabIndex = 63;
            labelSeatingPlanError.Text = "Sitting Plan";
            labelSeatingPlanError.Visible = false;
            // 
            // labelColorPicker
            // 
            labelColorPicker.Anchor = AnchorStyles.None;
            labelColorPicker.AutoSize = true;
            labelColorPicker.Font = new Font("Inter", 7.8F);
            labelColorPicker.ForeColor = Color.Red;
            labelColorPicker.Location = new Point(29, 579);
            labelColorPicker.Name = "labelColorPicker";
            labelColorPicker.Size = new Size(82, 16);
            labelColorPicker.TabIndex = 62;
            labelColorPicker.Text = "Color Picker";
            labelColorPicker.Visible = false;
            // 
            // labelNoOFSeatsError
            // 
            labelNoOFSeatsError.Anchor = AnchorStyles.None;
            labelNoOFSeatsError.AutoSize = true;
            labelNoOFSeatsError.Font = new Font("Inter", 7.8F);
            labelNoOFSeatsError.ForeColor = Color.Red;
            labelNoOFSeatsError.Location = new Point(328, 579);
            labelNoOFSeatsError.Name = "labelNoOFSeatsError";
            labelNoOFSeatsError.Size = new Size(83, 16);
            labelNoOFSeatsError.TabIndex = 61;
            labelNoOFSeatsError.Text = "No Of Seats";
            labelNoOFSeatsError.Visible = false;
            // 
            // labelPlateNumberError
            // 
            labelPlateNumberError.Anchor = AnchorStyles.None;
            labelPlateNumberError.AutoSize = true;
            labelPlateNumberError.Font = new Font("Inter", 7.8F);
            labelPlateNumberError.ForeColor = Color.Red;
            labelPlateNumberError.Location = new Point(24, 152);
            labelPlateNumberError.Name = "labelPlateNumberError";
            labelPlateNumberError.Size = new Size(92, 16);
            labelPlateNumberError.TabIndex = 60;
            labelPlateNumberError.Text = "Plate Number";
            labelPlateNumberError.Visible = false;
            // 
            // labelBusModalError
            // 
            labelBusModalError.Anchor = AnchorStyles.None;
            labelBusModalError.AutoSize = true;
            labelBusModalError.Font = new Font("Inter", 7.8F);
            labelBusModalError.ForeColor = Color.Red;
            labelBusModalError.Location = new Point(23, 265);
            labelBusModalError.Name = "labelBusModalError";
            labelBusModalError.Size = new Size(73, 16);
            labelBusModalError.TabIndex = 59;
            labelBusModalError.Text = "Bus Model";
            labelBusModalError.Visible = false;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = Color.FromArgb(249, 249, 249);
            panel8.Controls.Add(dateTimePickerDepartureTime);
            panel8.Location = new Point(23, 760);
            panel8.Name = "panel8";
            panel8.Size = new Size(277, 52);
            panel8.TabIndex = 56;
            // 
            // dateTimePickerDepartureTime
            // 
            dateTimePickerDepartureTime.BorderColor = Color.PaleVioletRed;
            dateTimePickerDepartureTime.BorderSize = 0;
            dateTimePickerDepartureTime.CustomFormat = "hh:mm tt";
            dateTimePickerDepartureTime.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDepartureTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerDepartureTime.Location = new Point(6, 8);
            dateTimePickerDepartureTime.MinimumSize = new Size(0, 35);
            dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
            dateTimePickerDepartureTime.ShowUpDown = true;
            dateTimePickerDepartureTime.Size = new Size(268, 35);
            dateTimePickerDepartureTime.SkinColor = Color.FromArgb(249, 249, 249);
            dateTimePickerDepartureTime.TabIndex = 1;
            dateTimePickerDepartureTime.TextColor = Color.Black;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.FromArgb(249, 249, 249);
            panel7.Controls.Add(dateTimePickerArrivalTime);
            panel7.Location = new Point(327, 760);
            panel7.Name = "panel7";
            panel7.Size = new Size(308, 52);
            panel7.TabIndex = 55;
            // 
            // dateTimePickerArrivalTime
            // 
            dateTimePickerArrivalTime.BorderColor = Color.PaleVioletRed;
            dateTimePickerArrivalTime.BorderSize = 0;
            dateTimePickerArrivalTime.CustomFormat = "hh:mm tt";
            dateTimePickerArrivalTime.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerArrivalTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerArrivalTime.Location = new Point(11, 8);
            dateTimePickerArrivalTime.MinimumSize = new Size(0, 35);
            dateTimePickerArrivalTime.Name = "dateTimePickerArrivalTime";
            dateTimePickerArrivalTime.ShowUpDown = true;
            dateTimePickerArrivalTime.Size = new Size(294, 35);
            dateTimePickerArrivalTime.SkinColor = Color.FromArgb(249, 249, 249);
            dateTimePickerArrivalTime.TabIndex = 0;
            dateTimePickerArrivalTime.TextColor = Color.Black;
            // 
            // labelArrivalTime
            // 
            labelArrivalTime.Anchor = AnchorStyles.None;
            labelArrivalTime.AutoSize = true;
            labelArrivalTime.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            labelArrivalTime.Location = new Point(331, 728);
            labelArrivalTime.Name = "labelArrivalTime";
            labelArrivalTime.Size = new Size(115, 21);
            labelArrivalTime.TabIndex = 54;
            labelArrivalTime.Text = "Arrival Time";
            // 
            // labelDepartureTime
            // 
            labelDepartureTime.Anchor = AnchorStyles.None;
            labelDepartureTime.AutoSize = true;
            labelDepartureTime.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            labelDepartureTime.Location = new Point(24, 728);
            labelDepartureTime.Name = "labelDepartureTime";
            labelDepartureTime.Size = new Size(147, 21);
            labelDepartureTime.TabIndex = 53;
            labelDepartureTime.Text = "Departure Time";
            // 
            // labelSeatingPlan
            // 
            labelSeatingPlan.Anchor = AnchorStyles.None;
            labelSeatingPlan.AutoSize = true;
            labelSeatingPlan.BackColor = Color.Transparent;
            labelSeatingPlan.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            labelSeatingPlan.Location = new Point(23, 611);
            labelSeatingPlan.Name = "labelSeatingPlan";
            labelSeatingPlan.Size = new Size(110, 21);
            labelSeatingPlan.TabIndex = 52;
            labelSeatingPlan.Text = "Sitting Plan";
            // 
            // labelColor
            // 
            labelColor.Anchor = AnchorStyles.None;
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            labelColor.Location = new Point(23, 494);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(57, 21);
            labelColor.TabIndex = 51;
            labelColor.Text = "Color";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(249, 249, 249);
            panel6.Controls.Add(textBoxSeatingPlan);
            panel6.Location = new Point(23, 635);
            panel6.Name = "panel6";
            panel6.Size = new Size(609, 52);
            panel6.TabIndex = 48;
            // 
            // textBoxSeatingPlan
            // 
            textBoxSeatingPlan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSeatingPlan.BackColor = Color.FromArgb(249, 249, 249);
            textBoxSeatingPlan.BorderStyle = BorderStyle.None;
            textBoxSeatingPlan.Cursor = Cursors.IBeam;
            textBoxSeatingPlan.Font = new Font("Inter", 10F);
            textBoxSeatingPlan.Location = new Point(8, 16);
            textBoxSeatingPlan.Name = "textBoxSeatingPlan";
            textBoxSeatingPlan.PlaceholderText = "Enter Sitting Plan";
            textBoxSeatingPlan.ReadOnly = true;
            textBoxSeatingPlan.Size = new Size(595, 21);
            textBoxSeatingPlan.TabIndex = 2;
            // 
            // colorPikertiming
            // 
            colorPikertiming.Anchor = AnchorStyles.None;
            colorPikertiming.BackColor = Color.FromArgb(249, 249, 249);
            colorPikertiming.Enabled = false;
            colorPikertiming.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            colorPikertiming.ForeColor = Color.Black;
            colorPikertiming.Location = new Point(23, 524);
            colorPikertiming.Name = "colorPikertiming";
            colorPikertiming.Size = new Size(277, 52);
            colorPikertiming.TabIndex = 46;
            colorPikertiming.Text = "Pick  Color";
            colorPikertiming.UseVisualStyleBackColor = false;
            colorPikertiming.Click += colorPikertiming_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label1.Location = new Point(331, 494);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 45;
            label1.Text = "Number Of Seats";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(249, 249, 249);
            panel5.Controls.Add(seatsTextBox);
            panel5.Location = new Point(328, 523);
            panel5.Name = "panel5";
            panel5.Size = new Size(304, 52);
            panel5.TabIndex = 44;
            // 
            // seatsTextBox
            // 
            seatsTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            seatsTextBox.BackColor = Color.FromArgb(249, 249, 249);
            seatsTextBox.BorderStyle = BorderStyle.None;
            seatsTextBox.Cursor = Cursors.IBeam;
            seatsTextBox.Font = new Font("Inter", 9F);
            seatsTextBox.Location = new Point(8, 17);
            seatsTextBox.Name = "seatsTextBox";
            seatsTextBox.PlaceholderText = "Enter Number of seats";
            seatsTextBox.ReadOnly = true;
            seatsTextBox.Size = new Size(290, 19);
            seatsTextBox.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(249, 249, 249);
            panel4.Controls.Add(comboBoxNumberPlate);
            panel4.Location = new Point(23, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(609, 52);
            panel4.TabIndex = 43;
            // 
            // comboBoxNumberPlate
            // 
            comboBoxNumberPlate.BackColor = Color.FromArgb(249, 249, 249);
            comboBoxNumberPlate.FlatStyle = FlatStyle.Flat;
            comboBoxNumberPlate.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxNumberPlate.FormattingEnabled = true;
            comboBoxNumberPlate.Location = new Point(12, 11);
            comboBoxNumberPlate.Name = "comboBoxNumberPlate";
            comboBoxNumberPlate.Size = new Size(590, 28);
            comboBoxNumberPlate.TabIndex = 66;
            comboBoxNumberPlate.SelectedIndexChanged += comboBoxNumberPlate_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(249, 249, 249);
            panel3.Controls.Add(BusModeltextBox);
            panel3.Location = new Point(23, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(609, 52);
            panel3.TabIndex = 42;
            // 
            // BusModeltextBox
            // 
            BusModeltextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BusModeltextBox.BackColor = Color.FromArgb(249, 249, 249);
            BusModeltextBox.BorderStyle = BorderStyle.None;
            BusModeltextBox.Cursor = Cursors.IBeam;
            BusModeltextBox.Font = new Font("Inter", 10F);
            BusModeltextBox.Location = new Point(10, 16);
            BusModeltextBox.Name = "BusModeltextBox";
            BusModeltextBox.PlaceholderText = "Enter bus model";
            BusModeltextBox.ReadOnly = true;
            BusModeltextBox.Size = new Size(592, 21);
            BusModeltextBox.TabIndex = 0;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.FromArgb(0, 214, 220);
            Savebutton.FlatStyle = FlatStyle.Flat;
            Savebutton.Font = new Font("Inter", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(23, 836);
            Savebutton.Margin = new Padding(3, 2, 3, 2);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(612, 52);
            Savebutton.TabIndex = 35;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // labelBusmodel
            // 
            labelBusmodel.Anchor = AnchorStyles.None;
            labelBusmodel.AutoSize = true;
            labelBusmodel.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            labelBusmodel.Location = new Point(24, 182);
            labelBusmodel.Name = "labelBusmodel";
            labelBusmodel.Size = new Size(101, 21);
            labelBusmodel.TabIndex = 36;
            labelBusmodel.Text = "Bus Model";
            // 
            // labelPlateNumber
            // 
            labelPlateNumber.Anchor = AnchorStyles.None;
            labelPlateNumber.AutoSize = true;
            labelPlateNumber.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            labelPlateNumber.Location = new Point(23, 68);
            labelPlateNumber.Name = "labelPlateNumber";
            labelPlateNumber.Size = new Size(128, 21);
            labelPlateNumber.TabIndex = 37;
            labelPlateNumber.Text = "Number Plate";
            // 
            // tickButtonPictureBox
            // 
            tickButtonPictureBox.BackColor = Color.Transparent;
            tickButtonPictureBox.BackgroundImageLayout = ImageLayout.Center;
            tickButtonPictureBox.Dock = DockStyle.Fill;
            tickButtonPictureBox.Image = (Image)resources.GetObject("tickButtonPictureBox.Image");
            tickButtonPictureBox.Location = new Point(0, 0);
            tickButtonPictureBox.Name = "tickButtonPictureBox";
            tickButtonPictureBox.Size = new Size(647, 906);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 58;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // AddBusTiming
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 255, 255);
            ClientSize = new Size(647, 906);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBusTiming";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBusTiming";
            TopMost = true;
            Load += AddBusTiming_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AddresspictureBox).EndInit();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel closeButton;
        private Button Savebutton;
        private Label labelPlateNumber;
        private Label labelBusmodal;
        private PictureBox pictureBox1;
        private Label busTimingBreadcrumb;
        private Label Home;
        private Panel panel2;
        private Panel panel3;
        private TextBox BusModeltextBox;
        private Panel panel4;
        private TextBox plateNoTextBox;
        private Label label1;
        private Panel panel5;
        private TextBox seatsTextBox;
        private Button colorPiker;
        private Panel panel6;
        private ComboBox seatingPlanDropdown;
        private Label label5;
        private Label label4;
        private Label labelSeatingPlan;
        private Label labelColor;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Panel panel7;
        private Panel panel8;
        private Label labelArrivalTime;
        private Label labelDepartureTime;
        private ComboBox seatingPlanDropdowntiming;
        private Button colorPikertiming;
        private ColorDialog colorDialog;
        private PictureBox tickButtonPictureBox;
        private Label labelBusModalError;
        private Label labelPlateNumberError;
        private Label labelNoOFSeatsError;
        private Label labelColorPicker;
        private Label labelSeatingPlanError;
        private Panel colorPikerTextBox;
        private Label labelBusmodel;
        private TextBox textBox1;
        private TextBox textBoxSeatingPlan;
        private Label Heading;
        private ComboBox comboBoxNumberPlate;
        private CustomControls.CustomTimePicker dateTimePickerDepartureTime;
        private CustomControls.CustomTimePicker dateTimePickerArrivalTime;
        private Panel panel1;
        private PictureBox AddresspictureBox;
        private ComboBox busRouteDropdown;
        private Panel panel9;
        private ComboBox busStopDropdown;
        private ListBox listBoxBusStops;
        private Label labelBusRoutes;
        private Label labelBusRouteError;
        private Label label2;
    }
}