namespace MTRDesktopApplication
{
    partial class paymentKeySquare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentKeySquare));
            outerPanel = new Panel();
            panel3 = new Panel();
            textBoxPublicKey = new TextBox();
            panel2 = new Panel();
            textBoxSecretKey = new TextBox();
            labelPublicKeyError = new Label();
            labelSecretKeyError = new Label();
            CloseBtn = new Button();
            addKeyBtn = new Button();
            publicKeyLabel = new Label();
            labelProduction = new Label();
            secretKeyLabel = new Label();
            panelPopupSquareImg = new Panel();
            pictureBox = new PictureBox();
            paymentType = new Label();
            tickButtonPictureBox = new PictureBox();
            outerPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panelPopupSquareImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // outerPanel
            // 
            outerPanel.BorderStyle = BorderStyle.FixedSingle;
            outerPanel.Controls.Add(panel3);
            outerPanel.Controls.Add(panel2);
            outerPanel.Controls.Add(labelPublicKeyError);
            outerPanel.Controls.Add(labelSecretKeyError);
            outerPanel.Controls.Add(CloseBtn);
            outerPanel.Controls.Add(addKeyBtn);
            outerPanel.Controls.Add(publicKeyLabel);
            outerPanel.Controls.Add(labelProduction);
            outerPanel.Controls.Add(secretKeyLabel);
            outerPanel.Controls.Add(panelPopupSquareImg);
            outerPanel.Controls.Add(tickButtonPictureBox);
            outerPanel.Dock = DockStyle.Fill;
            outerPanel.Location = new Point(0, 0);
            outerPanel.Margin = new Padding(3, 4, 3, 4);
            outerPanel.Name = "outerPanel";
            outerPanel.Size = new Size(553, 457);
            outerPanel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxPublicKey);
            panel3.Location = new Point(120, 283);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 43);
            panel3.TabIndex = 38;
            // 
            // textBoxPublicKey
            // 
            textBoxPublicKey.Anchor = AnchorStyles.None;
            textBoxPublicKey.BorderStyle = BorderStyle.None;
            textBoxPublicKey.Font = new Font("Inter", 11.249999F);
            textBoxPublicKey.Location = new Point(6, 9);
            textBoxPublicKey.Margin = new Padding(3, 4, 3, 4);
            textBoxPublicKey.Multiline = true;
            textBoxPublicKey.Name = "textBoxPublicKey";
            textBoxPublicKey.Size = new Size(294, 25);
            textBoxPublicKey.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxSecretKey);
            panel2.Location = new Point(120, 185);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 43);
            panel2.TabIndex = 37;
            // 
            // textBoxSecretKey
            // 
            textBoxSecretKey.Anchor = AnchorStyles.None;
            textBoxSecretKey.BorderStyle = BorderStyle.None;
            textBoxSecretKey.Font = new Font("Inter", 11.249999F);
            textBoxSecretKey.Location = new Point(6, 9);
            textBoxSecretKey.Margin = new Padding(3, 4, 3, 4);
            textBoxSecretKey.Name = "textBoxSecretKey";
            textBoxSecretKey.Size = new Size(294, 23);
            textBoxSecretKey.TabIndex = 28;
            // 
            // labelPublicKeyError
            // 
            labelPublicKeyError.Anchor = AnchorStyles.None;
            labelPublicKeyError.AutoSize = true;
            labelPublicKeyError.Font = new Font("Inter", 9F);
            labelPublicKeyError.ForeColor = Color.Red;
            labelPublicKeyError.Location = new Point(120, 325);
            labelPublicKeyError.Name = "labelPublicKeyError";
            labelPublicKeyError.Size = new Size(114, 19);
            labelPublicKeyError.TabIndex = 36;
            labelPublicKeyError.Text = "publicKeyError";
            labelPublicKeyError.Visible = false;
            // 
            // labelSecretKeyError
            // 
            labelSecretKeyError.Anchor = AnchorStyles.None;
            labelSecretKeyError.AutoSize = true;
            labelSecretKeyError.Font = new Font("Inter", 9F);
            labelSecretKeyError.ForeColor = Color.Red;
            labelSecretKeyError.Location = new Point(120, 232);
            labelSecretKeyError.Name = "labelSecretKeyError";
            labelSecretKeyError.Size = new Size(116, 19);
            labelSecretKeyError.TabIndex = 35;
            labelSecretKeyError.Text = "secretKeyError";
            labelSecretKeyError.Visible = false;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.White;
            CloseBtn.BackgroundImageLayout = ImageLayout.None;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Inter", 14.25F, FontStyle.Bold);
            CloseBtn.ForeColor = Color.Black;
            CloseBtn.Location = new Point(3, 5);
            CloseBtn.Margin = new Padding(3, 4, 3, 4);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(57, 45);
            CloseBtn.TabIndex = 33;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // addKeyBtn
            // 
            addKeyBtn.Anchor = AnchorStyles.None;
            addKeyBtn.BackColor = Color.FromArgb(0, 214, 220);
            addKeyBtn.FlatStyle = FlatStyle.Flat;
            addKeyBtn.Font = new Font("Inter", 9F, FontStyle.Bold);
            addKeyBtn.ForeColor = Color.White;
            addKeyBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addKeyBtn.Location = new Point(120, 352);
            addKeyBtn.Margin = new Padding(3, 4, 3, 4);
            addKeyBtn.Name = "addKeyBtn";
            addKeyBtn.Size = new Size(303, 45);
            addKeyBtn.TabIndex = 32;
            addKeyBtn.Text = "Add Key";
            addKeyBtn.UseVisualStyleBackColor = false;
            addKeyBtn.Click += addKeyBtn_Click;
            // 
            // publicKeyLabel
            // 
            publicKeyLabel.Anchor = AnchorStyles.None;
            publicKeyLabel.AutoSize = true;
            publicKeyLabel.Font = new Font("Inter", 9.75F, FontStyle.Bold);
            publicKeyLabel.Location = new Point(120, 257);
            publicKeyLabel.Name = "publicKeyLabel";
            publicKeyLabel.Size = new Size(97, 20);
            publicKeyLabel.TabIndex = 31;
            publicKeyLabel.Text = "Public Key";
            // 
            // labelProduction
            // 
            labelProduction.Anchor = AnchorStyles.None;
            labelProduction.AutoSize = true;
            labelProduction.Font = new Font("Inter", 12F, FontStyle.Bold);
            labelProduction.Location = new Point(169, 116);
            labelProduction.Name = "labelProduction";
            labelProduction.Size = new Size(177, 24);
            labelProduction.TabIndex = 29;
            labelProduction.Text = "Production Mode";
            // 
            // secretKeyLabel
            // 
            secretKeyLabel.Anchor = AnchorStyles.None;
            secretKeyLabel.AutoSize = true;
            secretKeyLabel.Font = new Font("Inter", 9.75F, FontStyle.Bold);
            secretKeyLabel.Location = new Point(121, 160);
            secretKeyLabel.Name = "secretKeyLabel";
            secretKeyLabel.Size = new Size(98, 20);
            secretKeyLabel.TabIndex = 27;
            secretKeyLabel.Text = "Secret key";
            // 
            // panelPopupSquareImg
            // 
            panelPopupSquareImg.Anchor = AnchorStyles.Top;
            panelPopupSquareImg.BackColor = Color.Transparent;
            panelPopupSquareImg.BackgroundImageLayout = ImageLayout.Center;
            panelPopupSquareImg.Controls.Add(pictureBox);
            panelPopupSquareImg.Controls.Add(paymentType);
            panelPopupSquareImg.Location = new Point(137, 5);
            panelPopupSquareImg.Name = "panelPopupSquareImg";
            panelPopupSquareImg.Size = new Size(208, 72);
            panelPopupSquareImg.TabIndex = 26;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(37, 16);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(41, 39);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 25;
            pictureBox.TabStop = false;
            // 
            // paymentType
            // 
            paymentType.Anchor = AnchorStyles.None;
            paymentType.AutoSize = true;
            paymentType.Font = new Font("Inter", 14.25F, FontStyle.Bold);
            paymentType.Location = new Point(106, 19);
            paymentType.Name = "paymentType";
            paymentType.Size = new Size(71, 29);
            paymentType.TabIndex = 0;
            paymentType.Text = "Type";
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
            tickButtonPictureBox.Size = new Size(551, 455);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 34;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // paymentKeySquare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(553, 457);
            Controls.Add(outerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "paymentKeySquare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "paymentKeySquare";
            TopMost = true;
            Load += paymentKeySquare_Load;
            outerPanel.ResumeLayout(false);
            outerPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelPopupSquareImg.ResumeLayout(false);
            panelPopupSquareImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel outerPanel;
        private TextBox textBoxSecretKey;
        private Label secretKeyLabel;
        private Panel panelPopupSquareImg;
        private PictureBox pictureBox3;
        private Label label5;
        private TextBox textBoxPublicKey;
        private Label publicKeyLabel;
        private Button addKeyBtn;
        private Button CloseBtn;
        public Label labelProduction;
        public Label paymentType;
        public PictureBox pictureBox;
        private PictureBox tickButtonPictureBox;
        private Label labelPublicKeyError;
        private Label labelSecretKeyError;
        private Panel panel3;
        private Panel panel2;
    }
}