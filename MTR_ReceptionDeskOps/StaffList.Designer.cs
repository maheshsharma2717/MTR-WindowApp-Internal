namespace MTRDesktopApplication
{
    partial class StaffList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panelStaffLists = new Panel();
            panel3 = new Panel();
            NextBtn = new Panel();
            BackBtn = new Panel();
            labelPagination = new Label();
            dataGridView1 = new DataGridView();
            SN = new DataGridViewTextBoxColumn();
            userId = new DataGridViewTextBoxColumn();
            profilePic = new DataGridViewImageColumn();
            userName = new DataGridViewTextBoxColumn();
            phoneNumber = new DataGridViewTextBoxColumn();
            userEmail = new DataGridViewTextBoxColumn();
            Status = new DataGridViewImageColumn();
            viewMore = new DataGridViewImageColumn();
            AddStaffbutton = new Button();
            staffBredcrumb = new Label();
            pictureBox1 = new PictureBox();
            homeBredcrumb = new Label();
            tickButtonPictureBox = new PictureBox();
            imageListStatus = new ImageList(components);
            imageListView = new ImageList(components);
            panelStaffLists.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelStaffLists
            // 
            panelStaffLists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelStaffLists.Controls.Add(panel3);
            panelStaffLists.Controls.Add(dataGridView1);
            panelStaffLists.Controls.Add(AddStaffbutton);
            panelStaffLists.Controls.Add(staffBredcrumb);
            panelStaffLists.Controls.Add(pictureBox1);
            panelStaffLists.Controls.Add(homeBredcrumb);
            panelStaffLists.Controls.Add(tickButtonPictureBox);
            panelStaffLists.Location = new Point(14, 16);
            panelStaffLists.Margin = new Padding(3, 4, 3, 4);
            panelStaffLists.Name = "panelStaffLists";
            panelStaffLists.Size = new Size(1112, 781);
            panelStaffLists.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(NextBtn);
            panel3.Controls.Add(BackBtn);
            panel3.Controls.Add(labelPagination);
            panel3.Location = new Point(853, 723);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 55);
            panel3.TabIndex = 31;
            panel3.Visible = false;
            // 
            // NextBtn
            // 
            NextBtn.Anchor = AnchorStyles.Right;
            NextBtn.BackColor = Color.FromArgb(237, 255, 255);
            NextBtn.BackgroundImage = (Image)resources.GetObject("NextBtn.BackgroundImage");
            NextBtn.BackgroundImageLayout = ImageLayout.Center;
            NextBtn.Location = new Point(190, 5);
            NextBtn.Margin = new Padding(3, 4, 3, 4);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(45, 45);
            NextBtn.TabIndex = 0;
            NextBtn.Click += NextBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Anchor = AnchorStyles.Left;
            BackBtn.BackColor = Color.FromArgb(237, 255, 255);
            BackBtn.BackgroundImage = (Image)resources.GetObject("BackBtn.BackgroundImage");
            BackBtn.BackgroundImageLayout = ImageLayout.Center;
            BackBtn.Location = new Point(5, 5);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(45, 45);
            BackBtn.TabIndex = 3;
            BackBtn.Click += BackBtn_Click;
            // 
            // labelPagination
            // 
            labelPagination.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPagination.AutoSize = true;
            labelPagination.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPagination.ForeColor = Color.FromArgb(125, 125, 125);
            labelPagination.Location = new Point(53, 20);
            labelPagination.Name = "labelPagination";
            labelPagination.Size = new Size(51, 20);
            labelPagination.TabIndex = 7;
            labelPagination.Text = "Page";
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
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(237, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 65;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SN, userId, profilePic, userName, phoneNumber, userEmail, Status, viewMore });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(239, 238, 238);
            dataGridViewCellStyle6.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(239, 238, 238);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(37, 37, 37);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(11, 104);
            dataGridView1.Margin = new Padding(3, 15, 3, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(1075, 612);
            dataGridView1.TabIndex = 22;
            // 
            // SN
            // 
            SN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SN.HeaderText = "S/N";
            SN.MinimumWidth = 6;
            SN.Name = "SN";
            SN.ReadOnly = true;
            SN.Width = 60;
            // 
            // userId
            // 
            userId.HeaderText = "User Id";
            userId.MinimumWidth = 6;
            userId.Name = "userId";
            userId.ReadOnly = true;
            userId.Visible = false;
            // 
            // profilePic
            // 
            profilePic.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            profilePic.DefaultCellStyle = dataGridViewCellStyle3;
            profilePic.HeaderText = "Profile";
            profilePic.MinimumWidth = 6;
            profilePic.Name = "profilePic";
            profilePic.ReadOnly = true;
            profilePic.Resizable = DataGridViewTriState.True;
            profilePic.SortMode = DataGridViewColumnSortMode.Automatic;
            profilePic.Width = 170;
            // 
            // userName
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            userName.DefaultCellStyle = dataGridViewCellStyle4;
            userName.HeaderText = "Name";
            userName.MinimumWidth = 6;
            userName.Name = "userName";
            userName.ReadOnly = true;
            // 
            // phoneNumber
            // 
            phoneNumber.HeaderText = "Phone Number";
            phoneNumber.MinimumWidth = 6;
            phoneNumber.Name = "phoneNumber";
            phoneNumber.ReadOnly = true;
            // 
            // userEmail
            // 
            userEmail.HeaderText = "Email";
            userEmail.MinimumWidth = 6;
            userEmail.Name = "userEmail";
            userEmail.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // viewMore
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = resources.GetObject("dataGridViewCellStyle5.NullValue");
            dataGridViewCellStyle5.Padding = new Padding(3, 8, 3, 8);
            viewMore.DefaultCellStyle = dataGridViewCellStyle5;
            viewMore.HeaderText = "";
            viewMore.Image = Properties.Resources.viewMoreImg;
            viewMore.MinimumWidth = 6;
            viewMore.Name = "viewMore";
            viewMore.ReadOnly = true;
            viewMore.ToolTipText = "View More";
            // 
            // AddStaffbutton
            // 
            AddStaffbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddStaffbutton.AutoSize = true;
            AddStaffbutton.BackColor = Color.FromArgb(0, 214, 220);
            AddStaffbutton.BackgroundImageLayout = ImageLayout.Center;
            AddStaffbutton.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddStaffbutton.ForeColor = Color.White;
            AddStaffbutton.Image = (Image)resources.GetObject("AddStaffbutton.Image");
            AddStaffbutton.Location = new Point(906, 5);
            AddStaffbutton.Margin = new Padding(3, 4, 3, 4);
            AddStaffbutton.Name = "AddStaffbutton";
            AddStaffbutton.Size = new Size(180, 60);
            AddStaffbutton.TabIndex = 21;
            AddStaffbutton.Text = "    Add Staff";
            AddStaffbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddStaffbutton.UseVisualStyleBackColor = false;
            AddStaffbutton.Click += AddStaffbutton_Click;
            // 
            // staffBredcrumb
            // 
            staffBredcrumb.AutoSize = true;
            staffBredcrumb.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            staffBredcrumb.ForeColor = Color.FromArgb(0, 121, 124);
            staffBredcrumb.Location = new Point(114, 15);
            staffBredcrumb.Name = "staffBredcrumb";
            staffBredcrumb.Size = new Size(98, 24);
            staffBredcrumb.TabIndex = 18;
            staffBredcrumb.Text = "Staff List";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // homeBredcrumb
            // 
            homeBredcrumb.AutoSize = true;
            homeBredcrumb.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            homeBredcrumb.ForeColor = Color.FromArgb(37, 37, 37);
            homeBredcrumb.Location = new Point(15, 15);
            homeBredcrumb.Name = "homeBredcrumb";
            homeBredcrumb.Size = new Size(67, 24);
            homeBredcrumb.TabIndex = 16;
            homeBredcrumb.Text = "Home";
            homeBredcrumb.Click += homeBredcrumb_Click;
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
            tickButtonPictureBox.Size = new Size(1112, 781);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 28;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // imageListStatus
            // 
            imageListStatus.ColorDepth = ColorDepth.Depth32Bit;
            imageListStatus.ImageStream = (ImageListStreamer)resources.GetObject("imageListStatus.ImageStream");
            imageListStatus.TransparentColor = Color.Transparent;
            imageListStatus.Images.SetKeyName(0, "Active.png");
            imageListStatus.Images.SetKeyName(1, "pending.png");
            // 
            // imageListView
            // 
            imageListView.ColorDepth = ColorDepth.Depth32Bit;
            imageListView.ImageStream = (ImageListStreamer)resources.GetObject("imageListView.ImageStream");
            imageListView.TransparentColor = Color.Transparent;
            imageListView.Images.SetKeyName(0, "viewMoreImg.png");
            // 
            // StaffList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 813);
            Controls.Add(panelStaffLists);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StaffList";
            Text = "Staff List";
            Load += StaffLists_Load;
            panelStaffLists.ResumeLayout(false);
            panelStaffLists.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStaffLists;
        private Label homeBredcrumb;
        private PictureBox pictureBox1;
        private Label staffBredcrumb;
        private DataGridView dataGridViewStaff;
        private Panel panelPagination;
        private Button ButtonNextPagination;
        private Button ButtonPreviousPegination;
        private Label labelPagination;
        private Button AddStaffbutton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userPassword;
        private DataGridViewTextBoxColumn voip;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Snumber;
        private DataGridViewTextBoxColumn uId;
        private DataGridViewTextBoxColumn uName;
        private DataGridViewTextBoxColumn uPassword;
        private DataGridViewTextBoxColumn uMail;
        private DataGridViewTextBoxColumn vIp;
        private PictureBox tickButtonPictureBox;
        private Panel panel3;
        private Panel NextBtn;
        private Panel BackBtn;
        private Label label1;
        private ImageList imageListStatus;
        private ImageList imageListView;
        private DataGridViewTextBoxColumn SN;
        private DataGridViewTextBoxColumn userId;
        private DataGridViewImageColumn profilePic;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn userEmail;
        private DataGridViewImageColumn Status;
        private DataGridViewImageColumn viewMore;
    }
}