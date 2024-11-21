namespace MTRDesktopApplication
{
    partial class StaffDetails
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDetails));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Home = new Label();
            staffListBreadcrumb = new Label();
            staffDetailBreadcrumb = new Label();
            panel1 = new Panel();
            AddStaffbutton = new Button();
            panelStaffDetails = new Panel();
            phoneVal = new TextBox();
            panelColorRed = new Panel();
            panelRoundColor = new Panel();
            pnlNameStatus = new Panel();
            activeStatus = new PictureBox();
            statusPending = new PictureBox();
            nameVal = new Label();
            passwordVal = new Label();
            emailVal = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            PhonepictureBox = new PictureBox();
            AddressVal = new Label();
            AddresspictureBox = new PictureBox();
            DeleteStaffDetail = new Button();
            EditStaffDetail = new Button();
            ProfileVal = new PictureBox();
            tickButtonPictureBox = new PictureBox();
            imageListStatus = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panelStaffDetails.SuspendLayout();
            pnlNameStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activeStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusPending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhonepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddresspictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfileVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 19);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(200, 19);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            Home.ForeColor = Color.FromArgb(37, 37, 37);
            Home.Location = new Point(5, 18);
            Home.Name = "Home";
            Home.Size = new Size(67, 24);
            Home.TabIndex = 16;
            Home.Text = "Home";
            Home.Click += Home_Click;
            // 
            // staffListBreadcrumb
            // 
            staffListBreadcrumb.AutoSize = true;
            staffListBreadcrumb.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            staffListBreadcrumb.ForeColor = Color.FromArgb(37, 37, 37);
            staffListBreadcrumb.Location = new Point(99, 20);
            staffListBreadcrumb.Name = "staffListBreadcrumb";
            staffListBreadcrumb.Size = new Size(92, 24);
            staffListBreadcrumb.TabIndex = 17;
            staffListBreadcrumb.Text = "Staff list";
            staffListBreadcrumb.Click += staffListBreadcrumb_Click;
            // 
            // staffDetailBreadcrumb
            // 
            staffDetailBreadcrumb.AutoSize = true;
            staffDetailBreadcrumb.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            staffDetailBreadcrumb.ForeColor = Color.FromArgb(0, 121, 124);
            staffDetailBreadcrumb.Location = new Point(223, 20);
            staffDetailBreadcrumb.Name = "staffDetailBreadcrumb";
            staffDetailBreadcrumb.Size = new Size(124, 24);
            staffDetailBreadcrumb.TabIndex = 18;
            staffDetailBreadcrumb.Text = "StaffDetails";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(AddStaffbutton);
            panel1.Controls.Add(panelStaffDetails);
            panel1.Controls.Add(staffDetailBreadcrumb);
            panel1.Controls.Add(staffListBreadcrumb);
            panel1.Controls.Add(Home);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tickButtonPictureBox);
            panel1.Location = new Point(14, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 579);
            panel1.TabIndex = 19;
            // 
            // AddStaffbutton
            // 
            AddStaffbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddStaffbutton.AutoSize = true;
            AddStaffbutton.BackColor = Color.FromArgb(0, 214, 220);
            AddStaffbutton.BackgroundImageLayout = ImageLayout.Center;
            AddStaffbutton.FlatStyle = FlatStyle.Flat;
            AddStaffbutton.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddStaffbutton.ForeColor = Color.White;
            AddStaffbutton.Image = (Image)resources.GetObject("AddStaffbutton.Image");
            AddStaffbutton.Location = new Point(850, 3);
            AddStaffbutton.Margin = new Padding(3, 4, 3, 4);
            AddStaffbutton.Name = "AddStaffbutton";
            AddStaffbutton.Size = new Size(180, 60);
            AddStaffbutton.TabIndex = 22;
            AddStaffbutton.Text = "   Add Staff";
            AddStaffbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddStaffbutton.UseVisualStyleBackColor = false;
            AddStaffbutton.Click += AddStaffbutton_Click;
            // 
            // panelStaffDetails
            // 
            panelStaffDetails.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelStaffDetails.BackColor = Color.FromArgb(244, 255, 255);
            panelStaffDetails.BorderStyle = BorderStyle.FixedSingle;
            panelStaffDetails.Controls.Add(phoneVal);
            panelStaffDetails.Controls.Add(panelColorRed);
            panelStaffDetails.Controls.Add(panelRoundColor);
            panelStaffDetails.Controls.Add(pnlNameStatus);
            panelStaffDetails.Controls.Add(passwordVal);
            panelStaffDetails.Controls.Add(emailVal);
            panelStaffDetails.Controls.Add(pictureBox4);
            panelStaffDetails.Controls.Add(pictureBox3);
            panelStaffDetails.Controls.Add(label9);
            panelStaffDetails.Controls.Add(PhonepictureBox);
            panelStaffDetails.Controls.Add(AddressVal);
            panelStaffDetails.Controls.Add(AddresspictureBox);
            panelStaffDetails.Controls.Add(DeleteStaffDetail);
            panelStaffDetails.Controls.Add(EditStaffDetail);
            panelStaffDetails.Controls.Add(ProfileVal);
            panelStaffDetails.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelStaffDetails.Location = new Point(129, 123);
            panelStaffDetails.Margin = new Padding(3, 4, 3, 4);
            panelStaffDetails.Name = "panelStaffDetails";
            panelStaffDetails.Size = new Size(806, 295);
            panelStaffDetails.TabIndex = 19;
            // 
            // phoneVal
            // 
            phoneVal.BackColor = Color.FromArgb(244, 255, 255);
            phoneVal.BorderStyle = BorderStyle.None;
            phoneVal.Font = new Font("Inter", 13.8F);
            phoneVal.Location = new Point(361, 144);
            phoneVal.Name = "phoneVal";
            phoneVal.Size = new Size(252, 28);
            phoneVal.TabIndex = 0;
            phoneVal.Text = "000-000-0000";
            // 
            // panelColorRed
            // 
            panelColorRed.Anchor = AnchorStyles.Left;
            panelColorRed.BackColor = Color.Red;
            panelColorRed.Location = new Point(234, 188);
            panelColorRed.Name = "panelColorRed";
            panelColorRed.Size = new Size(28, 28);
            panelColorRed.TabIndex = 21;
            panelColorRed.Visible = false;
            // 
            // panelRoundColor
            // 
            panelRoundColor.Anchor = AnchorStyles.Left;
            panelRoundColor.BackColor = Color.FromArgb(29, 193, 65);
            panelRoundColor.Location = new Point(234, 188);
            panelRoundColor.Name = "panelRoundColor";
            panelRoundColor.Size = new Size(28, 28);
            panelRoundColor.TabIndex = 20;
            panelRoundColor.Visible = false;
            // 
            // pnlNameStatus
            // 
            pnlNameStatus.Anchor = AnchorStyles.Left;
            pnlNameStatus.AutoSize = true;
            pnlNameStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlNameStatus.Controls.Add(activeStatus);
            pnlNameStatus.Controls.Add(statusPending);
            pnlNameStatus.Controls.Add(nameVal);
            pnlNameStatus.Location = new Point(320, 28);
            pnlNameStatus.Margin = new Padding(3, 4, 3, 4);
            pnlNameStatus.Name = "pnlNameStatus";
            pnlNameStatus.Size = new Size(232, 59);
            pnlNameStatus.TabIndex = 35;
            // 
            // activeStatus
            // 
            activeStatus.BackgroundImageLayout = ImageLayout.Stretch;
            activeStatus.Image = Properties.Resources.active;
            activeStatus.Location = new Point(160, 22);
            activeStatus.Margin = new Padding(0);
            activeStatus.Name = "activeStatus";
            activeStatus.Size = new Size(72, 25);
            activeStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            activeStatus.TabIndex = 33;
            activeStatus.TabStop = false;
            activeStatus.Visible = false;
            // 
            // statusPending
            // 
            statusPending.Image = (Image)resources.GetObject("statusPending.Image");
            statusPending.Location = new Point(162, 22);
            statusPending.Margin = new Padding(0);
            statusPending.Name = "statusPending";
            statusPending.Size = new Size(70, 25);
            statusPending.SizeMode = PictureBoxSizeMode.StretchImage;
            statusPending.TabIndex = 34;
            statusPending.TabStop = false;
            statusPending.Visible = false;
            // 
            // nameVal
            // 
            nameVal.AutoSize = true;
            nameVal.Font = new Font("Inter SemiBold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameVal.ForeColor = Color.FromArgb(37, 37, 37);
            nameVal.Location = new Point(0, 5);
            nameVal.Margin = new Padding(0);
            nameVal.Name = "nameVal";
            nameVal.Size = new Size(147, 54);
            nameVal.TabIndex = 3;
            nameVal.Text = "Name";
            // 
            // passwordVal
            // 
            passwordVal.Anchor = AnchorStyles.Left;
            passwordVal.AutoEllipsis = true;
            passwordVal.AutoSize = true;
            passwordVal.FlatStyle = FlatStyle.Flat;
            passwordVal.Font = new Font("Inter", 13.8F);
            passwordVal.ForeColor = Color.FromArgb(37, 37, 37);
            passwordVal.Location = new Point(361, 226);
            passwordVal.Name = "passwordVal";
            passwordVal.RightToLeft = RightToLeft.No;
            passwordVal.Size = new Size(119, 28);
            passwordVal.TabIndex = 30;
            passwordVal.Text = "password";
            passwordVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailVal
            // 
            emailVal.Anchor = AnchorStyles.Left;
            emailVal.AutoEllipsis = true;
            emailVal.AutoSize = true;
            emailVal.FlatStyle = FlatStyle.Flat;
            emailVal.Font = new Font("Inter", 13.8F);
            emailVal.ForeColor = Color.FromArgb(37, 37, 37);
            emailVal.Location = new Point(360, 103);
            emailVal.Name = "emailVal";
            emailVal.RightToLeft = RightToLeft.No;
            emailVal.Size = new Size(55, 28);
            emailVal.TabIndex = 29;
            emailVal.Text = "Mail";
            emailVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(319, 225);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(319, 101);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(301, 85);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 21;
            // 
            // PhonepictureBox
            // 
            PhonepictureBox.Anchor = AnchorStyles.Left;
            PhonepictureBox.Image = (Image)resources.GetObject("PhonepictureBox.Image");
            PhonepictureBox.Location = new Point(319, 141);
            PhonepictureBox.Margin = new Padding(3, 4, 3, 4);
            PhonepictureBox.Name = "PhonepictureBox";
            PhonepictureBox.Size = new Size(30, 30);
            PhonepictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PhonepictureBox.TabIndex = 20;
            PhonepictureBox.TabStop = false;
            // 
            // AddressVal
            // 
            AddressVal.Anchor = AnchorStyles.Left;
            AddressVal.AutoSize = true;
            AddressVal.FlatStyle = FlatStyle.Flat;
            AddressVal.Font = new Font("Inter", 13.8F);
            AddressVal.ForeColor = Color.FromArgb(37, 37, 37);
            AddressVal.Location = new Point(361, 186);
            AddressVal.Name = "AddressVal";
            AddressVal.RightToLeft = RightToLeft.No;
            AddressVal.Size = new Size(102, 28);
            AddressVal.TabIndex = 19;
            AddressVal.Text = "Address";
            AddressVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddresspictureBox
            // 
            AddresspictureBox.Anchor = AnchorStyles.Left;
            AddresspictureBox.Image = (Image)resources.GetObject("AddresspictureBox.Image");
            AddresspictureBox.Location = new Point(319, 184);
            AddresspictureBox.Margin = new Padding(3, 4, 3, 4);
            AddresspictureBox.Name = "AddresspictureBox";
            AddresspictureBox.Size = new Size(30, 30);
            AddresspictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            AddresspictureBox.TabIndex = 18;
            AddresspictureBox.TabStop = false;
            // 
            // DeleteStaffDetail
            // 
            DeleteStaffDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteStaffDetail.BackColor = Color.FromArgb(248, 10, 25);
            DeleteStaffDetail.FlatStyle = FlatStyle.Flat;
            DeleteStaffDetail.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteStaffDetail.ForeColor = Color.White;
            DeleteStaffDetail.Location = new Point(619, 170);
            DeleteStaffDetail.Margin = new Padding(3, 4, 3, 4);
            DeleteStaffDetail.Name = "DeleteStaffDetail";
            DeleteStaffDetail.Size = new Size(131, 56);
            DeleteStaffDetail.TabIndex = 2;
            DeleteStaffDetail.Text = "Delete Staff";
            DeleteStaffDetail.UseVisualStyleBackColor = false;
            DeleteStaffDetail.Click += DeleteStaffDetail_Click;
            // 
            // EditStaffDetail
            // 
            EditStaffDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditStaffDetail.BackColor = Color.FromArgb(61, 61, 61);
            EditStaffDetail.FlatStyle = FlatStyle.Flat;
            EditStaffDetail.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditStaffDetail.ForeColor = Color.White;
            EditStaffDetail.Location = new Point(619, 71);
            EditStaffDetail.Margin = new Padding(3, 4, 3, 4);
            EditStaffDetail.Name = "EditStaffDetail";
            EditStaffDetail.Size = new Size(131, 56);
            EditStaffDetail.TabIndex = 1;
            EditStaffDetail.Text = "Edit Details";
            EditStaffDetail.UseVisualStyleBackColor = false;
            EditStaffDetail.Click += EditStaffDetail_Click;
            // 
            // ProfileVal
            // 
            ProfileVal.Anchor = AnchorStyles.Left;
            ProfileVal.BackColor = Color.FromArgb(249, 249, 249);
            ProfileVal.BackgroundImageLayout = ImageLayout.Center;
            ProfileVal.Image = Properties.Resources.Profile;
            ProfileVal.Location = new Point(51, 50);
            ProfileVal.Margin = new Padding(3, 4, 3, 4);
            ProfileVal.Name = "ProfileVal";
            ProfileVal.Size = new Size(207, 207);
            ProfileVal.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfileVal.TabIndex = 0;
            ProfileVal.TabStop = false;
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
            tickButtonPictureBox.Size = new Size(1033, 579);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 35;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // imageListStatus
            // 
            imageListStatus.ColorDepth = ColorDepth.Depth32Bit;
            imageListStatus.ImageStream = (ImageListStreamer)resources.GetObject("imageListStatus.ImageStream");
            imageListStatus.TransparentColor = Color.Transparent;
            imageListStatus.Images.SetKeyName(0, "Active.png");
            imageListStatus.Images.SetKeyName(1, "Inactive.png");
            // 
            // StaffDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1061, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StaffDetails";
            Text = "Staff Details";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelStaffDetails.ResumeLayout(false);
            panelStaffDetails.PerformLayout();
            pnlNameStatus.ResumeLayout(false);
            pnlNameStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)activeStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusPending).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhonepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddresspictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfileVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Home;
        private Label staffListBreadcrumb;
        private Label staffDetailBreadcrumb;
        private Panel panel1;
        private Panel panelHotelDetails;
        private Label passwordVal;
        private Label emailVal;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label9;
        private PictureBox PhonepictureBox;
        private Label AddressVal;
        private PictureBox AddresspictureBox;
        private Label nameVal;
        private Button DeleteHotelDetail;
        private Button EditHotelDetail;
        private PictureBox ProfileVal;
        private Button AddStaffbutton;
        private ImageList imageListStatus;
        private PictureBox activeStatus;
        private Panel panelStaffDetails;
        private Button DeleteStaffDetail;
        private Button EditStaffDetail;
        private PictureBox pendingStatus;
        private Panel pnlNameStatus;
        private PictureBox statusPending;
        private PictureBox tickButtonPictureBox;
        private Panel panelRoundColor;
        private Panel panelColorRed;
        private TextBox phoneVal;
    }
}