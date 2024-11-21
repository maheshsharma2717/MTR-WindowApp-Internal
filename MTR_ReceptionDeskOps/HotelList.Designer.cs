namespace MTRDesktopApplication
{
    partial class HotelList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelList));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelSearch = new Panel();
            SearchBarHotel = new TextBox();
            SearchButton = new Button();
            panel5 = new Panel();
            panel2 = new Panel();
            NextBtn = new Panel();
            BackBtn = new Panel();
            PaginationLbl = new Label();
            panel4 = new Panel();
            AddHotel = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Home = new Label();
            hotel_List_Main_Layout = new FlowLayoutPanel();
            tickButtonPictureBox = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelSearch.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(hotel_List_Main_Layout);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(11, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 1084);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.97619F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.02381F));
            tableLayoutPanel1.Controls.Add(panelSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(SearchButton, 1, 0);
            tableLayoutPanel1.Location = new Point(127, 112);
            tableLayoutPanel1.Margin = new Padding(3, 3, 3, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1008, 90);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelSearch.BackColor = Color.WhiteSmoke;
            panelSearch.Controls.Add(SearchBarHotel);
            panelSearch.Location = new Point(20, 19);
            panelSearch.Margin = new Padding(20, 4, 3, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(763, 51);
            panelSearch.TabIndex = 45;
            // 
            // SearchBarHotel
            // 
            SearchBarHotel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SearchBarHotel.BackColor = Color.WhiteSmoke;
            SearchBarHotel.BorderStyle = BorderStyle.None;
            SearchBarHotel.Cursor = Cursors.IBeam;
            SearchBarHotel.Font = new Font("Inter", 11F);
            SearchBarHotel.Location = new Point(14, 14);
            SearchBarHotel.Margin = new Padding(35, 4, 3, 4);
            SearchBarHotel.Name = "SearchBarHotel";
            SearchBarHotel.PlaceholderText = "     Search Hotels";
            SearchBarHotel.Size = new Size(738, 23);
            SearchBarHotel.TabIndex = 18;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.None;
            SearchButton.BackColor = Color.FromArgb(255, 159, 180);
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Inter", 9.75F, FontStyle.Bold);
            SearchButton.ForeColor = Color.White;
            SearchButton.Image = Properties.Resources.Search;
            SearchButton.Location = new Point(793, 18);
            SearchButton.Margin = new Padding(3, 4, 35, 4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(175, 53);
            SearchButton.TabIndex = 19;
            SearchButton.Text = "   Search";
            SearchButton.TextAlign = ContentAlignment.MiddleRight;
            SearchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(19, 979);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1355, 69);
            panel5.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(NextBtn);
            panel2.Controls.Add(BackBtn);
            panel2.Controls.Add(PaginationLbl);
            panel2.Location = new Point(1126, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 61);
            panel2.TabIndex = 15;
            panel2.Visible = false;
            // 
            // NextBtn
            // 
            NextBtn.Anchor = AnchorStyles.Right;
            NextBtn.BackColor = Color.FromArgb(237, 255, 255);
            NextBtn.BackgroundImage = (Image)resources.GetObject("NextBtn.BackgroundImage");
            NextBtn.BackgroundImageLayout = ImageLayout.Center;
            NextBtn.Location = new Point(174, 7);
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
            BackBtn.Location = new Point(5, 7);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(45, 45);
            BackBtn.TabIndex = 3;
            BackBtn.Click += BackBtn_Click;
            // 
            // PaginationLbl
            // 
            PaginationLbl.Anchor = AnchorStyles.None;
            PaginationLbl.AutoSize = true;
            PaginationLbl.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaginationLbl.ForeColor = Color.FromArgb(125, 125, 125);
            PaginationLbl.Location = new Point(50, 20);
            PaginationLbl.Name = "PaginationLbl";
            PaginationLbl.Size = new Size(117, 20);
            PaginationLbl.TabIndex = 2;
            PaginationLbl.Text = "Page 1 of 100";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(AddHotel);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(Home);
            panel4.Location = new Point(19, 25);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1254, 80);
            panel4.TabIndex = 16;
            // 
            // AddHotel
            // 
            AddHotel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddHotel.BackColor = Color.FromArgb(0, 214, 220);
            AddHotel.BackgroundImageLayout = ImageLayout.Center;
            AddHotel.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddHotel.ForeColor = Color.White;
            AddHotel.Image = (Image)resources.GetObject("AddHotel.Image");
            AddHotel.ImageAlign = ContentAlignment.MiddleRight;
            AddHotel.Location = new Point(1087, 6);
            AddHotel.Margin = new Padding(3, 4, 34, 4);
            AddHotel.Name = "AddHotel";
            AddHotel.RightToLeft = RightToLeft.No;
            AddHotel.Size = new Size(167, 60);
            AddHotel.TabIndex = 13;
            AddHotel.Text = "   Add Hotel";
            AddHotel.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddHotel.UseVisualStyleBackColor = false;
            AddHotel.Click += AddHotel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 121, 124);
            label2.Location = new Point(108, 27);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 9;
            label2.Text = "Hotel List";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 27);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            Home.ForeColor = Color.FromArgb(37, 37, 37);
            Home.Location = new Point(13, 27);
            Home.Name = "Home";
            Home.Size = new Size(67, 24);
            Home.TabIndex = 8;
            Home.Text = "Home";
            Home.Click += Home_Click;
            // 
            // hotel_List_Main_Layout
            // 
            hotel_List_Main_Layout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hotel_List_Main_Layout.AutoScroll = true;
            hotel_List_Main_Layout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hotel_List_Main_Layout.Font = new Font("Microsoft Sans Serif", 9F);
            hotel_List_Main_Layout.Location = new Point(19, 217);
            hotel_List_Main_Layout.Margin = new Padding(3, 4, 3, 4);
            hotel_List_Main_Layout.Name = "hotel_List_Main_Layout";
            hotel_List_Main_Layout.Size = new Size(1354, 814);
            hotel_List_Main_Layout.TabIndex = 14;
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
            tickButtonPictureBox.Size = new Size(1417, 1100);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 29;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.UseWaitCursor = true;
            tickButtonPictureBox.Visible = false;
            // 
            // HotelList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1417, 1100);
            Controls.Add(panel1);
            Controls.Add(tickButtonPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HotelList";
            Text = "Hotel List";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button AddHotel;
        private FlowLayoutPanel hotel_List_Main_Layout;
        private Label label7;
        private Label Home;
        private Panel panel2;
        private Label PeginationLbl;
        private Label PaginationLbl;
        private PictureBox tickButtonPictureBox;
        private Panel panel3;
        private Panel BackBtn;
        private Panel NextBtn;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelSearch;
        private TextBox SearchBarBusRoute;
        private Button SearchButton;
        private TextBox SearchBarHotel;
    }
}