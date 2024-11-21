namespace MTRDesktopApplication
{
    partial class BusList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            PaginationLbl = new Label();
            addBusButton = new Button();
            homeBreadcrumbs = new Label();
            pictureBox1 = new PictureBox();
            busBreadcrumbs = new Label();
            dataGridView1 = new DataGridView();
            Snumber = new DataGridViewTextBoxColumn();
            VechileId = new DataGridViewTextBoxColumn();
            Images = new DataGridViewImageColumn();
            Model = new DataGridViewTextBoxColumn();
            PlateNumber = new DataGridViewTextBoxColumn();
            Colour = new DataGridViewTextBoxColumn();
            colorName = new DataGridViewTextBoxColumn();
            numberofseates = new DataGridViewTextBoxColumn();
            SittingPlan = new DataGridViewTextBoxColumn();
            destinationName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewImageColumn();
            ViewMore1 = new DataGridViewImageColumn();
            modelBusList = new ImageList(components);
            statusBusList = new ImageList(components);
            viewMoreBusList = new ImageList(components);
            panel1 = new Panel();
            panel3 = new Panel();
            NextBtn = new Panel();
            BackBtn = new Panel();
            tickButtonPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // PaginationLbl
            // 
            PaginationLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PaginationLbl.AutoSize = true;
            PaginationLbl.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaginationLbl.ForeColor = Color.FromArgb(125, 125, 125);
            PaginationLbl.Location = new Point(52, 18);
            PaginationLbl.Name = "PaginationLbl";
            PaginationLbl.Size = new Size(51, 20);
            PaginationLbl.TabIndex = 7;
            PaginationLbl.Text = "Page";
            // 
            // addBusButton
            // 
            addBusButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addBusButton.BackColor = Color.FromArgb(0, 214, 220);
            addBusButton.BackgroundImageLayout = ImageLayout.Center;
            addBusButton.Font = new Font("Inter", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBusButton.ForeColor = Color.White;
            addBusButton.Image = (Image)resources.GetObject("addBusButton.Image");
            addBusButton.ImageAlign = ContentAlignment.MiddleRight;
            addBusButton.Location = new Point(1060, 6);
            addBusButton.Name = "addBusButton";
            addBusButton.Size = new Size(167, 60);
            addBusButton.TabIndex = 17;
            addBusButton.Text = "  Add Bus";
            addBusButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addBusButton.UseVisualStyleBackColor = false;
            addBusButton.Click += addBusButton_Click;
            // 
            // homeBreadcrumbs
            // 
            homeBreadcrumbs.AutoSize = true;
            homeBreadcrumbs.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            homeBreadcrumbs.Location = new Point(21, 23);
            homeBreadcrumbs.Name = "homeBreadcrumbs";
            homeBreadcrumbs.Size = new Size(67, 24);
            homeBreadcrumbs.TabIndex = 12;
            homeBreadcrumbs.Text = "Home";
            homeBreadcrumbs.Click += homeBreadcrumbs_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // busBreadcrumbs
            // 
            busBreadcrumbs.AutoSize = true;
            busBreadcrumbs.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            busBreadcrumbs.ForeColor = Color.FromArgb(0, 121, 124);
            busBreadcrumbs.Location = new Point(127, 23);
            busBreadcrumbs.Name = "busBreadcrumbs";
            busBreadcrumbs.Size = new Size(81, 24);
            busBreadcrumbs.TabIndex = 15;
            busBreadcrumbs.Text = "BusList";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Snumber, VechileId, Images, Model, PlateNumber, Colour, colorName, numberofseates, SittingPlan, destinationName, Status, ViewMore1 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(239, 238, 238);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(239, 238, 238);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(10, 102);
            dataGridView1.Margin = new Padding(3, 15, 3, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(239, 238, 238);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.Height = 55;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(1230, 455);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // Snumber
            // 
            Snumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Snumber.HeaderText = "S/N";
            Snumber.MinimumWidth = 6;
            Snumber.Name = "Snumber";
            Snumber.ReadOnly = true;
            Snumber.Width = 60;
            // 
            // VechileId
            // 
            VechileId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            VechileId.HeaderText = "Vechile Id";
            VechileId.MinimumWidth = 6;
            VechileId.Name = "VechileId";
            VechileId.ReadOnly = true;
            VechileId.Visible = false;
            VechileId.Width = 90;
            // 
            // Images
            // 
            Images.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Images.HeaderText = "";
            Images.MinimumWidth = 6;
            Images.Name = "Images";
            Images.ReadOnly = true;
            Images.Width = 60;
            // 
            // Model
            // 
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Model.DefaultCellStyle = dataGridViewCellStyle3;
            Model.HeaderText = "Model";
            Model.MinimumWidth = 6;
            Model.Name = "Model";
            Model.ReadOnly = true;
            Model.Resizable = DataGridViewTriState.False;
            // 
            // PlateNumber
            // 
            PlateNumber.HeaderText = "Plate Number";
            PlateNumber.MinimumWidth = 6;
            PlateNumber.Name = "PlateNumber";
            PlateNumber.ReadOnly = true;
            // 
            // Colour
            // 
            Colour.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.ForeColor = Color.Transparent;
            dataGridViewCellStyle4.Padding = new Padding(5);
            Colour.DefaultCellStyle = dataGridViewCellStyle4;
            Colour.HeaderText = "";
            Colour.MinimumWidth = 6;
            Colour.Name = "Colour";
            Colour.ReadOnly = true;
            Colour.Resizable = DataGridViewTriState.True;
            Colour.Width = 50;
            // 
            // colorName
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colorName.DefaultCellStyle = dataGridViewCellStyle5;
            colorName.HeaderText = "Color";
            colorName.MinimumWidth = 6;
            colorName.Name = "colorName";
            colorName.ReadOnly = true;
            // 
            // numberofseates
            // 
            numberofseates.HeaderText = "No. of Seats";
            numberofseates.MinimumWidth = 6;
            numberofseates.Name = "numberofseates";
            numberofseates.ReadOnly = true;
            // 
            // SittingPlan
            // 
            SittingPlan.HeaderText = "Sitting Plan";
            SittingPlan.MinimumWidth = 6;
            SittingPlan.Name = "SittingPlan";
            SittingPlan.ReadOnly = true;
            // 
            // destinationName
            // 
            destinationName.HeaderText = "";
            destinationName.MinimumWidth = 6;
            destinationName.Name = "destinationName";
            destinationName.ReadOnly = true;
            destinationName.Visible = false;
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
            // ViewMore1
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Transparent;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.NullValue = resources.GetObject("dataGridViewCellStyle6.NullValue");
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            ViewMore1.DefaultCellStyle = dataGridViewCellStyle6;
            ViewMore1.HeaderText = "";
            ViewMore1.Image = Properties.Resources.viewMoreImg;
            ViewMore1.MinimumWidth = 6;
            ViewMore1.Name = "ViewMore1";
            ViewMore1.ReadOnly = true;
            ViewMore1.Resizable = DataGridViewTriState.True;
            ViewMore1.ToolTipText = "view more";
            // 
            // modelBusList
            // 
            modelBusList.ColorDepth = ColorDepth.Depth32Bit;
            modelBusList.ImageStream = (ImageListStreamer)resources.GetObject("modelBusList.ImageStream");
            modelBusList.TransparentColor = Color.Transparent;
            modelBusList.Images.SetKeyName(0, "busmodel.png");
            // 
            // statusBusList
            // 
            statusBusList.ColorDepth = ColorDepth.Depth32Bit;
            statusBusList.ImageStream = (ImageListStreamer)resources.GetObject("statusBusList.ImageStream");
            statusBusList.TransparentColor = Color.Transparent;
            statusBusList.Images.SetKeyName(0, "Active.png");
            statusBusList.Images.SetKeyName(1, "Inactive.png");
            // 
            // viewMoreBusList
            // 
            viewMoreBusList.ColorDepth = ColorDepth.Depth32Bit;
            viewMoreBusList.ImageStream = (ImageListStreamer)resources.GetObject("viewMoreBusList.ImageStream");
            viewMoreBusList.TransparentColor = Color.Transparent;
            viewMoreBusList.Images.SetKeyName(0, "viewmore.png");
            viewMoreBusList.Images.SetKeyName(1, "viewMoreImg.png");
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(addBusButton);
            panel1.Controls.Add(busBreadcrumbs);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(homeBreadcrumbs);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1254, 655);
            panel1.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(NextBtn);
            panel3.Controls.Add(BackBtn);
            panel3.Controls.Add(PaginationLbl);
            panel3.Location = new Point(1034, 590);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 57);
            panel3.TabIndex = 19;
            // 
            // NextBtn
            // 
            NextBtn.Anchor = AnchorStyles.Right;
            NextBtn.BackColor = Color.FromArgb(237, 255, 255);
            NextBtn.BackgroundImage = (Image)resources.GetObject("NextBtn.BackgroundImage");
            NextBtn.BackgroundImageLayout = ImageLayout.Center;
            NextBtn.Location = new Point(159, 6);
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
            BackBtn.BorderStyle = BorderStyle.FixedSingle;
            BackBtn.Location = new Point(4, 6);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(45, 45);
            BackBtn.TabIndex = 3;
            BackBtn.Click += BackBtn_Click;
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
            tickButtonPictureBox.Size = new Size(1281, 687);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 30;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.UseWaitCursor = true;
            tickButtonPictureBox.Visible = false;
            // 
            // BusList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1281, 687);
            Controls.Add(panel1);
            Controls.Add(tickButtonPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "BusList";
            Text = "Bus List";
            Load += BusList_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Button addBusButton;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label homeBread;
        private Label busBreadcrumbs;
        private Label homeBreadcrumbs;
        private Label PaginationLbl;
        private ImageList imageList1;
        private ImageList imageList2;
        private DataGridViewButtonColumn Column1;
        private ImageList imageList3;
        private DataGridViewCheckBoxColumn Column7;
        private DataGridViewTextBoxColumn Snumber;
        private DataGridViewTextBoxColumn VechileId;
        private DataGridViewImageColumn Images;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn PlateNumber;
        private DataGridViewTextBoxColumn colorName;
        private DataGridViewTextBoxColumn numberofseates;
        private DataGridViewTextBoxColumn SittingPlan;
        private DataGridViewImageColumn Status;
        private DataGridViewImageColumn ViewMore1;
        private DataGridViewTextBoxColumn Colour;
        private Panel panel1;
        private PictureBox tickButtonPictureBox;
        private DataGridViewButtonColumn newview;
        private ImageList statusBuslist;
        private ImageList statusBusList;
        private ImageList modelBusList;
        private ImageList viewMoreBusList;
        private Panel panel3;
        private Panel NextBtn;
        private Panel BackBtn;
        private Label label4;
        private Panel panel2;
        private Panel panel4;
        private Panel panelGrid;
        private DataGridViewTextBoxColumn qwery;
        private DataGridViewTextBoxColumn destinationName;
    }
}