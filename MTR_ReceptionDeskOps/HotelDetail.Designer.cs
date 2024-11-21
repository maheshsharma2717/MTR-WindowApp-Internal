using System.Net;

namespace MTRDesktopApplication
{
    partial class HotelDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelDetail));
            panel1 = new Panel();
            HotelId = new Label();
            panelHotelDetails = new Panel();
            phoneNumberTextBox = new TextBox();
            valueHotelId = new Label();
            label11 = new Label();
            label9 = new Label();
            PhonepictureBox = new PictureBox();
            Address = new Label();
            AddresspictureBox = new PictureBox();
            HotelName = new Label();
            DeleteHotelDetail = new Button();
            EditHotelDetail = new Button();
            pictureBox = new PictureBox();
            AddHotel = new Button();
            HotelNameBredcrumb = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            hotelListBredcrum = new Label();
            Home = new Label();
            tickButtonPictureBox = new PictureBox();
            panel1.SuspendLayout();
            panelHotelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhonepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddresspictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(HotelId);
            panel1.Controls.Add(panelHotelDetails);
            panel1.Controls.Add(AddHotel);
            panel1.Controls.Add(HotelNameBredcrumb);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(hotelListBredcrum);
            panel1.Controls.Add(Home);
            panel1.Controls.Add(tickButtonPictureBox);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1322, 862);
            panel1.TabIndex = 0;
            // 
            // HotelId
            // 
            HotelId.AutoSize = true;
            HotelId.Location = new Point(108, 129);
            HotelId.Name = "HotelId";
            HotelId.Size = new Size(0, 19);
            HotelId.TabIndex = 23;
            // 
            // panelHotelDetails
            // 
            panelHotelDetails.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelHotelDetails.BackColor = Color.FromArgb(230, 255, 255);
            panelHotelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelHotelDetails.Controls.Add(phoneNumberTextBox);
            panelHotelDetails.Controls.Add(valueHotelId);
            panelHotelDetails.Controls.Add(label11);
            panelHotelDetails.Controls.Add(label9);
            panelHotelDetails.Controls.Add(PhonepictureBox);
            panelHotelDetails.Controls.Add(Address);
            panelHotelDetails.Controls.Add(AddresspictureBox);
            panelHotelDetails.Controls.Add(HotelName);
            panelHotelDetails.Controls.Add(DeleteHotelDetail);
            panelHotelDetails.Controls.Add(EditHotelDetail);
            panelHotelDetails.Controls.Add(pictureBox);
            panelHotelDetails.Font = new Font("Inter", 9.75F);
            panelHotelDetails.Location = new Point(160, 228);
            panelHotelDetails.Margin = new Padding(3, 4, 3, 4);
            panelHotelDetails.Name = "panelHotelDetails";
            panelHotelDetails.Size = new Size(1014, 313);
            panelHotelDetails.TabIndex = 17;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.FromArgb(230, 255, 255);
            phoneNumberTextBox.BorderStyle = BorderStyle.None;
            phoneNumberTextBox.Font = new Font("Inter", 14F);
            phoneNumberTextBox.Location = new Point(419, 163);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(223, 29);
            phoneNumberTextBox.TabIndex = 27;
            phoneNumberTextBox.Text = "000-000-0000";
            // 
            // valueHotelId
            // 
            valueHotelId.Anchor = AnchorStyles.Left;
            valueHotelId.AutoSize = true;
            valueHotelId.Font = new Font("Inter", 14F);
            valueHotelId.Location = new Point(479, 120);
            valueHotelId.Name = "valueHotelId";
            valueHotelId.Size = new Size(73, 29);
            valueHotelId.TabIndex = 24;
            valueHotelId.Text = "5948";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(375, 123);
            label11.Name = "label11";
            label11.Size = new Size(98, 24);
            label11.TabIndex = 23;
            label11.Text = "Hotel ID :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 81);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 21;
            // 
            // PhonepictureBox
            // 
            PhonepictureBox.Anchor = AnchorStyles.Left;
            PhonepictureBox.Image = (Image)resources.GetObject("PhonepictureBox.Image");
            PhonepictureBox.Location = new Point(375, 164);
            PhonepictureBox.Margin = new Padding(3, 4, 3, 4);
            PhonepictureBox.Name = "PhonepictureBox";
            PhonepictureBox.Size = new Size(26, 26);
            PhonepictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PhonepictureBox.TabIndex = 20;
            PhonepictureBox.TabStop = false;
            // 
            // Address
            // 
            Address.Anchor = AnchorStyles.Left;
            Address.AutoEllipsis = true;
            Address.AutoSize = true;
            Address.FlatStyle = FlatStyle.Flat;
            Address.Font = new Font("Inter", 14F);
            Address.Location = new Point(419, 208);
            Address.MaximumSize = new Size(500, 0);
            Address.Name = "Address";
            Address.RightToLeft = RightToLeft.No;
            Address.Size = new Size(108, 29);
            Address.TabIndex = 19;
            Address.Text = "Address";
            Address.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddresspictureBox
            // 
            AddresspictureBox.Anchor = AnchorStyles.Left;
            AddresspictureBox.Image = (Image)resources.GetObject("AddresspictureBox.Image");
            AddresspictureBox.Location = new Point(375, 209);
            AddresspictureBox.Margin = new Padding(3, 4, 3, 4);
            AddresspictureBox.Name = "AddresspictureBox";
            AddresspictureBox.Size = new Size(26, 26);
            AddresspictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AddresspictureBox.TabIndex = 18;
            AddresspictureBox.TabStop = false;
            // 
            // HotelName
            // 
            HotelName.Anchor = AnchorStyles.Left;
            HotelName.AutoSize = true;
            HotelName.Font = new Font("Inter SemiBold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HotelName.Location = new Point(364, 48);
            HotelName.Name = "HotelName";
            HotelName.Size = new Size(261, 54);
            HotelName.TabIndex = 3;
            HotelName.Text = "HotelName";
            // 
            // DeleteHotelDetail
            // 
            DeleteHotelDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteHotelDetail.BackColor = Color.FromArgb(248, 10, 25);
            DeleteHotelDetail.FlatStyle = FlatStyle.Flat;
            DeleteHotelDetail.Font = new Font("Inter", 12F);
            DeleteHotelDetail.ForeColor = Color.White;
            DeleteHotelDetail.Location = new Point(750, 181);
            DeleteHotelDetail.Margin = new Padding(3, 4, 3, 4);
            DeleteHotelDetail.Name = "DeleteHotelDetail";
            DeleteHotelDetail.Size = new Size(169, 65);
            DeleteHotelDetail.TabIndex = 2;
            DeleteHotelDetail.Text = "Delete Hotel";
            DeleteHotelDetail.UseVisualStyleBackColor = false;
            DeleteHotelDetail.Click += DeleteHotelDetail_Click;
            // 
            // EditHotelDetail
            // 
            EditHotelDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditHotelDetail.BackColor = Color.FromArgb(61, 61, 61);
            EditHotelDetail.FlatStyle = FlatStyle.Flat;
            EditHotelDetail.Font = new Font("Inter", 12F);
            EditHotelDetail.ForeColor = Color.White;
            EditHotelDetail.Location = new Point(750, 81);
            EditHotelDetail.Margin = new Padding(3, 4, 3, 4);
            EditHotelDetail.Name = "EditHotelDetail";
            EditHotelDetail.Size = new Size(169, 63);
            EditHotelDetail.TabIndex = 1;
            EditHotelDetail.Text = "Edit Details";
            EditHotelDetail.UseVisualStyleBackColor = false;
            EditHotelDetail.Click += EditHotelDetail_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Left;
            pictureBox.BackgroundImageLayout = ImageLayout.Center;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(46, 48);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(219, 217);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // AddHotel
            // 
            AddHotel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddHotel.BackColor = Color.FromArgb(0, 214, 220);
            AddHotel.BackgroundImageLayout = ImageLayout.Center;
            AddHotel.Font = new Font("Inter", 9F, FontStyle.Bold);
            AddHotel.ForeColor = Color.White;
            AddHotel.Image = (Image)resources.GetObject("AddHotel.Image");
            AddHotel.ImageAlign = ContentAlignment.MiddleRight;
            AddHotel.Location = new Point(1090, 27);
            AddHotel.Margin = new Padding(3, 4, 3, 4);
            AddHotel.Name = "AddHotel";
            AddHotel.Size = new Size(167, 57);
            AddHotel.TabIndex = 16;
            AddHotel.Text = "    Add Hotel";
            AddHotel.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddHotel.UseVisualStyleBackColor = false;
            AddHotel.Click += AddHotel_Click;
            // 
            // HotelNameBredcrumb
            // 
            HotelNameBredcrumb.AutoSize = true;
            HotelNameBredcrumb.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HotelNameBredcrumb.ForeColor = Color.FromArgb(0, 121, 124);
            HotelNameBredcrumb.Location = new Point(235, 45);
            HotelNameBredcrumb.Name = "HotelNameBredcrumb";
            HotelNameBredcrumb.Size = new Size(148, 24);
            HotelNameBredcrumb.TabIndex = 15;
            HotelNameBredcrumb.Text = "RegencyHotel";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(211, 46);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 45);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // hotelListBredcrum
            // 
            hotelListBredcrum.AutoSize = true;
            hotelListBredcrum.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            hotelListBredcrum.ForeColor = Color.Black;
            hotelListBredcrum.Location = new Point(107, 46);
            hotelListBredcrum.Name = "hotelListBredcrum";
            hotelListBredcrum.Size = new Size(102, 24);
            hotelListBredcrum.TabIndex = 12;
            hotelListBredcrum.Text = "Hotel List";
            hotelListBredcrum.Click += hotelListBredcrum_Click;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            Home.Location = new Point(14, 44);
            Home.Name = "Home";
            Home.Size = new Size(67, 24);
            Home.TabIndex = 11;
            Home.Text = "Home";
            Home.Click += Home_Click;
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
            tickButtonPictureBox.Size = new Size(1322, 862);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 29;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // HotelDetail
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1329, 855);
            Controls.Add(panel1);
            Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HotelDetail";
            Text = "Hotel Detail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHotelDetails.ResumeLayout(false);
            panelHotelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhonepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddresspictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button AddHotel;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button DeleteHotelDetail;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Label label8;
        private PictureBox pictureBox4;
        private Button EditHotelDetail;
        private Label label10;
        private Label label9;
        private Label HotelId;
        private PictureBox pictureBox;
        private Label hotelNumber;
        private PictureBox PhonepictureBox;
        private Label Address;
        private PictureBox AddresspictureBox;
        private Label phoneNumber;
        private Label hotelNumberText;
        private Label HotelName;
        private Label HotelNameBredcrumb;
        private Label Home;
        private Label hotelListBredcrum;
        private PictureBox tickButtonPictureBox;
        private Panel panelHotelDetails;
        private Label valueHotelId;
        private Label label11;
        private Label label12;
        private TextBox phoneNumberTextBox;
        private Label BusNumber;
    }
}