namespace MTRDesktopApplication
{
    partial class BookingLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingLists));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelPagination = new Label();
            homeBreadcrumb = new Label();
            bookingBreadcrumb = new Label();
            tickButtonPictureBox = new PictureBox();
            deleteImage = new ImageList(components);
            panel3 = new Panel();
            NextBtn = new Panel();
            BackBtn = new Panel();
            dataGridView1 = new DataGridView();
            recentBtn = new Panel();
            labelRecent = new Label();
            downArrow = new PictureBox();
            recent = new PictureBox();
            pictureBox2 = new PictureBox();
            Serialnumber = new DataGridViewTextBoxColumn();
            BookingId = new DataGridViewTextBoxColumn();
            pName = new DataGridViewTextBoxColumn();
            Pickupdestination = new DataGridViewTextBoxColumn();
            SeatNumber = new DataGridViewTextBoxColumn();
            BookingStatus = new DataGridViewTextBoxColumn();
            DepartureTime = new DataGridViewTextBoxColumn();
            PaymentMethod = new DataGridViewTextBoxColumn();
            PaymentStatus = new DataGridViewTextBoxColumn();
            viewMore = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            recentBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)downArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelPagination
            // 
            labelPagination.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPagination.AutoSize = true;
            labelPagination.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPagination.ForeColor = Color.FromArgb(125, 125, 125);
            labelPagination.Location = new Point(50, 18);
            labelPagination.Name = "labelPagination";
            labelPagination.Size = new Size(51, 20);
            labelPagination.TabIndex = 7;
            labelPagination.Text = "Page";
            // 
            // homeBreadcrumb
            // 
            homeBreadcrumb.AutoSize = true;
            homeBreadcrumb.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            homeBreadcrumb.Location = new Point(22, 16);
            homeBreadcrumb.Name = "homeBreadcrumb";
            homeBreadcrumb.Size = new Size(67, 24);
            homeBreadcrumb.TabIndex = 16;
            homeBreadcrumb.Text = "Home";
            homeBreadcrumb.Click += homeBreadcrumb_Click;
            // 
            // bookingBreadcrumb
            // 
            bookingBreadcrumb.AutoSize = true;
            bookingBreadcrumb.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            bookingBreadcrumb.ForeColor = Color.FromArgb(0, 121, 124);
            bookingBreadcrumb.Location = new Point(128, 16);
            bookingBreadcrumb.Name = "bookingBreadcrumb";
            bookingBreadcrumb.Size = new Size(128, 24);
            bookingBreadcrumb.TabIndex = 17;
            bookingBreadcrumb.Text = "Booking List";
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
            tickButtonPictureBox.Size = new Size(1765, 811);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 29;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // deleteImage
            // 
            deleteImage.ColorDepth = ColorDepth.Depth24Bit;
            deleteImage.ImageStream = (ImageListStreamer)resources.GetObject("deleteImage.ImageStream");
            deleteImage.TransparentColor = Color.Transparent;
            deleteImage.Images.SetKeyName(0, "DeleteButton.png");
            deleteImage.Images.SetKeyName(1, "");
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(NextBtn);
            panel3.Controls.Add(BackBtn);
            panel3.Controls.Add(labelPagination);
            panel3.Location = new Point(1526, 713);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 57);
            panel3.TabIndex = 30;
            // 
            // NextBtn
            // 
            NextBtn.Anchor = AnchorStyles.Right;
            NextBtn.BackColor = Color.FromArgb(237, 255, 255);
            NextBtn.BackgroundImage = (Image)resources.GetObject("NextBtn.BackgroundImage");
            NextBtn.BackgroundImageLayout = ImageLayout.Center;
            NextBtn.Location = new Point(173, 7);
            NextBtn.Margin = new Padding(3, 4, 3, 4);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(42, 42);
            NextBtn.TabIndex = 0;
            NextBtn.Click += NextBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Anchor = AnchorStyles.Left;
            BackBtn.BackColor = Color.FromArgb(237, 255, 255);
            BackBtn.BackgroundImage = (Image)resources.GetObject("BackBtn.BackgroundImage");
            BackBtn.BackgroundImageLayout = ImageLayout.Center;
            BackBtn.Location = new Point(3, 7);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(42, 42);
            BackBtn.TabIndex = 3;
            BackBtn.Click += BackBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 255, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(237, 255, 255);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(237, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 65;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Serialnumber, BookingId, pName, Pickupdestination, SeatNumber, BookingStatus, DepartureTime, PaymentMethod, PaymentStatus, viewMore });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(237, 255, 255);
            dataGridViewCellStyle4.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(239, 238, 238);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(16, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(239, 238, 238);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.Height = 55;
            dataGridView1.Size = new Size(1732, 569);
            dataGridView1.TabIndex = 31;
            // 
            // recentBtn
            // 
            recentBtn.BackColor = Color.FromArgb(244, 244, 244);
            recentBtn.Controls.Add(labelRecent);
            recentBtn.Controls.Add(downArrow);
            recentBtn.Controls.Add(recent);
            recentBtn.Location = new Point(18, 56);
            recentBtn.Margin = new Padding(3, 4, 3, 4);
            recentBtn.Name = "recentBtn";
            recentBtn.Size = new Size(170, 45);
            recentBtn.TabIndex = 32;
            recentBtn.Click += recentBtn_Click;
            // 
            // labelRecent
            // 
            labelRecent.AutoSize = true;
            labelRecent.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRecent.Location = new Point(55, 12);
            labelRecent.Name = "labelRecent";
            labelRecent.Size = new Size(65, 20);
            labelRecent.TabIndex = 2;
            labelRecent.Text = "Recent";
            labelRecent.Click += labelRecent_Click;
            // 
            // downArrow
            // 
            downArrow.Anchor = AnchorStyles.Right;
            downArrow.BackgroundImage = (Image)resources.GetObject("downArrow.BackgroundImage");
            downArrow.BackgroundImageLayout = ImageLayout.Center;
            downArrow.Location = new Point(122, 1);
            downArrow.Margin = new Padding(3, 4, 3, 4);
            downArrow.Name = "downArrow";
            downArrow.Size = new Size(47, 43);
            downArrow.TabIndex = 1;
            downArrow.TabStop = false;
            downArrow.Click += downArrow_Click;
            // 
            // recent
            // 
            recent.Anchor = AnchorStyles.Left;
            recent.BackgroundImage = (Image)resources.GetObject("recent.BackgroundImage");
            recent.BackgroundImageLayout = ImageLayout.Center;
            recent.Location = new Point(1, 1);
            recent.Margin = new Padding(3, 4, 3, 4);
            recent.Name = "recent";
            recent.Size = new Size(46, 43);
            recent.TabIndex = 0;
            recent.TabStop = false;
            recent.Click += recent_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(98, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // Serialnumber
            // 
            Serialnumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Serialnumber.HeaderText = "S/N";
            Serialnumber.MinimumWidth = 6;
            Serialnumber.Name = "Serialnumber";
            Serialnumber.ReadOnly = true;
            Serialnumber.Width = 70;
            // 
            // BookingId
            // 
            BookingId.HeaderText = "Id";
            BookingId.MinimumWidth = 6;
            BookingId.Name = "BookingId";
            BookingId.ReadOnly = true;
            BookingId.Visible = false;
            // 
            // pName
            // 
            pName.HeaderText = "Name";
            pName.MinimumWidth = 6;
            pName.Name = "pName";
            pName.ReadOnly = true;
            // 
            // Pickupdestination
            // 
            Pickupdestination.HeaderText = "Pick Up Destination";
            Pickupdestination.MinimumWidth = 6;
            Pickupdestination.Name = "Pickupdestination";
            Pickupdestination.ReadOnly = true;
            // 
            // SeatNumber
            // 
            SeatNumber.HeaderText = "Seat Number";
            SeatNumber.MinimumWidth = 6;
            SeatNumber.Name = "SeatNumber";
            SeatNumber.ReadOnly = true;
            // 
            // BookingStatus
            // 
            BookingStatus.HeaderText = "Booking Status";
            BookingStatus.MinimumWidth = 6;
            BookingStatus.Name = "BookingStatus";
            BookingStatus.ReadOnly = true;
            // 
            // DepartureTime
            // 
            DepartureTime.HeaderText = "Departure Time";
            DepartureTime.MinimumWidth = 6;
            DepartureTime.Name = "DepartureTime";
            DepartureTime.ReadOnly = true;
            // 
            // PaymentMethod
            // 
            dataGridViewCellStyle3.Font = new Font("Inter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(99, 91, 255);
            PaymentMethod.DefaultCellStyle = dataGridViewCellStyle3;
            PaymentMethod.HeaderText = "Payment Method";
            PaymentMethod.MinimumWidth = 6;
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            PaymentStatus.HeaderText = "Payment Status";
            PaymentStatus.MinimumWidth = 6;
            PaymentStatus.Name = "PaymentStatus";
            PaymentStatus.ReadOnly = true;
            // 
            // viewMore
            // 
            viewMore.HeaderText = "View More";
            viewMore.Image = Properties.Resources.viewMoreImg;
            viewMore.MinimumWidth = 6;
            viewMore.Name = "viewMore";
            viewMore.ReadOnly = true;
            // 
            // BookingLists
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1765, 811);
            Controls.Add(pictureBox2);
            Controls.Add(recentBtn);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(bookingBreadcrumb);
            Controls.Add(homeBreadcrumb);
            Controls.Add(tickButtonPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingLists";
            Text = "Booking List";
            Load += BookingList_Load;
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            recentBtn.ResumeLayout(false);
            recentBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)downArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)recent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Button ButtonNext;
        private Button ButtonPrevious;
        private Label labelPagination;
        private Button button1;
        private PictureBox pictureBox1;
        private Label homeBreadcrumb;
        private Label bookingBreadcrumb;
        private Panel panelPagination;
        private Button recentRecord;
        private PictureBox tickButtonPictureBox;
        private ImageList deleteImage;
        private Panel panel3;
        private Panel NextBtn;
        private Panel BackBtn;
        private Label label1;
        private DataGridView dataGridView2;
        private Panel recentBtn;
        private Label labelRecent;
        private PictureBox downArrow;
        private PictureBox recent;
        private DataGridViewTextBoxColumn Serialnumber;
        private DataGridViewTextBoxColumn BookingId;
        private DataGridViewTextBoxColumn pName;
        private DataGridViewTextBoxColumn Pickupdestination;
        private DataGridViewTextBoxColumn SeatNumber;
        private DataGridViewTextBoxColumn BookingStatus;
        private DataGridViewTextBoxColumn DepartureTime;
        private DataGridViewTextBoxColumn PaymentMethod;
        private DataGridViewTextBoxColumn PaymentStatus;
        private DataGridViewImageColumn deleteData;
        private PictureBox pictureBox2;
        private DataGridViewImageColumn viewMore;
    }
}