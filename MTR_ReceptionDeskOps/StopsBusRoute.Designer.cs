namespace MTRDesktopApplication
{
    partial class StopsBusRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopsBusRoute));
            panelAddWaypoints = new Panel();
            addStop = new Button();
            label7 = new Label();
            Savebutton = new Button();
            close = new Button();
            tickButtonPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelAddWaypoints
            // 
            panelAddWaypoints.Anchor = AnchorStyles.None;
            panelAddWaypoints.AutoScroll = true;
            panelAddWaypoints.BackColor = Color.FromArgb(249, 249, 249);
            panelAddWaypoints.BackgroundImageLayout = ImageLayout.None;
            panelAddWaypoints.Location = new Point(5, 64);
            panelAddWaypoints.Margin = new Padding(3, 4, 3, 4);
            panelAddWaypoints.Name = "panelAddWaypoints";
            panelAddWaypoints.Size = new Size(1176, 339);
            panelAddWaypoints.TabIndex = 54;
            // 
            // addStop
            // 
            addStop.Anchor = AnchorStyles.Top;
            addStop.BackColor = Color.DarkGreen;
            addStop.BackgroundImageLayout = ImageLayout.None;
            addStop.FlatStyle = FlatStyle.Flat;
            addStop.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStop.ForeColor = Color.White;
            addStop.Image = Properties.Resources.add;
            addStop.Location = new Point(1033, 9);
            addStop.Margin = new Padding(3, 4, 3, 4);
            addStop.Name = "addStop";
            addStop.Size = new Size(143, 47);
            addStop.TabIndex = 27;
            addStop.Text = " Add More";
            addStop.TextImageRelation = TextImageRelation.ImageBeforeText;
            addStop.UseVisualStyleBackColor = false;
            addStop.Click += addStop_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(10, 8);
            label7.Name = "label7";
            label7.Size = new Size(979, 50);
            label7.TabIndex = 28;
            label7.Text = "\"Include stops along this route, either by name or by latitude and longitude, to provide additional information about the specific waypoints.\"\n\n";
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.FromArgb(0, 214, 220);
            Savebutton.FlatStyle = FlatStyle.Flat;
            Savebutton.Font = new Font("Inter", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(1031, 410);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(150, 48);
            Savebutton.TabIndex = 55;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // close
            // 
            close.Anchor = AnchorStyles.None;
            close.BackColor = Color.FromArgb(61, 61, 61);
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(857, 410);
            close.Margin = new Padding(3, 4, 3, 4);
            close.Name = "close";
            close.Size = new Size(150, 48);
            close.TabIndex = 58;
            close.Text = "Close";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
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
            tickButtonPictureBox.Size = new Size(1188, 475);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 59;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // StopsBusRoute
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1188, 475);
            Controls.Add(addStop);
            Controls.Add(close);
            Controls.Add(label7);
            Controls.Add(Savebutton);
            Controls.Add(panelAddWaypoints);
            Controls.Add(tickButtonPictureBox);
            Name = "StopsBusRoute";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StopsBusRoute";
            Load += StopsBusRoute_Load;
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelAddWaypoints;
        private Button addStop;
        private Label label7;
        private Button Savebutton;
        private Button close;
        private PictureBox tickButtonPictureBox;
    }
}