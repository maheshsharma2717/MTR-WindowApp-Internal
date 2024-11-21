namespace MTRDesktopApplication
{
    partial class AddBusRoute
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBusRoute));
            panel = new Panel();
            dataGridView1 = new DataGridView();
            sNo = new DataGridViewTextBoxColumn();
            stopName = new DataGridViewTextBoxColumn();
            stopDestination = new DataGridViewTextBoxColumn();
            titleName = new DataGridViewTextBoxColumn();
            stopDistance = new DataGridViewTextBoxColumn();
            stopTime = new DataGridViewTextBoxColumn();
            stopAmount = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            stops = new Button();
            label9 = new Label();
            panel9 = new Panel();
            label10 = new Label();
            fairPrmiles = new TextBox();
            endMapBtn = new Button();
            startMapBtn = new Button();
            endRouteSuggestionsListBox = new ListBox();
            startRouteSuggestionsListBox = new ListBox();
            label6 = new Label();
            label2 = new Label();
            panel6 = new Panel();
            endLatitudeTextBox = new TextBox();
            panel8 = new Panel();
            endLongitudeTextBox = new TextBox();
            addStop = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            saveBtn = new Button();
            panel1 = new Panel();
            textBoxLatitude = new TextBox();
            panel2 = new Panel();
            longitudeTextBox = new TextBox();
            panel4 = new Panel();
            startRoute = new TextBox();
            panel5 = new Panel();
            endRoute = new TextBox();
            Search_data = new Button();
            label3 = new Label();
            startR = new Label();
            labelLatitude = new Label();
            busRouteBreadcrumbs = new Label();
            pictureBox2 = new PictureBox();
            homeBreadcrumbs = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            longitudeLabel = new Label();
            tickButtonPictureBox = new PictureBox();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel.AutoScroll = true;
            panel.Controls.Add(dataGridView1);
            panel.Controls.Add(dataGridView2);
            panel.Controls.Add(stops);
            panel.Controls.Add(label9);
            panel.Controls.Add(panel9);
            panel.Controls.Add(endMapBtn);
            panel.Controls.Add(startMapBtn);
            panel.Controls.Add(endRouteSuggestionsListBox);
            panel.Controls.Add(startRouteSuggestionsListBox);
            panel.Controls.Add(label6);
            panel.Controls.Add(label2);
            panel.Controls.Add(panel6);
            panel.Controls.Add(panel8);
            panel.Controls.Add(addStop);
            panel.Controls.Add(pictureBox1);
            panel.Controls.Add(label7);
            panel.Controls.Add(saveBtn);
            panel.Controls.Add(panel1);
            panel.Controls.Add(panel2);
            panel.Controls.Add(panel4);
            panel.Controls.Add(panel5);
            panel.Controls.Add(Search_data);
            panel.Controls.Add(label3);
            panel.Controls.Add(startR);
            panel.Controls.Add(labelLatitude);
            panel.Controls.Add(busRouteBreadcrumbs);
            panel.Controls.Add(pictureBox2);
            panel.Controls.Add(homeBreadcrumbs);
            panel.Controls.Add(webView21);
            panel.Controls.Add(longitudeLabel);
            panel.Controls.Add(tickButtonPictureBox);
            panel.Location = new Point(11, 0);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.MinimumSize = new Size(930, 1000);
            panel.Name = "panel";
            panel.Size = new Size(930, 1034);
            panel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(245, 255, 255);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 43;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { sNo, stopName, stopDestination, titleName, stopDistance, stopTime, stopAmount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(249, 249, 249);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(249, 249, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(-37, 607);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(879, 204);
            dataGridView1.TabIndex = 1;
            // 
            // sNo
            // 
            sNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            sNo.FillWeight = 224.598938F;
            sNo.HeaderText = "S/N";
            sNo.MinimumWidth = 6;
            sNo.Name = "sNo";
            sNo.Width = 70;
            // 
            // stopName
            // 
            stopName.FillWeight = 75.08021F;
            stopName.HeaderText = "Start Location";
            stopName.MinimumWidth = 6;
            stopName.Name = "stopName";
            // 
            // stopDestination
            // 
            stopDestination.FillWeight = 75.08021F;
            stopDestination.HeaderText = "Destination";
            stopDestination.MinimumWidth = 6;
            stopDestination.Name = "stopDestination";
            // 
            // titleName
            // 
            titleName.HeaderText = "Title";
            titleName.MinimumWidth = 6;
            titleName.Name = "titleName";
            titleName.Visible = false;
            // 
            // stopDistance
            // 
            stopDistance.FillWeight = 75.08021F;
            stopDistance.HeaderText = "Distance";
            stopDistance.MinimumWidth = 6;
            stopDistance.Name = "stopDistance";
            // 
            // stopTime
            // 
            stopTime.FillWeight = 75.08021F;
            stopTime.HeaderText = "Times";
            stopTime.MinimumWidth = 6;
            stopTime.Name = "stopTime";
            // 
            // stopAmount
            // 
            stopAmount.FillWeight = 75.08021F;
            stopAmount.HeaderText = "Amount";
            stopAmount.MinimumWidth = 6;
            stopAmount.Name = "stopAmount";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(245, 255, 255);
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(245, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeight = 43;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(249, 249, 249);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(249, 249, 249);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(-36, 606);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(879, 202);
            dataGridView2.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "S/N";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Stop Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Type";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Distance";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Times";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Amount";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // stops
            // 
            stops.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            stops.BackColor = Color.ForestGreen;
            stops.BackgroundImageLayout = ImageLayout.None;
            stops.FlatStyle = FlatStyle.Flat;
            stops.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stops.ForeColor = Color.White;
            stops.Location = new Point(785, 682);
            stops.Margin = new Padding(3, 4, 3, 4);
            stops.Name = "stops";
            stops.Size = new Size(174, 48);
            stops.TabIndex = 59;
            stops.Text = "Stops List";
            stops.TextImageRelation = TextImageRelation.ImageBeforeText;
            stops.UseVisualStyleBackColor = false;
            stops.Click += stops_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label9.Location = new Point(686, 403);
            label9.Name = "label9";
            label9.Size = new Size(139, 20);
            label9.TabIndex = 57;
            label9.Text = "Cost (Per Miles)";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.BackColor = Color.FromArgb(249, 249, 249);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(fairPrmiles);
            panel9.Location = new Point(686, 436);
            panel9.Name = "panel9";
            panel9.Size = new Size(224, 52);
            panel9.TabIndex = 56;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(5, 15);
            label10.Name = "label10";
            label10.Size = new Size(22, 21);
            label10.TabIndex = 31;
            label10.Text = "$";
            // 
            // fairPrmiles
            // 
            fairPrmiles.Anchor = AnchorStyles.None;
            fairPrmiles.BackColor = Color.FromArgb(249, 249, 249);
            fairPrmiles.BorderStyle = BorderStyle.None;
            fairPrmiles.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fairPrmiles.Location = new Point(35, 15);
            fairPrmiles.Margin = new Padding(3, 4, 3, 4);
            fairPrmiles.Name = "fairPrmiles";
            fairPrmiles.PlaceholderText = "Enter cost per mile.";
            fairPrmiles.Size = new Size(186, 21);
            fairPrmiles.TabIndex = 30;
            fairPrmiles.KeyPress += fairPrmiles_KeyPress;
            fairPrmiles.Leave += fairPrmiles_Leave;
            // 
            // endMapBtn
            // 
            endMapBtn.Anchor = AnchorStyles.None;
            endMapBtn.BackColor = Color.FromArgb(192, 255, 255);
            endMapBtn.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endMapBtn.ForeColor = SystemColors.ControlText;
            endMapBtn.Location = new Point(500, 386);
            endMapBtn.Name = "endMapBtn";
            endMapBtn.Size = new Size(139, 45);
            endMapBtn.TabIndex = 55;
            endMapBtn.Text = "Select From Map";
            endMapBtn.UseVisualStyleBackColor = false;
            endMapBtn.Click += endMapBtn_Click;
            // 
            // startMapBtn
            // 
            startMapBtn.Anchor = AnchorStyles.None;
            startMapBtn.BackColor = Color.FromArgb(192, 255, 255);
            startMapBtn.Location = new Point(159, 387);
            startMapBtn.Name = "startMapBtn";
            startMapBtn.Size = new Size(139, 45);
            startMapBtn.TabIndex = 54;
            startMapBtn.Text = "Select From Map";
            startMapBtn.UseVisualStyleBackColor = false;
            startMapBtn.Click += startMapBtn_Click;
            // 
            // endRouteSuggestionsListBox
            // 
            endRouteSuggestionsListBox.Anchor = AnchorStyles.None;
            endRouteSuggestionsListBox.BackColor = Color.FromArgb(249, 249, 249);
            endRouteSuggestionsListBox.FormattingEnabled = true;
            endRouteSuggestionsListBox.HorizontalScrollbar = true;
            endRouteSuggestionsListBox.ItemHeight = 20;
            endRouteSuggestionsListBox.Location = new Point(344, 493);
            endRouteSuggestionsListBox.Name = "endRouteSuggestionsListBox";
            endRouteSuggestionsListBox.Size = new Size(300, 104);
            endRouteSuggestionsListBox.TabIndex = 53;
            endRouteSuggestionsListBox.Visible = false;
            endRouteSuggestionsListBox.Click += endRouteSuggestionsListBox_Click;
            endRouteSuggestionsListBox.SelectedIndexChanged += endRouteSuggestionsListBox_SelectedIndexChanged;
            // 
            // startRouteSuggestionsListBox
            // 
            startRouteSuggestionsListBox.Anchor = AnchorStyles.None;
            startRouteSuggestionsListBox.BackColor = Color.FromArgb(249, 249, 249);
            startRouteSuggestionsListBox.FormattingEnabled = true;
            startRouteSuggestionsListBox.HorizontalScrollbar = true;
            startRouteSuggestionsListBox.ItemHeight = 20;
            startRouteSuggestionsListBox.Location = new Point(-2, 493);
            startRouteSuggestionsListBox.Name = "startRouteSuggestionsListBox";
            startRouteSuggestionsListBox.Size = new Size(300, 104);
            startRouteSuggestionsListBox.TabIndex = 1;
            startRouteSuggestionsListBox.Visible = false;
            startRouteSuggestionsListBox.Click += startRouteSuggestionsListBox_Click;
            startRouteSuggestionsListBox.SelectedIndexChanged += startRouteSuggestionsListBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label6.Location = new Point(402, 934);
            label6.Name = "label6";
            label6.Size = new Size(200, 20);
            label6.TabIndex = 52;
            label6.Text = "End Location Longitude";
            label6.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label2.Location = new Point(53, 936);
            label2.Name = "label2";
            label2.Size = new Size(200, 20);
            label2.TabIndex = 51;
            label2.Text = "End Location Longitude";
            label2.Visible = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(249, 249, 249);
            panel6.Controls.Add(endLatitudeTextBox);
            panel6.Location = new Point(51, 959);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 52);
            panel6.TabIndex = 31;
            panel6.Visible = false;
            // 
            // endLatitudeTextBox
            // 
            endLatitudeTextBox.Anchor = AnchorStyles.None;
            endLatitudeTextBox.BackColor = Color.FromArgb(249, 249, 249);
            endLatitudeTextBox.BorderStyle = BorderStyle.None;
            endLatitudeTextBox.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endLatitudeTextBox.Location = new Point(12, 17);
            endLatitudeTextBox.Margin = new Padding(3, 4, 3, 4);
            endLatitudeTextBox.Name = "endLatitudeTextBox";
            endLatitudeTextBox.PlaceholderText = "Latitude";
            endLatitudeTextBox.Size = new Size(281, 21);
            endLatitudeTextBox.TabIndex = 30;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = Color.FromArgb(249, 249, 249);
            panel8.Controls.Add(endLongitudeTextBox);
            panel8.Location = new Point(400, 959);
            panel8.Name = "panel8";
            panel8.Size = new Size(300, 52);
            panel8.TabIndex = 31;
            panel8.Visible = false;
            // 
            // endLongitudeTextBox
            // 
            endLongitudeTextBox.Anchor = AnchorStyles.None;
            endLongitudeTextBox.BackColor = Color.FromArgb(249, 249, 249);
            endLongitudeTextBox.BorderStyle = BorderStyle.None;
            endLongitudeTextBox.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endLongitudeTextBox.Location = new Point(11, 16);
            endLongitudeTextBox.Margin = new Padding(3, 4, 3, 4);
            endLongitudeTextBox.Name = "endLongitudeTextBox";
            endLongitudeTextBox.PlaceholderText = "Longitude";
            endLongitudeTextBox.Size = new Size(281, 21);
            endLongitudeTextBox.TabIndex = 30;
            // 
            // addStop
            // 
            addStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addStop.BackColor = Color.DarkGreen;
            addStop.BackgroundImageLayout = ImageLayout.None;
            addStop.FlatStyle = FlatStyle.Flat;
            addStop.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStop.ForeColor = Color.White;
            addStop.Image = Properties.Resources.add;
            addStop.Location = new Point(782, 605);
            addStop.Margin = new Padding(3, 4, 3, 4);
            addStop.Name = "addStop";
            addStop.Size = new Size(174, 48);
            addStop.TabIndex = 27;
            addStop.Text = "   Add Stops";
            addStop.TextImageRelation = TextImageRelation.ImageBeforeText;
            addStop.UseVisualStyleBackColor = false;
            addStop.Click += addStop_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 121, 124);
            label7.Location = new Point(262, 15);
            label7.Name = "label7";
            label7.Size = new Size(153, 24);
            label7.TabIndex = 48;
            label7.Text = "Add Bus Route";
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.None;
            saveBtn.BackColor = Color.FromArgb(0, 214, 220);
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(50, 846);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(652, 48);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(249, 249, 249);
            panel1.Controls.Add(textBoxLatitude);
            panel1.Location = new Point(727, 812);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 52);
            panel1.TabIndex = 14;
            panel1.Visible = false;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Anchor = AnchorStyles.None;
            textBoxLatitude.BackColor = Color.FromArgb(249, 249, 249);
            textBoxLatitude.BorderStyle = BorderStyle.None;
            textBoxLatitude.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLatitude.Location = new Point(7, 15);
            textBoxLatitude.Margin = new Padding(3, 4, 3, 4);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.PlaceholderText = "Latitude";
            textBoxLatitude.Size = new Size(167, 21);
            textBoxLatitude.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(249, 249, 249);
            panel2.Controls.Add(longitudeTextBox);
            panel2.Location = new Point(734, 906);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 52);
            panel2.TabIndex = 13;
            panel2.Visible = false;
            // 
            // longitudeTextBox
            // 
            longitudeTextBox.Anchor = AnchorStyles.None;
            longitudeTextBox.BackColor = Color.FromArgb(249, 249, 249);
            longitudeTextBox.BorderStyle = BorderStyle.None;
            longitudeTextBox.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            longitudeTextBox.Location = new Point(10, 15);
            longitudeTextBox.Margin = new Padding(3, 4, 3, 4);
            longitudeTextBox.Name = "longitudeTextBox";
            longitudeTextBox.PlaceholderText = "Longitude";
            longitudeTextBox.Size = new Size(128, 21);
            longitudeTextBox.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(249, 249, 249);
            panel4.Controls.Add(startRoute);
            panel4.Location = new Point(-2, 436);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 52);
            panel4.TabIndex = 11;
            // 
            // startRoute
            // 
            startRoute.Anchor = AnchorStyles.None;
            startRoute.BackColor = Color.FromArgb(249, 249, 249);
            startRoute.BorderStyle = BorderStyle.None;
            startRoute.Font = new Font("Inter", 10F);
            startRoute.Location = new Point(9, 15);
            startRoute.Margin = new Padding(3, 4, 3, 4);
            startRoute.Name = "startRoute";
            startRoute.PlaceholderText = "Enter Starting Location";
            startRoute.Size = new Size(286, 21);
            startRoute.TabIndex = 0;
            startRoute.TextChanged += startRoute_TextChanged;
            startRoute.Leave += startRoute_Leave;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(249, 249, 249);
            panel5.Controls.Add(endRoute);
            panel5.Location = new Point(344, 436);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 52);
            panel5.TabIndex = 12;
            // 
            // endRoute
            // 
            endRoute.Anchor = AnchorStyles.None;
            endRoute.BackColor = Color.FromArgb(249, 249, 249);
            endRoute.BorderStyle = BorderStyle.None;
            endRoute.Enabled = false;
            endRoute.Font = new Font("Inter", 10F);
            endRoute.Location = new Point(15, 15);
            endRoute.Margin = new Padding(3, 4, 3, 4);
            endRoute.Name = "endRoute";
            endRoute.PlaceholderText = "Enter Destination";
            endRoute.Size = new Size(278, 21);
            endRoute.TabIndex = 0;
            endRoute.TextChanged += endRoute_TextChanged;
            endRoute.Leave += endRoute_Leave;
            // 
            // Search_data
            // 
            Search_data.Anchor = AnchorStyles.None;
            Search_data.BackColor = Color.FromArgb(255, 128, 128);
            Search_data.FlatStyle = FlatStyle.Flat;
            Search_data.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search_data.ForeColor = Color.White;
            Search_data.Location = new Point(708, 961);
            Search_data.Margin = new Padding(3, 4, 3, 4);
            Search_data.Name = "Search_data";
            Search_data.Size = new Size(182, 48);
            Search_data.TabIndex = 40;
            Search_data.Text = "Search Route";
            Search_data.UseVisualStyleBackColor = false;
            Search_data.Visible = false;
            Search_data.Click += Search_data_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label3.Location = new Point(344, 403);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 9;
            label3.Text = "End Terminal";
            // 
            // startR
            // 
            startR.Anchor = AnchorStyles.None;
            startR.AutoSize = true;
            startR.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startR.Location = new Point(-2, 403);
            startR.Name = "startR";
            startR.Size = new Size(149, 20);
            startR.TabIndex = 7;
            startR.Text = "Starting Terminal";
            // 
            // labelLatitude
            // 
            labelLatitude.Anchor = AnchorStyles.None;
            labelLatitude.AutoSize = true;
            labelLatitude.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLatitude.Location = new Point(727, 776);
            labelLatitude.Name = "labelLatitude";
            labelLatitude.Size = new Size(195, 20);
            labelLatitude.TabIndex = 31;
            labelLatitude.Text = "Start Location Latitude";
            labelLatitude.Visible = false;
            // 
            // busRouteBreadcrumbs
            // 
            busRouteBreadcrumbs.AutoSize = true;
            busRouteBreadcrumbs.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            busRouteBreadcrumbs.ForeColor = Color.FromArgb(0, 0, 0, 0);
            busRouteBreadcrumbs.Location = new Point(114, 15);
            busRouteBreadcrumbs.Name = "busRouteBreadcrumbs";
            busRouteBreadcrumbs.Size = new Size(108, 24);
            busRouteBreadcrumbs.TabIndex = 2;
            busRouteBreadcrumbs.Text = "Bus Route";
            busRouteBreadcrumbs.Click += busRouteBreadcrumbs_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(228, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // homeBreadcrumbs
            // 
            homeBreadcrumbs.AutoSize = true;
            homeBreadcrumbs.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeBreadcrumbs.ForeColor = Color.Black;
            homeBreadcrumbs.Location = new Point(15, 15);
            homeBreadcrumbs.Name = "homeBreadcrumbs";
            homeBreadcrumbs.Size = new Size(67, 24);
            homeBreadcrumbs.TabIndex = 1;
            homeBreadcrumbs.Text = "Home";
            homeBreadcrumbs.Click += homeBreadcrumbs_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(15, 71);
            webView21.Margin = new Padding(3, 4, 3, 4);
            webView21.Name = "webView21";
            webView21.Size = new Size(907, 304);
            webView21.TabIndex = 8;
            webView21.ZoomFactor = 1D;
            // 
            // longitudeLabel
            // 
            longitudeLabel.Anchor = AnchorStyles.None;
            longitudeLabel.AutoSize = true;
            longitudeLabel.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            longitudeLabel.Location = new Point(717, 876);
            longitudeLabel.Name = "longitudeLabel";
            longitudeLabel.Size = new Size(210, 20);
            longitudeLabel.TabIndex = 4;
            longitudeLabel.Text = "Start Location Longitude";
            longitudeLabel.Visible = false;
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
            tickButtonPictureBox.Size = new Size(930, 1034);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 50;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.Visible = false;
            // 
            // AddBusRoute
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1033, 800);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddBusRoute";
            Text = "AddBusRoute";
            Load += AddBusRoute_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Label busRouteBreadcrumbs;
        private PictureBox pictureBox2;
        private Label homeBreadcrumbs;
        private Button buttonAddBusRoute;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button addButton;
        private TextBox addressTextBox;
        private TextBox longitudeTextBox;
        private Label addressLabel;
        private Label longitudeLabel;
        private Label label1;
        private Button addStop;
        private Label labelLatitude;
        private TextBox textBoxLatitude;
        private Button Search_data;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textzip;
        private TextBox textstate;
        private TextBox textcity;
        private TextBox textstreet;
        private CheckedListBox checkedListBox1;
        private ListBox listBoxResults;
        private TextBox endRoute;
        private Label startR;
        private TextBox startRoute;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Button saveBtn;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox3;
        private Panel panel7;
        private TextBox textBox2;
        private TextBox wayPointBox;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stopName;
        private DataGridViewTextBoxColumn stopDestination;
        private DataGridViewTextBoxColumn stopDistance;
        private DataGridViewTextBoxColumn stopTime;
        private DataGridViewTextBoxColumn stopAmount;
        private DataGridViewTextBoxColumn stopDelete;
        private DataGridViewTextBoxColumn sNo;
        private PictureBox tickButtonPictureBox;
        private Panel panel6;
        private TextBox textBox3;
        private Panel panel8;
        private TextBox endLongitudeTextBox;
        private TextBox endLatitudeTextBox;
        private Label label6;
        private Label label2;
        private ListBox listBoxSuggestions;
        private ListBox listBox1;
        private ListBox listboxSuggestionsDestination;
        private ListBox endRouteSuggestionsListBox;
        private ListBox startRouteSuggestionsListBox;
        private Button endMapBtn;
        private Button startMapBtn;
        private Panel panel9;
        private TextBox fairPrmiles;
        private Label label9;
        private DataGridView dataGridView2;
        private Button button1;
        private Button stops;
        private Label label10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn titleName;
        private DataGridViewTextBoxColumn IsAutoGenerated;
    }
}