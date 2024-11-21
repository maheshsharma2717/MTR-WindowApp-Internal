namespace MTRDesktopApplication {
    partial class CustomToggle {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomToggle));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            ToggleOuter = new Panel();
            paymentSetting3 = new PaymentSetting();
            label5 = new Label();
            label4 = new Label();
            paymentSetting2 = new PaymentSetting();
            ProductMode = new Label();
            paymentSetting1 = new PaymentSetting();
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ToggleOuter.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 18;
            label1.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(14, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(249, 249, 249);
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 118, 125);
            label2.Location = new Point(93, 16);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 20;
            label2.Text = "CustomToggle\r\n";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(237, 255, 255);
            panel2.Controls.Add(ToggleOuter);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(52, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 138);
            panel2.TabIndex = 21;
            // 
            // ToggleOuter
            // 
            ToggleOuter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ToggleOuter.Controls.Add(paymentSetting3);
            ToggleOuter.Controls.Add(label5);
            ToggleOuter.Controls.Add(label4);
            ToggleOuter.Controls.Add(paymentSetting2);
            ToggleOuter.Controls.Add(ProductMode);
            ToggleOuter.Controls.Add(paymentSetting1);
            ToggleOuter.Location = new Point(182, 3);
            ToggleOuter.Name = "ToggleOuter";
            ToggleOuter.Size = new Size(710, 132);
            ToggleOuter.TabIndex = 1;
            // 
            // paymentSetting3
            // 
            paymentSetting3.Anchor = AnchorStyles.Right;
            paymentSetting3.Checked = true;
            paymentSetting3.CheckState = CheckState.Checked;
            paymentSetting3.Location = new Point(560, 70);
            paymentSetting3.MinimumSize = new Size(45, 23);
            paymentSetting3.Name = "paymentSetting3";
            paymentSetting3.OffBackColor = Color.Gray;
            paymentSetting3.OffToggleColor = Color.Gainsboro;
            paymentSetting3.OnBackColor = Color.MediumSpringGreen;
            paymentSetting3.OnToggleColor = Color.Linen;
            paymentSetting3.Size = new Size(59, 29);
            paymentSetting3.SolidColor = true;
            paymentSetting3.TabIndex = 5;
            paymentSetting3.Text = "paymentSetting3";
            paymentSetting3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(543, 14);
            label5.Name = "label5";
            label5.Size = new Size(99, 105);
            label5.TabIndex = 4;
            label5.Text = "Enabled";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(121, 70);
            label4.Name = "label4";
            label4.Size = new Size(210, 37);
            label4.TabIndex = 3;
            label4.Text = "Testing Mode";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paymentSetting2
            // 
            paymentSetting2.Anchor = AnchorStyles.None;
            paymentSetting2.Location = new Point(358, 75);
            paymentSetting2.MinimumSize = new Size(45, 23);
            paymentSetting2.Name = "paymentSetting2";
            paymentSetting2.OffBackColor = Color.Gray;
            paymentSetting2.OffToggleColor = Color.Gainsboro;
            paymentSetting2.OnBackColor = Color.MediumSpringGreen;
            paymentSetting2.OnToggleColor = Color.Linen;
            paymentSetting2.Size = new Size(59, 29);
            paymentSetting2.SolidColor = true;
            paymentSetting2.TabIndex = 2;
            paymentSetting2.Text = "paymentSetting2";
            paymentSetting2.UseVisualStyleBackColor = true;
            // 
            // ProductMode
            // 
            ProductMode.Anchor = AnchorStyles.None;
            ProductMode.BackColor = Color.White;
            ProductMode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductMode.Location = new Point(121, 14);
            ProductMode.Name = "ProductMode";
            ProductMode.Size = new Size(210, 37);
            ProductMode.TabIndex = 1;
            ProductMode.Text = "Product Mode";
            ProductMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paymentSetting1
            // 
            paymentSetting1.Anchor = AnchorStyles.None;
            paymentSetting1.Checked = true;
            paymentSetting1.CheckState = CheckState.Checked;
            paymentSetting1.Location = new Point(358, 19);
            paymentSetting1.MinimumSize = new Size(45, 23);
            paymentSetting1.Name = "paymentSetting1";
            paymentSetting1.OffBackColor = Color.Gray;
            paymentSetting1.OffToggleColor = Color.Gainsboro;
            paymentSetting1.OnBackColor = Color.MediumSpringGreen;
            paymentSetting1.OnToggleColor = Color.Linen;
            paymentSetting1.Size = new Size(59, 29);
            paymentSetting1.SolidColor = true;
            paymentSetting1.TabIndex = 0;
            paymentSetting1.Text = "paymentSetting1";
            paymentSetting1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 132);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(27, 92);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 0;
            label3.Text = "Pay with Cash";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 601);
            panel1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Left;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(29, 238);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 22;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // CustomToggle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 624);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomToggle";
            Text = "PaymentSettings";
            Load += PaymentSettings_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ToggleOuter.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Panel panel1;
        private RadioButton radioButton1;
        private Panel panel3;
        private Label label3;
        private Panel ToggleOuter;
        private PaymentSetting paymentSetting1;
        private Label ProductMode;
        private Label label4;
        private PaymentSetting paymentSetting2;
        private PaymentSetting paymentSetting3;
        private Label label5;
    }
}