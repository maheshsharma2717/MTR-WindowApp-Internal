namespace MTRDesktopApplication
{
    partial class BusTiming
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusTiming));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            serialNumber = new DataGridViewTextBoxColumn();
            imageBusModel = new DataGridViewImageColumn();
            modelName = new DataGridViewTextBoxColumn();
            plateNumber = new DataGridViewTextBoxColumn();
            colour = new DataGridViewTextBoxColumn();
            colorName = new DataGridViewTextBoxColumn();
            numberOfSeats = new DataGridViewTextBoxColumn();
            sittingPlan = new DataGridViewTextBoxColumn();
            departureTime = new DataGridViewTextBoxColumn();
            arrivalTime = new DataGridViewTextBoxColumn();
            busById = new DataGridViewTextBoxColumn();
            viewMore = new DataGridViewImageColumn();
            panel3 = new Panel();
            NextBtn = new Panel();
            BackBtn = new Panel();
            labelPagination = new Label();
            label1 = new Label();
            HomebreadCrumb = new Label();
            pictureBox1 = new PictureBox();
            AddBusTiming = new Button();
            imageList1 = new ImageList(components);
            imageListview = new ImageList(components);
            tickButtonPictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(HomebreadCrumb);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(AddBusTiming);
            panel1.Location = new Point(12, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 705);
            panel1.TabIndex = 0;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { serialNumber, imageBusModel, modelName, plateNumber, colour, colorName, numberOfSeats, sittingPlan, departureTime, arrivalTime, busById, viewMore });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(239, 238, 238);
            dataGridViewCellStyle4.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(3, 3, 5, 3);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(239, 238, 238);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(18, 112);
            dataGridView1.Margin = new Padding(3, 13, 3, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(237, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.Height = 55;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.Size = new Size(1107, 494);
            dataGridView1.TabIndex = 24;
            // 
            // serialNumber
            // 
            serialNumber.HeaderText = "S/N";
            serialNumber.MinimumWidth = 6;
            serialNumber.Name = "serialNumber";
            serialNumber.ReadOnly = true;
            // 
            // imageBusModel
            // 
            imageBusModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imageBusModel.HeaderText = "";
            imageBusModel.Image = Properties.Resources.busmodel;
            imageBusModel.MinimumWidth = 6;
            imageBusModel.Name = "imageBusModel";
            imageBusModel.ReadOnly = true;
            imageBusModel.Width = 30;
            // 
            // modelName
            // 
            modelName.HeaderText = "Model";
            modelName.MinimumWidth = 6;
            modelName.Name = "modelName";
            modelName.ReadOnly = true;
            // 
            // plateNumber
            // 
            plateNumber.HeaderText = "Plate Number";
            plateNumber.MinimumWidth = 6;
            plateNumber.Name = "plateNumber";
            plateNumber.ReadOnly = true;
            // 
            // colour
            // 
            colour.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.Transparent;
            dataGridViewCellStyle3.Padding = new Padding(18);
            colour.DefaultCellStyle = dataGridViewCellStyle3;
            colour.HeaderText = "";
            colour.MinimumWidth = 6;
            colour.Name = "colour";
            colour.ReadOnly = true;
            colour.Width = 45;
            // 
            // colorName
            // 
            colorName.HeaderText = "Color";
            colorName.MinimumWidth = 6;
            colorName.Name = "colorName";
            colorName.ReadOnly = true;
            // 
            // numberOfSeats
            // 
            numberOfSeats.HeaderText = "No of Seats Available";
            numberOfSeats.MinimumWidth = 6;
            numberOfSeats.Name = "numberOfSeats";
            numberOfSeats.ReadOnly = true;
            // 
            // sittingPlan
            // 
            sittingPlan.HeaderText = "Sitting Plan";
            sittingPlan.MinimumWidth = 6;
            sittingPlan.Name = "sittingPlan";
            sittingPlan.ReadOnly = true;
            // 
            // departureTime
            // 
            departureTime.HeaderText = "Departure Time";
            departureTime.MinimumWidth = 6;
            departureTime.Name = "departureTime";
            departureTime.ReadOnly = true;
            // 
            // arrivalTime
            // 
            arrivalTime.HeaderText = "Arrival Time";
            arrivalTime.MinimumWidth = 6;
            arrivalTime.Name = "arrivalTime";
            arrivalTime.ReadOnly = true;
            // 
            // busById
            // 
            busById.HeaderText = "";
            busById.MinimumWidth = 6;
            busById.Name = "busById";
            busById.ReadOnly = true;
            // 
            // viewMore
            // 
            viewMore.HeaderText = "";
            viewMore.Image = Properties.Resources.viewMoreImg;
            viewMore.MinimumWidth = 6;
            viewMore.Name = "viewMore";
            viewMore.ReadOnly = true;
            viewMore.ToolTipText = "View More";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(NextBtn);
            panel3.Controls.Add(BackBtn);
            panel3.Controls.Add(labelPagination);
            panel3.Location = new Point(907, 629);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 57);
            panel3.TabIndex = 23;
            // 
            // NextBtn
            // 
            NextBtn.Anchor = AnchorStyles.Right;
            NextBtn.BackColor = Color.FromArgb(237, 255, 255);
            NextBtn.BackgroundImage = (Image)resources.GetObject("NextBtn.BackgroundImage");
            NextBtn.BackgroundImageLayout = ImageLayout.Center;
            NextBtn.Location = new Point(172, 7);
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
            // labelPagination
            // 
            labelPagination.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPagination.AutoSize = true;
            labelPagination.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPagination.ForeColor = Color.FromArgb(125, 125, 125);
            labelPagination.Location = new Point(54, 17);
            labelPagination.Name = "labelPagination";
            labelPagination.Size = new Size(71, 20);
            labelPagination.TabIndex = 7;
            labelPagination.Text = "1 to 100";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 121, 124);
            label1.Location = new Point(120, 25);
            label1.Name = "label1";
            label1.Size = new Size(117, 24);
            label1.TabIndex = 21;
            label1.Text = "Bus Timing";
            // 
            // HomebreadCrumb
            // 
            HomebreadCrumb.AutoSize = true;
            HomebreadCrumb.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            HomebreadCrumb.Location = new Point(19, 24);
            HomebreadCrumb.Name = "HomebreadCrumb";
            HomebreadCrumb.Size = new Size(67, 24);
            HomebreadCrumb.TabIndex = 20;
            HomebreadCrumb.Text = "Home";
            HomebreadCrumb.Click += HomebreadCrumb_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // AddBusTiming
            // 
            AddBusTiming.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddBusTiming.BackColor = Color.FromArgb(0, 214, 220);
            AddBusTiming.BackgroundImageLayout = ImageLayout.Center;
            AddBusTiming.FlatAppearance.BorderSize = 0;
            AddBusTiming.FlatStyle = FlatStyle.Flat;
            AddBusTiming.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBusTiming.ForeColor = Color.White;
            AddBusTiming.Image = (Image)resources.GetObject("AddBusTiming.Image");
            AddBusTiming.Location = new Point(956, 12);
            AddBusTiming.Margin = new Padding(3, 4, 3, 4);
            AddBusTiming.Name = "AddBusTiming";
            AddBusTiming.Size = new Size(180, 60);
            AddBusTiming.TabIndex = 17;
            AddBusTiming.Text = " Add Bus Timing";
            AddBusTiming.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddBusTiming.UseVisualStyleBackColor = false;
            AddBusTiming.Click += AddBusTiming_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "busmodel.png");
            // 
            // imageListview
            // 
            imageListview.ColorDepth = ColorDepth.Depth32Bit;
            imageListview.ImageStream = (ImageListStreamer)resources.GetObject("imageListview.ImageStream");
            imageListview.TransparentColor = Color.Transparent;
            imageListview.Images.SetKeyName(0, "viewmore.png");
            imageListview.Images.SetKeyName(1, "viewMoreImg.png");
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
            tickButtonPictureBox.Size = new Size(1170, 731);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 32;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.UseWaitCursor = true;
            tickButtonPictureBox.Visible = false;
            // 
            // BusTiming
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1170, 731);
            Controls.Add(panel1);
            Controls.Add(tickButtonPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BusTiming";
            Text = "Bus Timing";
            Load += BusTiming_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddBusTiming;
        private Label labelPagination;
        private PictureBox pictureBox1;
        private Label label1;
        private Label HomebreadCrumb;
        private ImageList imageList1;
        private ImageList imageListview;
        private PictureBox tickButtonPictureBox;
        private Panel panel3;
        private Panel NextBtn;
        private Panel BackBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn serialNumber;
        private DataGridViewImageColumn imageBusModel;
        private DataGridViewTextBoxColumn modelName;
        private DataGridViewTextBoxColumn plateNumber;
        private DataGridViewTextBoxColumn colour;
        private DataGridViewTextBoxColumn colorName;
        private DataGridViewTextBoxColumn numberOfSeats;
        private DataGridViewTextBoxColumn sittingPlan;
        private DataGridViewTextBoxColumn departureTime;
        private DataGridViewTextBoxColumn arrivalTime;
        private DataGridViewTextBoxColumn busById;
        private DataGridViewImageColumn viewMore;
        private Button AddBusRoute;
    }
}