namespace MTRDesktopApplication
{
    partial class AddHotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHotelForm));
            panel2 = new Panel();
            AddressSuggestionsListBox = new ListBox();
            labelPlateNumberError = new Label();
            panel1 = new Panel();
            comboBoxNumberPlate = new ComboBox();
            labelPlateNumber = new Label();
            AddressFromMap = new Button();
            changeHotelId = new Button();
            Heading = new Label();
            CloseBtn = new Panel();
            labelHotelPictureError = new Label();
            labelHotelPhoneError = new Label();
            labelHotelAddressError = new Label();
            labelHotelEmailError = new Label();
            labelHotelNameError = new Label();
            labelHotelNumberError = new Label();
            panel7 = new Panel();
            PhonetextBox = new MaskedTextBox();
            pictureBoxCountry = new PictureBox();
            comboBoxCountry = new ComboBox();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            AddresstextBox = new TextBox();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            EmailtextBox = new TextBox();
            panel4 = new Panel();
            HotelnametextBox = new TextBox();
            panel3 = new Panel();
            HotelnumbertextBox = new TextBox();
            hotelpictureBox = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            Savebutton = new Button();
            UploadBtn = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            tickButtonPictureBox = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCountry).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hotelpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(244, 255, 255);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(AddressSuggestionsListBox);
            panel2.Controls.Add(labelPlateNumberError);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(labelPlateNumber);
            panel2.Controls.Add(AddressFromMap);
            panel2.Controls.Add(changeHotelId);
            panel2.Controls.Add(Heading);
            panel2.Controls.Add(CloseBtn);
            panel2.Controls.Add(labelHotelPictureError);
            panel2.Controls.Add(labelHotelPhoneError);
            panel2.Controls.Add(labelHotelAddressError);
            panel2.Controls.Add(labelHotelEmailError);
            panel2.Controls.Add(labelHotelNameError);
            panel2.Controls.Add(labelHotelNumberError);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(hotelpictureBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Savebutton);
            panel2.Controls.Add(UploadBtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 1057);
            panel2.TabIndex = 0;
            // 
            // AddressSuggestionsListBox
            // 
            AddressSuggestionsListBox.Anchor = AnchorStyles.None;
            AddressSuggestionsListBox.BackColor = Color.FromArgb(249, 249, 249);
            AddressSuggestionsListBox.FormattingEnabled = true;
            AddressSuggestionsListBox.HorizontalScrollbar = true;
            AddressSuggestionsListBox.ItemHeight = 19;
            AddressSuggestionsListBox.Location = new Point(65, 693);
            AddressSuggestionsListBox.Name = "AddressSuggestionsListBox";
            AddressSuggestionsListBox.Size = new Size(472, 99);
            AddressSuggestionsListBox.TabIndex = 64;
            AddressSuggestionsListBox.Visible = false;
            AddressSuggestionsListBox.Click += AddressSuggestionsListBox_Click;
            AddressSuggestionsListBox.SelectedIndexChanged += AddressSuggestionsListBox_SelectedIndexChanged;
            // 
            // labelPlateNumberError
            // 
            labelPlateNumberError.Anchor = AnchorStyles.None;
            labelPlateNumberError.AutoSize = true;
            labelPlateNumberError.Font = new Font("Inter", 7.8F);
            labelPlateNumberError.ForeColor = Color.Red;
            labelPlateNumberError.Location = new Point(62, 794);
            labelPlateNumberError.Name = "labelPlateNumberError";
            labelPlateNumberError.Size = new Size(92, 16);
            labelPlateNumberError.TabIndex = 63;
            labelPlateNumberError.Text = "Plate Number";
            labelPlateNumberError.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(249, 249, 249);
            panel1.Controls.Add(comboBoxNumberPlate);
            panel1.Location = new Point(59, 737);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 52);
            panel1.TabIndex = 62;
            panel1.Visible = false;
            // 
            // comboBoxNumberPlate
            // 
            comboBoxNumberPlate.BackColor = Color.FromArgb(249, 249, 249);
            comboBoxNumberPlate.FlatStyle = FlatStyle.Flat;
            comboBoxNumberPlate.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxNumberPlate.FormattingEnabled = true;
            comboBoxNumberPlate.Location = new Point(12, 11);
            comboBoxNumberPlate.Name = "comboBoxNumberPlate";
            comboBoxNumberPlate.Size = new Size(460, 28);
            comboBoxNumberPlate.TabIndex = 66;
            // 
            // labelPlateNumber
            // 
            labelPlateNumber.Anchor = AnchorStyles.None;
            labelPlateNumber.AutoSize = true;
            labelPlateNumber.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            labelPlateNumber.Location = new Point(60, 709);
            labelPlateNumber.Name = "labelPlateNumber";
            labelPlateNumber.Size = new Size(128, 21);
            labelPlateNumber.TabIndex = 61;
            labelPlateNumber.Text = "Number Plate";
            labelPlateNumber.Visible = false;
            // 
            // AddressFromMap
            // 
            AddressFromMap.BackColor = Color.ForestGreen;
            AddressFromMap.ForeColor = Color.White;
            AddressFromMap.Location = new Point(406, 576);
            AddressFromMap.Name = "AddressFromMap";
            AddressFromMap.Size = new Size(130, 52);
            AddressFromMap.TabIndex = 58;
            AddressFromMap.Text = "From Map";
            AddressFromMap.UseVisualStyleBackColor = false;
            AddressFromMap.Click += AddressFromMap_Click;
            // 
            // changeHotelId
            // 
            changeHotelId.BackColor = Color.ForestGreen;
            changeHotelId.ForeColor = Color.White;
            changeHotelId.Location = new Point(401, 129);
            changeHotelId.Name = "changeHotelId";
            changeHotelId.Size = new Size(130, 52);
            changeHotelId.TabIndex = 57;
            changeHotelId.Text = "Select Id";
            changeHotelId.UseVisualStyleBackColor = false;
            changeHotelId.Click += changeHotelId_Click;
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.Font = new Font("Inter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Heading.Location = new Point(143, 30);
            Heading.Name = "Heading";
            Heading.Size = new Size(214, 28);
            Heading.TabIndex = 56;
            Heading.Text = "Edit  Hotel  Details";
            Heading.Visible = false;
            // 
            // CloseBtn
            // 
            CloseBtn.BackgroundImage = (Image)resources.GetObject("CloseBtn.BackgroundImage");
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Location = new Point(38, 24);
            CloseBtn.Margin = new Padding(3, 4, 3, 4);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(45, 45);
            CloseBtn.TabIndex = 55;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // labelHotelPictureError
            // 
            labelHotelPictureError.Anchor = AnchorStyles.None;
            labelHotelPictureError.AutoSize = true;
            labelHotelPictureError.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHotelPictureError.ForeColor = Color.Red;
            labelHotelPictureError.Location = new Point(344, 897);
            labelHotelPictureError.Name = "labelHotelPictureError";
            labelHotelPictureError.Size = new Size(89, 16);
            labelHotelPictureError.TabIndex = 52;
            labelHotelPictureError.Text = "Hotel Picture";
            labelHotelPictureError.Visible = false;
            // 
            // labelHotelPhoneError
            // 
            labelHotelPhoneError.Anchor = AnchorStyles.None;
            labelHotelPhoneError.AutoSize = true;
            labelHotelPhoneError.Font = new Font("Inter", 7.8F);
            labelHotelPhoneError.ForeColor = Color.Red;
            labelHotelPhoneError.Location = new Point(67, 553);
            labelHotelPhoneError.Name = "labelHotelPhoneError";
            labelHotelPhoneError.Size = new Size(89, 16);
            labelHotelPhoneError.TabIndex = 51;
            labelHotelPhoneError.Text = "Hotel  phone";
            labelHotelPhoneError.Visible = false;
            // 
            // labelHotelAddressError
            // 
            labelHotelAddressError.Anchor = AnchorStyles.None;
            labelHotelAddressError.AutoSize = true;
            labelHotelAddressError.Font = new Font("Inter", 7.8F);
            labelHotelAddressError.ForeColor = Color.Red;
            labelHotelAddressError.Location = new Point(67, 689);
            labelHotelAddressError.Name = "labelHotelAddressError";
            labelHotelAddressError.Size = new Size(101, 16);
            labelHotelAddressError.TabIndex = 50;
            labelHotelAddressError.Text = "Hotel  Address";
            labelHotelAddressError.Visible = false;
            // 
            // labelHotelEmailError
            // 
            labelHotelEmailError.Anchor = AnchorStyles.None;
            labelHotelEmailError.AutoSize = true;
            labelHotelEmailError.Font = new Font("Inter", 7.8F);
            labelHotelEmailError.ForeColor = Color.Red;
            labelHotelEmailError.Location = new Point(66, 428);
            labelHotelEmailError.Name = "labelHotelEmailError";
            labelHotelEmailError.Size = new Size(77, 16);
            labelHotelEmailError.TabIndex = 11;
            labelHotelEmailError.Text = "Hotel Email";
            labelHotelEmailError.Visible = false;
            // 
            // labelHotelNameError
            // 
            labelHotelNameError.Anchor = AnchorStyles.None;
            labelHotelNameError.AutoSize = true;
            labelHotelNameError.Font = new Font("Inter", 7.8F);
            labelHotelNameError.ForeColor = Color.Red;
            labelHotelNameError.Location = new Point(71, 306);
            labelHotelNameError.Name = "labelHotelNameError";
            labelHotelNameError.Size = new Size(81, 16);
            labelHotelNameError.TabIndex = 48;
            labelHotelNameError.Text = "Hotel Name";
            labelHotelNameError.Visible = false;
            // 
            // labelHotelNumberError
            // 
            labelHotelNumberError.Anchor = AnchorStyles.None;
            labelHotelNumberError.AutoSize = true;
            labelHotelNumberError.Font = new Font("Inter", 7.8F);
            labelHotelNumberError.ForeColor = Color.Red;
            labelHotelNumberError.Location = new Point(69, 184);
            labelHotelNumberError.Name = "labelHotelNumberError";
            labelHotelNumberError.Size = new Size(95, 16);
            labelHotelNumberError.TabIndex = 47;
            labelHotelNumberError.Text = "Hotel Number";
            labelHotelNumberError.Visible = false;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.FromArgb(249, 249, 249);
            panel7.Controls.Add(PhonetextBox);
            panel7.Controls.Add(pictureBoxCountry);
            panel7.Controls.Add(comboBoxCountry);
            panel7.Font = new Font("Microsoft Sans Serif", 9.75F);
            panel7.Location = new Point(67, 497);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(469, 52);
            panel7.TabIndex = 4;
            // 
            // PhonetextBox
            // 
            PhonetextBox.BackColor = Color.FromArgb(249, 249, 249);
            PhonetextBox.BorderStyle = BorderStyle.None;
            PhonetextBox.Location = new Point(122, 17);
            PhonetextBox.Margin = new Padding(3, 4, 3, 4);
            PhonetextBox.Mask = "(999) 000-0000";
            PhonetextBox.Name = "PhonetextBox";
            PhonetextBox.Size = new Size(341, 19);
            PhonetextBox.TabIndex = 1;
            PhonetextBox.Click += PhonetextBox_Click;
            PhonetextBox.Enter += PhonetextBox_Enter;
            // 
            // pictureBoxCountry
            // 
            pictureBoxCountry.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxCountry.Image = Properties.Resources.UnitedStates;
            pictureBoxCountry.InitialImage = Properties.Resources.UnitedStates;
            pictureBoxCountry.Location = new Point(6, 10);
            pictureBoxCountry.Margin = new Padding(3, 4, 3, 4);
            pictureBoxCountry.Name = "pictureBoxCountry";
            pictureBoxCountry.Size = new Size(32, 32);
            pictureBoxCountry.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCountry.TabIndex = 57;
            pictureBoxCountry.TabStop = false;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.Anchor = AnchorStyles.None;
            comboBoxCountry.BackColor = Color.FromArgb(249, 249, 249);
            comboBoxCountry.FlatStyle = FlatStyle.Flat;
            comboBoxCountry.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCountry.ForeColor = Color.Gray;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(41, 13);
            comboBoxCountry.Margin = new Padding(3, 4, 3, 4);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(73, 28);
            comboBoxCountry.TabIndex = 1;
            comboBoxCountry.Text = "+1";
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged;
            comboBoxCountry.TextChanged += comboBoxCountry_TextChanged;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(249, 249, 249);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(AddresstextBox);
            panel6.Location = new Point(67, 635);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(469, 52);
            panel6.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Image = Properties.Resources.LocationIcon;
            pictureBox3.Location = new Point(17, 16);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 57;
            pictureBox3.TabStop = false;
            // 
            // AddresstextBox
            // 
            AddresstextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddresstextBox.BackColor = Color.FromArgb(249, 249, 249);
            AddresstextBox.BorderStyle = BorderStyle.None;
            AddresstextBox.Cursor = Cursors.IBeam;
            AddresstextBox.Font = new Font("Inter", 10F);
            AddresstextBox.Location = new Point(53, 16);
            AddresstextBox.Margin = new Padding(3, 4, 3, 4);
            AddresstextBox.Name = "AddresstextBox";
            AddresstextBox.PlaceholderText = "Enter Full Address";
            AddresstextBox.Size = new Size(409, 21);
            AddresstextBox.TabIndex = 0;
            AddresstextBox.TextChanged += AddresstextBox_TextChanged;
            AddresstextBox.Leave += AddresstextBox_Leave;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(249, 249, 249);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(EmailtextBox);
            panel5.Location = new Point(67, 372);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(469, 52);
            panel5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.mail;
            pictureBox2.Location = new Point(2, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EmailtextBox.BackColor = Color.FromArgb(249, 249, 249);
            EmailtextBox.BorderStyle = BorderStyle.None;
            EmailtextBox.Cursor = Cursors.IBeam;
            EmailtextBox.Font = new Font("Inter", 10F);
            EmailtextBox.Location = new Point(53, 17);
            EmailtextBox.Margin = new Padding(3, 4, 3, 4);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.PlaceholderText = "Enter Email Address";
            EmailtextBox.Size = new Size(413, 21);
            EmailtextBox.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(249, 249, 249);
            panel4.Controls.Add(HotelnametextBox);
            panel4.Location = new Point(67, 250);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(469, 52);
            panel4.TabIndex = 2;
            // 
            // HotelnametextBox
            // 
            HotelnametextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            HotelnametextBox.BackColor = Color.FromArgb(249, 249, 249);
            HotelnametextBox.BorderStyle = BorderStyle.None;
            HotelnametextBox.Cursor = Cursors.IBeam;
            HotelnametextBox.Font = new Font("Inter", 10F);
            HotelnametextBox.Location = new Point(9, 16);
            HotelnametextBox.Margin = new Padding(3, 4, 3, 4);
            HotelnametextBox.Name = "HotelnametextBox";
            HotelnametextBox.PlaceholderText = "Enter Hotel Name";
            HotelnametextBox.Size = new Size(455, 21);
            HotelnametextBox.TabIndex = 0;
            HotelnametextBox.TextChanged += HotelnametextBox_TextChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(249, 249, 249);
            panel3.Controls.Add(HotelnumbertextBox);
            panel3.Location = new Point(67, 129);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 52);
            panel3.TabIndex = 2;
            // 
            // HotelnumbertextBox
            // 
            HotelnumbertextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            HotelnumbertextBox.BackColor = Color.FromArgb(249, 249, 249);
            HotelnumbertextBox.BorderStyle = BorderStyle.None;
            HotelnumbertextBox.Cursor = Cursors.IBeam;
            HotelnumbertextBox.Font = new Font("Inter", 10F);
            HotelnumbertextBox.Location = new Point(9, 16);
            HotelnumbertextBox.Margin = new Padding(3, 4, 3, 4);
            HotelnumbertextBox.Name = "HotelnumbertextBox";
            HotelnumbertextBox.PlaceholderText = " Hotel Id";
            HotelnumbertextBox.ReadOnly = true;
            HotelnumbertextBox.Size = new Size(260, 21);
            HotelnumbertextBox.TabIndex = 0;
            HotelnumbertextBox.Click += HotelnumbertextBox_Click;
            // 
            // hotelpictureBox
            // 
            hotelpictureBox.Anchor = AnchorStyles.None;
            hotelpictureBox.BackColor = Color.FromArgb(249, 249, 249);
            hotelpictureBox.BackgroundImage = Properties.Resources.EmptyImg;
            hotelpictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            hotelpictureBox.Location = new Point(344, 751);
            hotelpictureBox.Name = "hotelpictureBox";
            hotelpictureBox.Size = new Size(140, 140);
            hotelpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            hotelpictureBox.TabIndex = 19;
            hotelpictureBox.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label6.Location = new Point(67, 214);
            label6.Name = "label6";
            label6.Size = new Size(111, 21);
            label6.TabIndex = 16;
            label6.Text = "Hotel Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label1.Location = new Point(66, 98);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 4;
            label1.Text = "Hotel Id";
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.FromArgb(0, 214, 220);
            Savebutton.FlatStyle = FlatStyle.Flat;
            Savebutton.Font = new Font("Inter", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(64, 953);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(469, 52);
            Savebutton.TabIndex = 11;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // UploadBtn
            // 
            UploadBtn.Anchor = AnchorStyles.None;
            UploadBtn.BackColor = Color.FromArgb(255, 159, 180);
            UploadBtn.FlatStyle = FlatStyle.Flat;
            UploadBtn.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UploadBtn.ForeColor = Color.White;
            UploadBtn.Location = new Point(69, 797);
            UploadBtn.Name = "UploadBtn";
            UploadBtn.Size = new Size(130, 55);
            UploadBtn.TabIndex = 13;
            UploadBtn.Text = "Upload Image";
            UploadBtn.UseVisualStyleBackColor = false;
            UploadBtn.Click += UploadBtn_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 602);
            label5.Margin = new Padding(3, 1, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 10;
            label5.Text = "Address";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label3.Location = new Point(66, 338);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label4.Location = new Point(66, 464);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 9;
            label4.Text = "Phone Number";
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
            tickButtonPictureBox.Size = new Size(600, 1057);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 47;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // AddHotelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(237, 255, 255);
            ClientSize = new Size(610, 800);
            Controls.Add(panel2);
            Controls.Add(tickButtonPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(700, 800);
            Name = "AddHotelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddHotelForm";
            TopMost = true;
            Load += AddHotelForm_Load_1;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCountry).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hotelpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelHotelAddressError;
        private Panel panel2;
        private PictureBox hotelpictureBox;
        private Label label6;
        private Label label1;
        private Button Savebutton;
        private Button UploadBtn;
        private Label label5;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private TextBox HotelnametextBox;
        private Panel panel3;
        private TextBox HotelnumbertextBox;
        private Panel panel5;
        private TextBox EmailtextBox;
        private Panel panel7;
        private Panel panel6;
        private TextBox AddresstextBox;
        private PictureBox tickButtonPictureBox;
        private Label labelHotelNumberError;
        private Label labelHotelEmailError;
        private Label labelHotelNameError;
        private Label labelHotelPictureError;
        private Label labelHotelPhoneError;
        private Panel CloseBtn;
        private Label Heading;
        private ComboBox comboBox1;
        private PictureBox pictureBoxCountry;
        private ComboBox comboBoxCountry;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MaskedTextBox PhonetextBox;
        private PictureBox pictureBox3;
        private Button changeHotelId;
        private Button AddressFromMap;
        private Label labelPlateNumberError;
        private Panel panel1;
        private ComboBox comboBoxNumberPlate;
        private Label labelPlateNumber;
        private ListBox AddressSuggestionsListBox;
    }
}