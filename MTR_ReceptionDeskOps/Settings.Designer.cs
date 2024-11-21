namespace MTRDesktopApplication
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            panel = new Panel();
            panel3 = new Panel();
            pictureBox = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            enabledCheckBoxCash = new PaymentSetting();
            enabledLabelCash = new Label();
            addPaymentBtn = new Button();
            pictureBox1 = new PictureBox();
            homeBreadcrumb = new Label();
            label1 = new Label();
            panel4 = new Panel();
            PaymentOptions = new TabControl();
            tabPage1 = new TabPage();
            StripePanel = new Panel();
            panel9 = new Panel();
            enabledCheckBoxStripe = new PaymentSetting();
            enabledLabelStripe = new Label();
            panelStripeTesting = new Panel();
            stripeTestingKey = new PictureBox();
            labelStripeTestig = new Label();
            checkBox3 = new CheckBox();
            checkBoxStripeTesting = new PaymentSetting();
            panelStripeProduction = new Panel();
            panel12 = new Panel();
            paymentSetting1 = new PaymentSetting();
            label2 = new Label();
            stripeProductionKey = new PictureBox();
            labelStripeProduction = new Label();
            stripeProduction = new PaymentSetting();
            panel6 = new Panel();
            pictureBox2 = new PictureBox();
            panel10 = new Panel();
            panel5 = new Panel();
            enabledCheckBoxSquare = new PaymentSetting();
            enabledLabelSquare = new Label();
            panelSquareTesting = new Panel();
            squareTestingKey = new PictureBox();
            checkBoxSquareTesting = new PaymentSetting();
            labelSquareTesting = new Label();
            checkBox8 = new CheckBox();
            panelSquareProduction = new Panel();
            labelSquareProduction = new Label();
            squareProductionKey = new PictureBox();
            checkBoxSquareProduction = new PaymentSetting();
            checkBox7 = new CheckBox();
            panel11 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            googleApi = new TabPage();
            panelapiKey = new Panel();
            panel18 = new Panel();
            label4 = new Label();
            panelTextBox = new Panel();
            textBoxApiKey = new TextBox();
            Savebutton = new Button();
            panelapiKeyImg = new Panel();
            tickButtonPictureBox = new PictureBox();
            panel2 = new Panel();
            panel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            PaymentOptions.SuspendLayout();
            tabPage1.SuspendLayout();
            StripePanel.SuspendLayout();
            panel9.SuspendLayout();
            panelStripeTesting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stripeTestingKey).BeginInit();
            panelStripeProduction.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stripeProductionKey).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            panelSquareTesting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)squareTestingKey).BeginInit();
            panelSquareProduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)squareProductionKey).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            googleApi.SuspendLayout();
            panelapiKey.SuspendLayout();
            panel18.SuspendLayout();
            panelTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.BackColor = Color.FromArgb(237, 255, 255);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(panel3);
            panel.Controls.Add(panel1);
            panel.Font = new Font("Microsoft Sans Serif", 9F);
            panel.ForeColor = SystemColors.ControlText;
            panel.Location = new Point(69, 28);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(958, 145);
            panel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.AutoSize = true;
            panel3.BackColor = Color.White;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(pictureBox);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 0, 3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 143);
            panel3.TabIndex = 24;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(6, 52);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(41, 39);
            pictureBox.TabIndex = 25;
            pictureBox.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 59);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 0;
            label3.Text = "Pay with Cash";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(enabledCheckBoxCash);
            panel1.Controls.Add(enabledLabelCash);
            panel1.Location = new Point(808, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 115);
            panel1.TabIndex = 23;
            // 
            // enabledCheckBoxCash
            // 
            enabledCheckBoxCash.Anchor = AnchorStyles.Right;
            enabledCheckBoxCash.Location = new Point(39, 52);
            enabledCheckBoxCash.MinimumSize = new Size(45, 23);
            enabledCheckBoxCash.Name = "enabledCheckBoxCash";
            enabledCheckBoxCash.OffBackColor = Color.Gray;
            enabledCheckBoxCash.OffToggleColor = Color.Gainsboro;
            enabledCheckBoxCash.OnBackColor = Color.MediumSpringGreen;
            enabledCheckBoxCash.OnToggleColor = Color.Linen;
            enabledCheckBoxCash.Size = new Size(59, 29);
            enabledCheckBoxCash.SolidColor = true;
            enabledCheckBoxCash.TabIndex = 22;
            enabledCheckBoxCash.UseVisualStyleBackColor = true;
            enabledCheckBoxCash.CheckedChanged += enabledCheckBoxCash_CheckedChanged;
            // 
            // enabledLabelCash
            // 
            enabledLabelCash.Anchor = AnchorStyles.None;
            enabledLabelCash.AutoSize = true;
            enabledLabelCash.BackColor = Color.Transparent;
            enabledLabelCash.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold);
            enabledLabelCash.ForeColor = Color.Gray;
            enabledLabelCash.Location = new Point(24, 17);
            enabledLabelCash.Name = "enabledLabelCash";
            enabledLabelCash.Size = new Size(83, 20);
            enabledLabelCash.TabIndex = 21;
            enabledLabelCash.Text = "Disabled";
            // 
            // addPaymentBtn
            // 
            addPaymentBtn.Anchor = AnchorStyles.None;
            addPaymentBtn.BackColor = Color.FromArgb(0, 214, 220);
            addPaymentBtn.FlatStyle = FlatStyle.Flat;
            addPaymentBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPaymentBtn.ForeColor = Color.White;
            addPaymentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addPaymentBtn.Location = new Point(597, 528);
            addPaymentBtn.Margin = new Padding(3, 4, 3, 4);
            addPaymentBtn.Name = "addPaymentBtn";
            addPaymentBtn.Size = new Size(180, 60);
            addPaymentBtn.TabIndex = 1;
            addPaymentBtn.Text = "Update Settings";
            addPaymentBtn.UseVisualStyleBackColor = false;
            addPaymentBtn.Click += addPaymentBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // homeBreadcrumb
            // 
            homeBreadcrumb.AutoSize = true;
            homeBreadcrumb.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeBreadcrumb.Location = new Point(10, 15);
            homeBreadcrumb.Name = "homeBreadcrumb";
            homeBreadcrumb.Size = new Size(67, 24);
            homeBreadcrumb.TabIndex = 16;
            homeBreadcrumb.Text = "Home";
            homeBreadcrumb.Click += homeBreadcrumb_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 121, 124);
            label1.Location = new Point(113, 15);
            label1.Name = "label1";
            label1.Size = new Size(92, 24);
            label1.TabIndex = 17;
            label1.Text = "Settings";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(PaymentOptions);
            panel4.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(10, 84);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1068, 651);
            panel4.TabIndex = 25;
            // 
            // PaymentOptions
            // 
            PaymentOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PaymentOptions.Controls.Add(tabPage1);
            PaymentOptions.Controls.Add(googleApi);
            PaymentOptions.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentOptions.ItemSize = new Size(115, 30);
            PaymentOptions.Location = new Point(3, 16);
            PaymentOptions.Margin = new Padding(3, 4, 3, 4);
            PaymentOptions.Multiline = true;
            PaymentOptions.Name = "PaymentOptions";
            PaymentOptions.Padding = new Point(20, 5);
            PaymentOptions.SelectedIndex = 0;
            PaymentOptions.Size = new Size(1047, 631);
            PaymentOptions.TabIndex = 27;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.BackgroundImageLayout = ImageLayout.Center;
            tabPage1.Controls.Add(StripePanel);
            tabPage1.Controls.Add(panel10);
            tabPage1.Controls.Add(panel);
            tabPage1.Controls.Add(addPaymentBtn);
            tabPage1.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1039, 593);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Payment Setting";
            // 
            // StripePanel
            // 
            StripePanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StripePanel.AutoSize = true;
            StripePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StripePanel.BackColor = Color.FromArgb(238, 238, 238);
            StripePanel.BorderStyle = BorderStyle.FixedSingle;
            StripePanel.Controls.Add(panel9);
            StripePanel.Controls.Add(panelStripeTesting);
            StripePanel.Controls.Add(panelStripeProduction);
            StripePanel.Controls.Add(panel6);
            StripePanel.Location = new Point(70, 205);
            StripePanel.Margin = new Padding(3, 4, 3, 4);
            StripePanel.Name = "StripePanel";
            StripePanel.Size = new Size(957, 145);
            StripePanel.TabIndex = 25;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Right;
            panel9.BackColor = Color.White;
            panel9.Controls.Add(enabledCheckBoxStripe);
            panel9.Controls.Add(enabledLabelStripe);
            panel9.Location = new Point(806, 12);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(127, 115);
            panel9.TabIndex = 27;
            // 
            // enabledCheckBoxStripe
            // 
            enabledCheckBoxStripe.Anchor = AnchorStyles.Right;
            enabledCheckBoxStripe.Location = new Point(33, 52);
            enabledCheckBoxStripe.MinimumSize = new Size(45, 23);
            enabledCheckBoxStripe.Name = "enabledCheckBoxStripe";
            enabledCheckBoxStripe.OffBackColor = Color.Gray;
            enabledCheckBoxStripe.OffToggleColor = Color.Gainsboro;
            enabledCheckBoxStripe.OnBackColor = Color.MediumSpringGreen;
            enabledCheckBoxStripe.OnToggleColor = Color.Linen;
            enabledCheckBoxStripe.Size = new Size(59, 29);
            enabledCheckBoxStripe.SolidColor = true;
            enabledCheckBoxStripe.TabIndex = 30;
            enabledCheckBoxStripe.UseVisualStyleBackColor = true;
            enabledCheckBoxStripe.CheckedChanged += enabledCheckBoxStripe_CheckedChanged;
            // 
            // enabledLabelStripe
            // 
            enabledLabelStripe.Anchor = AnchorStyles.None;
            enabledLabelStripe.AutoSize = true;
            enabledLabelStripe.BackColor = Color.Transparent;
            enabledLabelStripe.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold);
            enabledLabelStripe.ForeColor = Color.Gray;
            enabledLabelStripe.Location = new Point(27, 17);
            enabledLabelStripe.Name = "enabledLabelStripe";
            enabledLabelStripe.Size = new Size(83, 20);
            enabledLabelStripe.TabIndex = 21;
            enabledLabelStripe.Text = "Disabled";
            // 
            // panelStripeTesting
            // 
            panelStripeTesting.Anchor = AnchorStyles.None;
            panelStripeTesting.BackColor = Color.White;
            panelStripeTesting.Controls.Add(stripeTestingKey);
            panelStripeTesting.Controls.Add(labelStripeTestig);
            panelStripeTesting.Controls.Add(checkBox3);
            panelStripeTesting.Controls.Add(checkBoxStripeTesting);
            panelStripeTesting.Location = new Point(363, 79);
            panelStripeTesting.Margin = new Padding(3, 4, 3, 4);
            panelStripeTesting.Name = "panelStripeTesting";
            panelStripeTesting.Size = new Size(305, 44);
            panelStripeTesting.TabIndex = 24;
            // 
            // stripeTestingKey
            // 
            stripeTestingKey.Anchor = AnchorStyles.None;
            stripeTestingKey.BackColor = Color.White;
            stripeTestingKey.Image = (Image)resources.GetObject("stripeTestingKey.Image");
            stripeTestingKey.Location = new Point(266, 1);
            stripeTestingKey.Margin = new Padding(3, 4, 3, 4);
            stripeTestingKey.Name = "stripeTestingKey";
            stripeTestingKey.Size = new Size(35, 41);
            stripeTestingKey.SizeMode = PictureBoxSizeMode.CenterImage;
            stripeTestingKey.TabIndex = 29;
            stripeTestingKey.TabStop = false;
            stripeTestingKey.Click += stripeTestingKey_Click;
            // 
            // labelStripeTestig
            // 
            labelStripeTestig.Anchor = AnchorStyles.None;
            labelStripeTestig.AutoSize = true;
            labelStripeTestig.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold);
            labelStripeTestig.Location = new Point(112, 13);
            labelStripeTestig.Name = "labelStripeTestig";
            labelStripeTestig.Size = new Size(122, 20);
            labelStripeTestig.TabIndex = 25;
            labelStripeTestig.Text = "Testing Mode";
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.None;
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            checkBox3.Location = new Point(59, -35);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(132, 22);
            checkBox3.TabIndex = 19;
            checkBox3.Text = "Testing Mode";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxStripeTesting
            // 
            checkBoxStripeTesting.Anchor = AnchorStyles.Right;
            checkBoxStripeTesting.Location = new Point(7, 8);
            checkBoxStripeTesting.MinimumSize = new Size(45, 23);
            checkBoxStripeTesting.Name = "checkBoxStripeTesting";
            checkBoxStripeTesting.OffBackColor = Color.Gray;
            checkBoxStripeTesting.OffToggleColor = Color.Gainsboro;
            checkBoxStripeTesting.OnBackColor = Color.MediumSpringGreen;
            checkBoxStripeTesting.OnToggleColor = Color.Linen;
            checkBoxStripeTesting.Size = new Size(59, 29);
            checkBoxStripeTesting.SolidColor = true;
            checkBoxStripeTesting.TabIndex = 28;
            checkBoxStripeTesting.UseVisualStyleBackColor = true;
            // 
            // panelStripeProduction
            // 
            panelStripeProduction.Anchor = AnchorStyles.None;
            panelStripeProduction.BackColor = Color.White;
            panelStripeProduction.Controls.Add(panel12);
            panelStripeProduction.Controls.Add(stripeProductionKey);
            panelStripeProduction.Controls.Add(labelStripeProduction);
            panelStripeProduction.Controls.Add(stripeProduction);
            panelStripeProduction.Location = new Point(363, 19);
            panelStripeProduction.Margin = new Padding(3, 4, 3, 4);
            panelStripeProduction.Name = "panelStripeProduction";
            panelStripeProduction.Size = new Size(305, 44);
            panelStripeProduction.TabIndex = 26;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.None;
            panel12.BackColor = Color.White;
            panel12.Controls.Add(paymentSetting1);
            panel12.Controls.Add(label2);
            panel12.Location = new Point(35, 333);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(213, 44);
            panel12.TabIndex = 27;
            // 
            // paymentSetting1
            // 
            paymentSetting1.Anchor = AnchorStyles.Right;
            paymentSetting1.Checked = true;
            paymentSetting1.CheckState = CheckState.Checked;
            paymentSetting1.Location = new Point(-13, -37);
            paymentSetting1.MinimumSize = new Size(45, 23);
            paymentSetting1.Name = "paymentSetting1";
            paymentSetting1.OffBackColor = Color.Gray;
            paymentSetting1.OffToggleColor = Color.Gainsboro;
            paymentSetting1.OnBackColor = Color.MediumSpringGreen;
            paymentSetting1.OnToggleColor = Color.Linen;
            paymentSetting1.Size = new Size(59, 29);
            paymentSetting1.SolidColor = true;
            paymentSetting1.TabIndex = 31;
            paymentSetting1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label2.Location = new Point(62, -33);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 24;
            label2.Text = "Production Mode";
            // 
            // stripeProductionKey
            // 
            stripeProductionKey.Anchor = AnchorStyles.None;
            stripeProductionKey.BackColor = Color.White;
            stripeProductionKey.Image = (Image)resources.GetObject("stripeProductionKey.Image");
            stripeProductionKey.Location = new Point(266, 1);
            stripeProductionKey.Margin = new Padding(3, 4, 3, 4);
            stripeProductionKey.Name = "stripeProductionKey";
            stripeProductionKey.Size = new Size(35, 41);
            stripeProductionKey.SizeMode = PictureBoxSizeMode.CenterImage;
            stripeProductionKey.TabIndex = 28;
            stripeProductionKey.TabStop = false;
            stripeProductionKey.Click += stripeProductionKey_Click;
            // 
            // labelStripeProduction
            // 
            labelStripeProduction.Anchor = AnchorStyles.None;
            labelStripeProduction.AutoSize = true;
            labelStripeProduction.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold);
            labelStripeProduction.Location = new Point(101, 12);
            labelStripeProduction.Name = "labelStripeProduction";
            labelStripeProduction.Size = new Size(150, 20);
            labelStripeProduction.TabIndex = 24;
            labelStripeProduction.Text = "Production Mode";
            // 
            // stripeProduction
            // 
            stripeProduction.Anchor = AnchorStyles.Right;
            stripeProduction.Location = new Point(3, 7);
            stripeProduction.MinimumSize = new Size(45, 23);
            stripeProduction.Name = "stripeProduction";
            stripeProduction.OffBackColor = Color.Gray;
            stripeProduction.OffToggleColor = Color.Gainsboro;
            stripeProduction.OnBackColor = Color.MediumSpringGreen;
            stripeProduction.OnToggleColor = Color.Linen;
            stripeProduction.Size = new Size(59, 29);
            stripeProduction.SolidColor = true;
            stripeProduction.TabIndex = 31;
            stripeProduction.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Left;
            panel6.BackColor = Color.White;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Controls.Add(pictureBox2);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 0, 3, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(198, 143);
            panel6.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, 44);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel10.AutoSize = true;
            panel10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel10.BackColor = Color.FromArgb(237, 255, 255);
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(panel5);
            panel10.Controls.Add(panelSquareTesting);
            panel10.Controls.Add(panelSquareProduction);
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(69, 380);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(958, 145);
            panel10.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.Controls.Add(enabledCheckBoxSquare);
            panel5.Controls.Add(enabledLabelSquare);
            panel5.Location = new Point(807, 13);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(127, 115);
            panel5.TabIndex = 29;
            // 
            // enabledCheckBoxSquare
            // 
            enabledCheckBoxSquare.Anchor = AnchorStyles.Right;
            enabledCheckBoxSquare.Location = new Point(37, 59);
            enabledCheckBoxSquare.MinimumSize = new Size(45, 23);
            enabledCheckBoxSquare.Name = "enabledCheckBoxSquare";
            enabledCheckBoxSquare.OffBackColor = Color.Gray;
            enabledCheckBoxSquare.OffToggleColor = Color.Gainsboro;
            enabledCheckBoxSquare.OnBackColor = Color.MediumSpringGreen;
            enabledCheckBoxSquare.OnToggleColor = Color.Linen;
            enabledCheckBoxSquare.Size = new Size(59, 29);
            enabledCheckBoxSquare.SolidColor = true;
            enabledCheckBoxSquare.TabIndex = 23;
            enabledCheckBoxSquare.UseVisualStyleBackColor = true;
            enabledCheckBoxSquare.CheckedChanged += enabledCheckBoxSquare_CheckedChanged;
            // 
            // enabledLabelSquare
            // 
            enabledLabelSquare.Anchor = AnchorStyles.None;
            enabledLabelSquare.AutoSize = true;
            enabledLabelSquare.BackColor = Color.Transparent;
            enabledLabelSquare.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold);
            enabledLabelSquare.ForeColor = Color.Gray;
            enabledLabelSquare.Location = new Point(29, 25);
            enabledLabelSquare.Name = "enabledLabelSquare";
            enabledLabelSquare.Size = new Size(83, 20);
            enabledLabelSquare.TabIndex = 21;
            enabledLabelSquare.Text = "Disabled";
            // 
            // panelSquareTesting
            // 
            panelSquareTesting.Anchor = AnchorStyles.None;
            panelSquareTesting.BackColor = Color.White;
            panelSquareTesting.Controls.Add(squareTestingKey);
            panelSquareTesting.Controls.Add(checkBoxSquareTesting);
            panelSquareTesting.Controls.Add(labelSquareTesting);
            panelSquareTesting.Controls.Add(checkBox8);
            panelSquareTesting.Location = new Point(364, 76);
            panelSquareTesting.Margin = new Padding(3, 4, 3, 4);
            panelSquareTesting.Name = "panelSquareTesting";
            panelSquareTesting.Size = new Size(306, 44);
            panelSquareTesting.TabIndex = 28;
            // 
            // squareTestingKey
            // 
            squareTestingKey.Anchor = AnchorStyles.None;
            squareTestingKey.BackColor = Color.White;
            squareTestingKey.Image = (Image)resources.GetObject("squareTestingKey.Image");
            squareTestingKey.Location = new Point(267, 1);
            squareTestingKey.Margin = new Padding(3, 4, 3, 4);
            squareTestingKey.Name = "squareTestingKey";
            squareTestingKey.Size = new Size(35, 41);
            squareTestingKey.SizeMode = PictureBoxSizeMode.CenterImage;
            squareTestingKey.TabIndex = 31;
            squareTestingKey.TabStop = false;
            squareTestingKey.Click += squareTestingKey_Click;
            // 
            // checkBoxSquareTesting
            // 
            checkBoxSquareTesting.Anchor = AnchorStyles.Right;
            checkBoxSquareTesting.Location = new Point(8, 7);
            checkBoxSquareTesting.MinimumSize = new Size(45, 23);
            checkBoxSquareTesting.Name = "checkBoxSquareTesting";
            checkBoxSquareTesting.OffBackColor = Color.Gray;
            checkBoxSquareTesting.OffToggleColor = Color.Gainsboro;
            checkBoxSquareTesting.OnBackColor = Color.MediumSpringGreen;
            checkBoxSquareTesting.OnToggleColor = Color.Linen;
            checkBoxSquareTesting.Size = new Size(59, 29);
            checkBoxSquareTesting.SolidColor = true;
            checkBoxSquareTesting.TabIndex = 29;
            checkBoxSquareTesting.UseVisualStyleBackColor = true;
            // 
            // labelSquareTesting
            // 
            labelSquareTesting.Anchor = AnchorStyles.None;
            labelSquareTesting.AutoSize = true;
            labelSquareTesting.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold);
            labelSquareTesting.Location = new Point(113, 11);
            labelSquareTesting.Name = "labelSquareTesting";
            labelSquareTesting.Size = new Size(122, 20);
            labelSquareTesting.TabIndex = 26;
            labelSquareTesting.Text = "Testing Mode";
            // 
            // checkBox8
            // 
            checkBox8.Anchor = AnchorStyles.None;
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            checkBox8.Location = new Point(53, -80);
            checkBox8.Margin = new Padding(3, 4, 3, 4);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(132, 22);
            checkBox8.TabIndex = 19;
            checkBox8.Text = "Testing Mode";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // panelSquareProduction
            // 
            panelSquareProduction.Anchor = AnchorStyles.None;
            panelSquareProduction.BackColor = Color.White;
            panelSquareProduction.Controls.Add(labelSquareProduction);
            panelSquareProduction.Controls.Add(squareProductionKey);
            panelSquareProduction.Controls.Add(checkBoxSquareProduction);
            panelSquareProduction.Controls.Add(checkBox7);
            panelSquareProduction.Location = new Point(364, 19);
            panelSquareProduction.Margin = new Padding(3, 4, 3, 4);
            panelSquareProduction.Name = "panelSquareProduction";
            panelSquareProduction.Size = new Size(306, 44);
            panelSquareProduction.TabIndex = 27;
            // 
            // labelSquareProduction
            // 
            labelSquareProduction.Anchor = AnchorStyles.None;
            labelSquareProduction.AutoSize = true;
            labelSquareProduction.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold);
            labelSquareProduction.Location = new Point(101, 13);
            labelSquareProduction.Name = "labelSquareProduction";
            labelSquareProduction.Size = new Size(150, 20);
            labelSquareProduction.TabIndex = 25;
            labelSquareProduction.Text = "Production Mode";
            // 
            // squareProductionKey
            // 
            squareProductionKey.Anchor = AnchorStyles.None;
            squareProductionKey.BackColor = Color.White;
            squareProductionKey.Image = (Image)resources.GetObject("squareProductionKey.Image");
            squareProductionKey.Location = new Point(267, 1);
            squareProductionKey.Margin = new Padding(3, 4, 3, 4);
            squareProductionKey.Name = "squareProductionKey";
            squareProductionKey.Size = new Size(35, 41);
            squareProductionKey.SizeMode = PictureBoxSizeMode.CenterImage;
            squareProductionKey.TabIndex = 30;
            squareProductionKey.TabStop = false;
            squareProductionKey.Click += squareProductionKey_Click;
            // 
            // checkBoxSquareProduction
            // 
            checkBoxSquareProduction.Anchor = AnchorStyles.Right;
            checkBoxSquareProduction.Location = new Point(8, 8);
            checkBoxSquareProduction.MinimumSize = new Size(45, 23);
            checkBoxSquareProduction.Name = "checkBoxSquareProduction";
            checkBoxSquareProduction.OffBackColor = Color.Gray;
            checkBoxSquareProduction.OffToggleColor = Color.Gainsboro;
            checkBoxSquareProduction.OnBackColor = Color.MediumSpringGreen;
            checkBoxSquareProduction.OnToggleColor = Color.Linen;
            checkBoxSquareProduction.Size = new Size(59, 29);
            checkBoxSquareProduction.SolidColor = true;
            checkBoxSquareProduction.TabIndex = 30;
            checkBoxSquareProduction.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.Anchor = AnchorStyles.None;
            checkBox7.AutoSize = true;
            checkBox7.Checked = true;
            checkBox7.CheckState = CheckState.Checked;
            checkBox7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            checkBox7.Location = new Point(51, -81);
            checkBox7.Margin = new Padding(3, 4, 3, 4);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(159, 22);
            checkBox7.TabIndex = 18;
            checkBox7.Text = "Production Mode";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Left;
            panel11.BackColor = Color.White;
            panel11.BackgroundImageLayout = ImageLayout.Center;
            panel11.Controls.Add(pictureBox3);
            panel11.Controls.Add(label5);
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(3, 0, 3, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(199, 143);
            panel11.TabIndex = 25;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 49);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 57);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 0;
            label5.Text = "Square";
            // 
            // googleApi
            // 
            googleApi.BackColor = Color.White;
            googleApi.Controls.Add(panelapiKey);
            googleApi.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            googleApi.Location = new Point(4, 34);
            googleApi.Name = "googleApi";
            googleApi.Size = new Size(1039, 593);
            googleApi.TabIndex = 1;
            googleApi.Text = "Api Key Map";
            // 
            // panelapiKey
            // 
            panelapiKey.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelapiKey.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelapiKey.BackColor = Color.FromArgb(237, 255, 255);
            panelapiKey.BorderStyle = BorderStyle.FixedSingle;
            panelapiKey.Controls.Add(panel18);
            panelapiKey.Controls.Add(Savebutton);
            panelapiKey.Controls.Add(panelapiKeyImg);
            panelapiKey.Font = new Font("Microsoft Sans Serif", 9F);
            panelapiKey.ForeColor = SystemColors.ControlText;
            panelapiKey.Location = new Point(239, 76);
            panelapiKey.Margin = new Padding(3, 4, 3, 4);
            panelapiKey.Name = "panelapiKey";
            panelapiKey.Size = new Size(677, 165);
            panelapiKey.TabIndex = 1;
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.None;
            panel18.Controls.Add(label4);
            panel18.Controls.Add(panelTextBox);
            panel18.Location = new Point(158, 16);
            panel18.Name = "panel18";
            panel18.Size = new Size(408, 116);
            panel18.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 8);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 26;
            label4.Text = "Api Key";
            // 
            // panelTextBox
            // 
            panelTextBox.Anchor = AnchorStyles.None;
            panelTextBox.BackColor = Color.FromArgb(249, 249, 249);
            panelTextBox.Controls.Add(textBoxApiKey);
            panelTextBox.Location = new Point(4, 42);
            panelTextBox.Margin = new Padding(3, 4, 3, 4);
            panelTextBox.Name = "panelTextBox";
            panelTextBox.Size = new Size(392, 52);
            panelTextBox.TabIndex = 25;
            // 
            // textBoxApiKey
            // 
            textBoxApiKey.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxApiKey.BackColor = Color.FromArgb(249, 249, 249);
            textBoxApiKey.BorderStyle = BorderStyle.None;
            textBoxApiKey.Cursor = Cursors.IBeam;
            textBoxApiKey.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxApiKey.Location = new Point(14, 17);
            textBoxApiKey.Margin = new Padding(3, 4, 3, 4);
            textBoxApiKey.Name = "textBoxApiKey";
            textBoxApiKey.PlaceholderText = "Add Api key here";
            textBoxApiKey.Size = new Size(372, 22);
            textBoxApiKey.TabIndex = 0;
            textBoxApiKey.TabStop = false;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.Right;
            Savebutton.BackColor = Color.FromArgb(0, 214, 220);
            Savebutton.FlatStyle = FlatStyle.Flat;
            Savebutton.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(514, 55);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(139, 51);
            Savebutton.TabIndex = 55;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // panelapiKeyImg
            // 
            panelapiKeyImg.Anchor = AnchorStyles.Left;
            panelapiKeyImg.AutoSize = true;
            panelapiKeyImg.BackColor = Color.White;
            panelapiKeyImg.BackgroundImage = Properties.Resources.googleApi;
            panelapiKeyImg.BackgroundImageLayout = ImageLayout.Center;
            panelapiKeyImg.Location = new Point(1, 1);
            panelapiKeyImg.Margin = new Padding(3, 0, 3, 0);
            panelapiKeyImg.Name = "panelapiKeyImg";
            panelapiKeyImg.Size = new Size(152, 160);
            panelapiKeyImg.TabIndex = 24;
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
            tickButtonPictureBox.Size = new Size(1096, 739);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 27;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(homeBreadcrumb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(tickButtonPictureBox);
            panel2.Location = new Point(10, 8);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1096, 739);
            panel2.TabIndex = 26;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1110, 757);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Settings";
            Text = "Payment";
            Load += Payment_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            PaymentOptions.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            StripePanel.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panelStripeTesting.ResumeLayout(false);
            panelStripeTesting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stripeTestingKey).EndInit();
            panelStripeProduction.ResumeLayout(false);
            panelStripeProduction.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stripeProductionKey).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel10.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelSquareTesting.ResumeLayout(false);
            panelSquareTesting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)squareTestingKey).EndInit();
            panelSquareProduction.ResumeLayout(false);
            panelSquareProduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)squareProductionKey).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            googleApi.ResumeLayout(false);
            panelapiKey.ResumeLayout(false);
            panelapiKey.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panelTextBox.ResumeLayout(false);
            panelTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Button button1;
        private PictureBox pictureBox1;
        private Label homeBreadcrumb;
        private Label label1;
        private Panel panelProduction;
        private CheckBox testingCheckBox;
        private CheckBox productionCheckBox;
        private Panel panel1;
        private Label enabledLabelCash;
        private Panel panelTesting;
        private RadioButton radioButtonCash;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox;
        private Button addPaymentBtn;
        private Panel panel4;
        private Panel panel5;
        private Panel panel9;
        private Label enabledLabelStripe;
        private Panel panelStripeTesting;
        private CheckBox checkBox3;
        private Panel panelStripeProduction;

        private Panel panel6;
        private PictureBox pictureBox2;
        private Panel StripePanel;
        private Panel panel10;
        private Panel panelSquareTesting;
        private CheckBox checkBox8;
        private Panel panelSquareProduction;
        private CheckBox checkBox7;
        private Panel panel11;
        private PictureBox pictureBox3;
        private Label label5;
        private Label enabledLabelSquare;
        private RadioButton radioButtonSquare;
        private RadioButton radioButtonStripe;
        private Button button2;
        private Panel panel2;
        private PictureBox tickButtonPictureBox;
        private PaymentSetting enabledCheckBoxCash;
        private PaymentSetting checkBoxSquareProduction;
        //private PaymentSetting enabledCheckBoxStripe;
        //private PaymentSetting checkBoxStripeProduction;
        private PaymentSetting enabledCheckBoxSquare;
        private PaymentSetting checkBoxStripeTesting;
        private Label labelStripeProduction;
        private Label labelStripeTestig;
        private PaymentSetting checkBoxSquareTesting;
        private Label labelSquareTesting;
        private Label labelSquareProduction;
        private PaymentSetting enabledCheckBoxStripe;
        private PaymentSetting stripeProduction;
        private Panel panel7;
        private Panel panel15;
        private PaymentSetting paymentSetting6;
        private PaymentSetting paymentSetting5;
        private Label label8;
        private Panel panel13;
        private Label label7;
        private PaymentSetting paymentSetting4;
        private Panel panel14;
        private PaymentSetting apiToggle;
        private Label label6;
        private PaymentSetting paymentSetting3;
        private Panel panel8;
        private Panel panel12;
        private PaymentSetting paymentSetting1;
        private Label label2;
        private Panel panel16;
        private Label label10;
        private PaymentSetting paymentSetting8;
        private Label label9;
        private CheckBox checkBox1;
        private PaymentSetting paymentSetting7;
        private PictureBox stripeTestingKey;
        private PictureBox stripeProductionKey;
        private PictureBox squareTestingKey;
        private PictureBox squareProductionKey;
        private TabControl PaymentOptions;
        private TabPage tabPage1;
        private TabPage googleApi;
        private Panel panelapiKey;
        private Panel panelapiKeyImg;
        private Panel panelapiToggle;
        private Label apiToggleLabel;
        private Panel panel17;
        private TextBox textBoxApiKey;
        private Button Savebutton;
        private Panel panel18;
        private Label label4;
        private Button EditKey;
        private Panel panelTextBox;
    }
}