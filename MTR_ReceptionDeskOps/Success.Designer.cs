namespace MTRDesktopApplication
{
    partial class Success
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
            Label successLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Success));
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            successLabel = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // successLabel
            // 
            successLabel.Anchor = AnchorStyles.None;
            successLabel.AutoSize = true;
            successLabel.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point);
            successLabel.Location = new Point(128, 171);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(44, 15);
            successLabel.TabIndex = 0;
            successLabel.Text = "Saved";
            successLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 370);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(successLabel);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(89, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 193);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(35, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 165);
            panel2.TabIndex = 0;
            // 
            // Success
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(512, 388);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Success";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Success";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Panel closeButton;
        private Label successLabel;
    }
}