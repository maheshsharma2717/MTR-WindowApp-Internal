namespace MTRDesktopApplication
{
    partial class MainLayoutScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLayoutScreen));
            panel1 = new Panel();
            ScreenLabel = new Label();
            NavigationPanel = new Panel();
            tickButtonPictureBox = new PictureBox();
            panel2 = new Panel();
            panel13 = new Panel();
            statusLbl = new Label();
            welcomeLbl = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            logOutBtn = new Panel();
            fontDialog1 = new FontDialog();
            panel1.SuspendLayout();
            NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            panel2.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ScreenLabel);
            panel1.Controls.Add(NavigationPanel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 940);
            panel1.TabIndex = 0;
            // 
            // ScreenLabel
            // 
            ScreenLabel.AutoSize = true;
            ScreenLabel.Font = new Font("Inter", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScreenLabel.ForeColor = Color.FromArgb(0, 121, 124);
            ScreenLabel.Location = new Point(298, 152);
            ScreenLabel.Name = "ScreenLabel";
            ScreenLabel.Size = new Size(58, 20);
            ScreenLabel.TabIndex = 4;
            ScreenLabel.Text = "Home";
            // 
            // NavigationPanel
            // 
            NavigationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NavigationPanel.BackColor = Color.Transparent;
            NavigationPanel.Controls.Add(tickButtonPictureBox);
            NavigationPanel.Location = new Point(278, 193);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(867, 699);
            NavigationPanel.TabIndex = 5;
            // 
            // tickButtonPictureBox
            // 
            tickButtonPictureBox.Anchor = AnchorStyles.None;
            tickButtonPictureBox.BackColor = Color.Transparent;
            tickButtonPictureBox.Image = (Image)resources.GetObject("tickButtonPictureBox.Image");
            tickButtonPictureBox.Location = new Point(295, 289);
            tickButtonPictureBox.Margin = new Padding(3, 4, 3, 4);
            tickButtonPictureBox.Name = "tickButtonPictureBox";
            tickButtonPictureBox.Size = new Size(249, 85);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            tickButtonPictureBox.TabIndex = 0;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(249, 249, 249);
            panel2.Controls.Add(panel13);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(37, 28);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 92);
            panel2.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Right;
            panel13.Controls.Add(statusLbl);
            panel13.Controls.Add(welcomeLbl);
            panel13.Location = new Point(710, 21);
            panel13.Name = "panel13";
            panel13.Size = new Size(388, 47);
            panel13.TabIndex = 0;
            // 
            // statusLbl
            // 
            statusLbl.Anchor = AnchorStyles.Left;
            statusLbl.AutoSize = true;
            statusLbl.Font = new Font("Inter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLbl.Location = new Point(3, 7);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(151, 28);
            statusLbl.TabIndex = 6;
            statusLbl.Text = "Admin Panel";
            // 
            // welcomeLbl
            // 
            welcomeLbl.Anchor = AnchorStyles.Right;
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Inter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.Location = new Point(220, 8);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(151, 28);
            welcomeLbl.TabIndex = 5;
            welcomeLbl.Text = "Admin Panel";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(469, 27);
            label1.Name = "label1";
            label1.Size = new Size(197, 36);
            label1.TabIndex = 4;
            label1.Text = "Admin Panel";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(43, 21);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 47);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(logOutBtn);
            panel3.Location = new Point(37, 193);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 587);
            panel3.TabIndex = 2;
            // 
            // logOutBtn
            // 
            logOutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logOutBtn.BackColor = Color.FromArgb(246, 246, 246);
            logOutBtn.BackgroundImage = (Image)resources.GetObject("logOutBtn.BackgroundImage");
            logOutBtn.BackgroundImageLayout = ImageLayout.Center;
            logOutBtn.Font = new Font("Inter", 9F);
            logOutBtn.Location = new Point(9, 484);
            logOutBtn.Margin = new Padding(3, 4, 3, 4);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(182, 52);
            logOutBtn.TabIndex = 2;
            logOutBtn.Click += logOutBtn_Click;
            logOutBtn.Paint += logOutBtn_Paint;
            // 
            // MainLayoutScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1183, 940);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainLayoutScreen";
            WindowState = FormWindowState.Maximized;
            Load += MainLayoutScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            NavigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private Label label9;
        private Panel NavigationPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label welcomeLbl;
        private Panel panel8;
        private Label label6;
        private PictureBox pictureBox6;
        private Panel panel5;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel panel6;
        private Label label4;
        private PictureBox pictureBox4;
        private Panel panel7;
        private Label label5;
        private PictureBox pictureBox5;
        private Panel panel9;
        private Label label7;
        private PictureBox pictureBox7;
        private Panel panel10;
        private Label label8;
        private PictureBox pictureBox8;
        private Button logOut;
        private Label ScreenLabel;
        private PictureBox tickButtonPictureBox;
        private Panel HideShowPanel;
        private FontDialog fontDialog1;
        private Panel logOutBtn;
        private Panel panel13;
        private Label statusLbl;
    }
}