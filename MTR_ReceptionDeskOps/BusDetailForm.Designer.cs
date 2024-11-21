namespace MTRDesktopApplication
{
    partial class BusDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusDetailForm));
            panel1 = new Panel();
            addBusButton = new Button();
            Bredcrumb = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            homeBreadcrumbs = new Label();
            busListBreadcrumbs = new Label();
            label1 = new Label();
            panelBusDetails = new Panel();
            BusR = new Label();
            colorPanel = new Panel();
            SittingPlan = new Label();
            NoOfSeats = new Label();
            Colour = new Label();
            PlateNo = new Label();
            CostPerSeats = new Label();
            BusRouteLabel = new Label();
            SeatingPlanLabel = new Label();
            SeatNoLabel = new Label();
            busNameLabel = new Label();
            platenoLabel = new Label();
            deletebutton = new Button();
            editBusDetail = new Button();
            pictureBox = new PictureBox();
            tickButtonPictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelBusDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(addBusButton);
            panel1.Controls.Add(Bredcrumb);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(homeBreadcrumbs);
            panel1.Controls.Add(busListBreadcrumbs);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panelBusDetails);
            panel1.Controls.Add(tickButtonPictureBox);
            panel1.Location = new Point(0, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 787);
            panel1.TabIndex = 0;
            // 
            // addBusButton
            // 
            addBusButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addBusButton.BackColor = Color.FromArgb(0, 214, 220);
            addBusButton.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBusButton.ForeColor = Color.White;
            addBusButton.Image = (Image)resources.GetObject("addBusButton.Image");
            addBusButton.Location = new Point(944, 24);
            addBusButton.Name = "addBusButton";
            addBusButton.Size = new Size(167, 60);
            addBusButton.TabIndex = 29;
            addBusButton.Text = "    Add Bus";
            addBusButton.TextAlign = ContentAlignment.MiddleRight;
            addBusButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addBusButton.UseVisualStyleBackColor = false;
            addBusButton.Click += addBusButton_Click;
            // 
            // Bredcrumb
            // 
            Bredcrumb.AutoSize = true;
            Bredcrumb.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            Bredcrumb.ForeColor = Color.FromArgb(0, 121, 124);
            Bredcrumb.Location = new Point(244, 41);
            Bredcrumb.Name = "Bredcrumb";
            Bredcrumb.Size = new Size(115, 24);
            Bredcrumb.TabIndex = 26;
            Bredcrumb.Text = "PageName";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(217, 41);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(95, 41);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // homeBreadcrumbs
            // 
            homeBreadcrumbs.AutoSize = true;
            homeBreadcrumbs.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            homeBreadcrumbs.ForeColor = Color.Black;
            homeBreadcrumbs.Location = new Point(23, 41);
            homeBreadcrumbs.Name = "homeBreadcrumbs";
            homeBreadcrumbs.Size = new Size(67, 24);
            homeBreadcrumbs.TabIndex = 23;
            homeBreadcrumbs.Text = "Home";
            homeBreadcrumbs.Click += homeBreadcrumbs_Click;
            // 
            // busListBreadcrumbs
            // 
            busListBreadcrumbs.AutoSize = true;
            busListBreadcrumbs.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            busListBreadcrumbs.ForeColor = Color.Black;
            busListBreadcrumbs.Location = new Point(123, 41);
            busListBreadcrumbs.Name = "busListBreadcrumbs";
            busListBreadcrumbs.Size = new Size(86, 24);
            busListBreadcrumbs.TabIndex = 19;
            busListBreadcrumbs.Text = "Bus List";
            busListBreadcrumbs.Click += busListBreadcrumbs_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.Location = new Point(-110, 57);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 18;
            label1.Text = "Home";
            // 
            // panelBusDetails
            // 
            panelBusDetails.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelBusDetails.BackColor = Color.FromArgb(244, 255, 255);
            panelBusDetails.BorderStyle = BorderStyle.FixedSingle;
            panelBusDetails.Controls.Add(BusR);
            panelBusDetails.Controls.Add(colorPanel);
            panelBusDetails.Controls.Add(SittingPlan);
            panelBusDetails.Controls.Add(NoOfSeats);
            panelBusDetails.Controls.Add(Colour);
            panelBusDetails.Controls.Add(PlateNo);
            panelBusDetails.Controls.Add(CostPerSeats);
            panelBusDetails.Controls.Add(BusRouteLabel);
            panelBusDetails.Controls.Add(SeatingPlanLabel);
            panelBusDetails.Controls.Add(SeatNoLabel);
            panelBusDetails.Controls.Add(busNameLabel);
            panelBusDetails.Controls.Add(platenoLabel);
            panelBusDetails.Controls.Add(deletebutton);
            panelBusDetails.Controls.Add(editBusDetail);
            panelBusDetails.Controls.Add(pictureBox);
            panelBusDetails.Font = new Font("Microsoft Sans Serif", 9F);
            panelBusDetails.Location = new Point(123, 178);
            panelBusDetails.Margin = new Padding(3, 4, 3, 4);
            panelBusDetails.Name = "panelBusDetails";
            panelBusDetails.Size = new Size(931, 372);
            panelBusDetails.TabIndex = 22;
            // 
            // BusR
            // 
            BusR.Anchor = AnchorStyles.Left;
            BusR.AutoSize = true;
            BusR.Font = new Font("Inter", 13.8F);
            BusR.Location = new Point(523, 249);
            BusR.MaximumSize = new Size(600, 80);
            BusR.Name = "BusR";
            BusR.Size = new Size(81, 28);
            BusR.TabIndex = 17;
            BusR.Text = "routes";
            BusR.Visible = false;
            // 
            // colorPanel
            // 
            colorPanel.Anchor = AnchorStyles.Left;
            colorPanel.Location = new Point(719, 163);
            colorPanel.Margin = new Padding(3, 4, 3, 4);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(32, 32);
            colorPanel.TabIndex = 16;
            // 
            // SittingPlan
            // 
            SittingPlan.Anchor = AnchorStyles.Left;
            SittingPlan.AutoSize = true;
            SittingPlan.Font = new Font("Inter", 13.8F);
            SittingPlan.Location = new Point(819, 212);
            SittingPlan.Name = "SittingPlan";
            SittingPlan.Size = new Size(126, 28);
            SittingPlan.TabIndex = 15;
            SittingPlan.Text = "SittingPlan";
            // 
            // NoOfSeats
            // 
            NoOfSeats.Anchor = AnchorStyles.Left;
            NoOfSeats.AutoSize = true;
            NoOfSeats.Font = new Font("Inter", 13.8F);
            NoOfSeats.Location = new Point(628, 214);
            NoOfSeats.Name = "NoOfSeats";
            NoOfSeats.Size = new Size(68, 28);
            NoOfSeats.TabIndex = 14;
            NoOfSeats.Text = "Num ";
            // 
            // Colour
            // 
            Colour.Anchor = AnchorStyles.Left;
            Colour.AutoSize = true;
            Colour.Font = new Font("Inter", 13.8F);
            Colour.Location = new Point(757, 169);
            Colour.Name = "Colour";
            Colour.Size = new Size(29, 28);
            Colour.TabIndex = 13;
            Colour.Text = "C";
            // 
            // PlateNo
            // 
            PlateNo.Anchor = AnchorStyles.Left;
            PlateNo.AutoSize = true;
            PlateNo.Font = new Font("Inter", 13.8F);
            PlateNo.Location = new Point(549, 172);
            PlateNo.Name = "PlateNo";
            PlateNo.Size = new Size(179, 28);
            PlateNo.TabIndex = 12;
            PlateNo.Text = "numberPlateNo";
            // 
            // CostPerSeats
            // 
            CostPerSeats.Anchor = AnchorStyles.Left;
            CostPerSeats.AutoSize = true;
            CostPerSeats.Font = new Font("Inter", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CostPerSeats.Location = new Point(394, 289);
            CostPerSeats.Name = "CostPerSeats";
            CostPerSeats.Size = new Size(166, 49);
            CostPerSeats.TabIndex = 11;
            CostPerSeats.Text = "$95.00";
            // 
            // BusRouteLabel
            // 
            BusRouteLabel.Anchor = AnchorStyles.Left;
            BusRouteLabel.AutoSize = true;
            BusRouteLabel.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            BusRouteLabel.Location = new Point(399, 249);
            BusRouteLabel.Name = "BusRouteLabel";
            BusRouteLabel.Size = new Size(109, 24);
            BusRouteLabel.TabIndex = 9;
            BusRouteLabel.Text = "BusRoute:";
            BusRouteLabel.Visible = false;
            // 
            // SeatingPlanLabel
            // 
            SeatingPlanLabel.Anchor = AnchorStyles.Left;
            SeatingPlanLabel.AutoSize = true;
            SeatingPlanLabel.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            SeatingPlanLabel.Location = new Point(727, 213);
            SeatingPlanLabel.Name = "SeatingPlanLabel";
            SeatingPlanLabel.Size = new Size(93, 24);
            SeatingPlanLabel.TabIndex = 7;
            SeatingPlanLabel.Text = "Sit Plan :";
            // 
            // SeatNoLabel
            // 
            SeatNoLabel.Anchor = AnchorStyles.Left;
            SeatNoLabel.AutoSize = true;
            SeatNoLabel.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            SeatNoLabel.Location = new Point(400, 213);
            SeatNoLabel.Name = "SeatNoLabel";
            SeatNoLabel.Size = new Size(139, 24);
            SeatNoLabel.TabIndex = 6;
            SeatNoLabel.Text = "No. of Seats :";
            // 
            // busNameLabel
            // 
            busNameLabel.Anchor = AnchorStyles.Left;
            busNameLabel.AutoSize = true;
            busNameLabel.Font = new Font("Inter SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            busNameLabel.Location = new Point(394, 52);
            busNameLabel.MaximumSize = new Size(450, 0);
            busNameLabel.Name = "busNameLabel";
            busNameLabel.Size = new Size(141, 49);
            busNameLabel.TabIndex = 3;
            busNameLabel.Text = "model";
            // 
            // platenoLabel
            // 
            platenoLabel.Anchor = AnchorStyles.Left;
            platenoLabel.AutoSize = true;
            platenoLabel.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            platenoLabel.Location = new Point(398, 174);
            platenoLabel.Name = "platenoLabel";
            platenoLabel.Size = new Size(153, 24);
            platenoLabel.TabIndex = 4;
            platenoLabel.Text = "Plate Number :";
            // 
            // deletebutton
            // 
            deletebutton.Anchor = AnchorStyles.Right;
            deletebutton.BackColor = Color.FromArgb(248, 10, 25);
            deletebutton.FlatStyle = FlatStyle.Flat;
            deletebutton.Font = new Font("Inter", 12F);
            deletebutton.ForeColor = Color.White;
            deletebutton.Location = new Point(726, 212);
            deletebutton.Margin = new Padding(3, 4, 3, 4);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(156, 65);
            deletebutton.TabIndex = 2;
            deletebutton.Text = "Delete Bus";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // editBusDetail
            // 
            editBusDetail.Anchor = AnchorStyles.Right;
            editBusDetail.BackColor = Color.FromArgb(61, 61, 61);
            editBusDetail.FlatStyle = FlatStyle.Flat;
            editBusDetail.Font = new Font("Inter", 12F);
            editBusDetail.ForeColor = Color.White;
            editBusDetail.Location = new Point(726, 108);
            editBusDetail.Margin = new Padding(3, 4, 3, 4);
            editBusDetail.Name = "editBusDetail";
            editBusDetail.Size = new Size(156, 65);
            editBusDetail.TabIndex = 1;
            editBusDetail.Text = "Edit details";
            editBusDetail.UseVisualStyleBackColor = false;
            editBusDetail.Click += editBusDetail_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Left;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(63, 106);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(258, 178);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
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
            tickButtonPictureBox.Size = new Size(1141, 787);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 28;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // BusDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1146, 819);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BusDetailForm";
            Text = "Bus Detail Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelBusDetails.ResumeLayout(false);
            panelBusDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addBusButton;
        private Label BusR;
        private Label label1;
        private Panel panel2;
        private Label colorLabel;
        private Label platenoLabel;
        private Label busNameLabel;
        private Button deletebutton;
        private Button EditHotelDetail;
        private PictureBox pictureBox3;
        private Label label8;
        private Label label7;
        private Label DistanceLabel;
        private Label label10;
        private Label label9;
        private Label label3;
        private PictureBox pictureBox2;
        private Label priceLabel;
        private Label CostPerSeats;
        private Label BusRouteLabel;
        private Label SeatingPlanLabel;
        private Label SeatNoLabel;
        private Label PlateNo;
        private Label Colour;
        private Label NoOfSeats;
        private Label SittingPlan;
        private Panel colorPanel;
        private Label label4;
        private PictureBox pictureBox1;
        private Label Bredcrumb;
        private Button editBusDetail;
        private Label busListBreadcrumbs;
        private Label homeBreadcrumbs;
        private PictureBox tickButtonPictureBox;
        private Panel panelBusDetails;
        private Label labe;
        private Label km;
        private Label miles;
        private PictureBox pictureBox;
    }
}