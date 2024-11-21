namespace MTRDesktopApplication
{
    partial class BusRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusRoute));
            AddBusRoute = new Button();
            SearchBarBusRoute = new TextBox();
            SearchButton = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelSearch = new Panel();
            panel3 = new Panel();
            busRouteBred = new Label();
            HomeBreadcrumb = new Label();
            pictureBox1 = new PictureBox();
            mainPanelBusRoute = new Panel();
            tickButtonPictureBox = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelSearch.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // AddBusRoute
            // 
            AddBusRoute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddBusRoute.BackColor = Color.FromArgb(0, 214, 220);
            AddBusRoute.BackgroundImageLayout = ImageLayout.Center;
            AddBusRoute.Font = new Font("Inter", 9F, FontStyle.Bold);
            AddBusRoute.ForeColor = Color.White;
            AddBusRoute.Image = (Image)resources.GetObject("AddBusRoute.Image");
            AddBusRoute.Location = new Point(594, 12);
            AddBusRoute.Margin = new Padding(3, 4, 3, 4);
            AddBusRoute.Name = "AddBusRoute";
            AddBusRoute.Size = new Size(180, 60);
            AddBusRoute.TabIndex = 17;
            AddBusRoute.Text = "    Add Bus Route";
            AddBusRoute.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddBusRoute.UseVisualStyleBackColor = false;
            AddBusRoute.Click += AddBusRoute_Click_1;
            // 
            // SearchBarBusRoute
            // 
            SearchBarBusRoute.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SearchBarBusRoute.BackColor = Color.WhiteSmoke;
            SearchBarBusRoute.BorderStyle = BorderStyle.None;
            SearchBarBusRoute.Cursor = Cursors.IBeam;
            SearchBarBusRoute.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBarBusRoute.Location = new Point(10, 15);
            SearchBarBusRoute.Margin = new Padding(35, 4, 3, 4);
            SearchBarBusRoute.Name = "SearchBarBusRoute";
            SearchBarBusRoute.PlaceholderText = "     Search Bus Route";
            SearchBarBusRoute.Size = new Size(491, 22);
            SearchBarBusRoute.TabIndex = 18;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Left;
            SearchButton.BackColor = Color.FromArgb(255, 159, 180);
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Inter", 9.75F, FontStyle.Bold);
            SearchButton.ForeColor = Color.White;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(530, 4);
            SearchButton.Margin = new Padding(3, 4, 35, 4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(159, 53);
            SearchButton.TabIndex = 19;
            SearchButton.Text = "   Search";
            SearchButton.TextAlign = ContentAlignment.MiddleRight;
            SearchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(mainPanelBusRoute);
            panel1.Controls.Add(tickButtonPictureBox);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 672);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.4137955F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5862064F));
            tableLayoutPanel1.Controls.Add(panelSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(SearchButton, 1, 0);
            tableLayoutPanel1.Location = new Point(141, 128);
            tableLayoutPanel1.Margin = new Padding(3, 3, 3, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(728, 62);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelSearch.BackColor = Color.WhiteSmoke;
            panelSearch.Controls.Add(SearchBarBusRoute);
            panelSearch.Location = new Point(20, 6);
            panelSearch.Margin = new Padding(20, 4, 3, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(504, 49);
            panelSearch.TabIndex = 45;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(busRouteBred);
            panel3.Controls.Add(HomeBreadcrumb);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(AddBusRoute);
            panel3.Location = new Point(3, 3);
            panel3.Margin = new Padding(30, 3, 3, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(30, 0, 30, 0);
            panel3.Size = new Size(829, 87);
            panel3.TabIndex = 47;
            // 
            // busRouteBred
            // 
            busRouteBred.AutoSize = true;
            busRouteBred.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            busRouteBred.ForeColor = Color.FromArgb(0, 121, 124);
            busRouteBred.Location = new Point(117, 33);
            busRouteBred.Name = "busRouteBred";
            busRouteBred.Size = new Size(113, 24);
            busRouteBred.TabIndex = 45;
            busRouteBred.Text = " Bus Route";
            // 
            // HomeBreadcrumb
            // 
            HomeBreadcrumb.AutoSize = true;
            HomeBreadcrumb.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            HomeBreadcrumb.Location = new Point(16, 33);
            HomeBreadcrumb.Name = "HomeBreadcrumb";
            HomeBreadcrumb.Size = new Size(67, 24);
            HomeBreadcrumb.TabIndex = 43;
            HomeBreadcrumb.Text = "Home";
            HomeBreadcrumb.Click += HomeBreadcrumb_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // mainPanelBusRoute
            // 
            mainPanelBusRoute.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanelBusRoute.AutoScroll = true;
            mainPanelBusRoute.Location = new Point(38, 193);
            mainPanelBusRoute.Margin = new Padding(3, 0, 3, 4);
            mainPanelBusRoute.Name = "mainPanelBusRoute";
            mainPanelBusRoute.Size = new Size(937, 421);
            mainPanelBusRoute.TabIndex = 20;
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
            tickButtonPictureBox.Size = new Size(992, 672);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 46;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.UseWaitCursor = true;
            tickButtonPictureBox.Visible = false;
            // 
            // BusRoute
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1016, 696);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BusRoute";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bus Route";
            Load += BusRoute_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddBusRoute;
        private TextBox textBox1;
        private Button button1;
        private RadioButton radioButton1;
        private Label Hospital;
        private TextBox textBox2;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBox3;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox pictureBox3;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox textBox4;
        private Button button4;
        private Label label3;
        private ListBox listBox1;
        private TextBox textBox5;
        private PictureBox pictureBox4;
        private Button SearchButton;
        private TextBox SearchBarBusRoute;
        private Panel panel;
        private PictureBox pictureBox1;
        private Label HomeBreadcrumb;
        private Panel mainPanelBusRoute;
        private Panel panelSearch;
        private PictureBox tickButtonPictureBox;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBox2;
        private PictureBox pictureBox5;
        private Label label4;
        private Label busRouteBreadcrumb;
        private Label busRouteBred;
    }
}