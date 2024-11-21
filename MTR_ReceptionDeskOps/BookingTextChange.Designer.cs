namespace MTRDesktopApplication
{
    partial class BookingTextChange
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
            panel2 = new Panel();
            pickUpDestinationTextBox = new TextBox();
            panel1 = new Panel();
            destinationTextBox = new TextBox();
            Savebutton = new Button();
            panel3 = new Panel();
            bookingNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(249, 249, 249);
            panel2.Controls.Add(pickUpDestinationTextBox);
            panel2.Location = new Point(61, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 52);
            panel2.TabIndex = 45;
            // 
            // pickUpDestinationTextBox
            // 
            pickUpDestinationTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pickUpDestinationTextBox.BackColor = Color.FromArgb(249, 249, 249);
            pickUpDestinationTextBox.BorderStyle = BorderStyle.None;
            pickUpDestinationTextBox.Cursor = Cursors.IBeam;
            pickUpDestinationTextBox.Font = new Font("Inter", 10F);
            pickUpDestinationTextBox.Location = new Point(11, 16);
            pickUpDestinationTextBox.Name = "pickUpDestinationTextBox";
            pickUpDestinationTextBox.PlaceholderText = "Enter pickUp Destination";
            pickUpDestinationTextBox.Size = new Size(314, 21);
            pickUpDestinationTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(249, 249, 249);
            panel1.Controls.Add(destinationTextBox);
            panel1.Location = new Point(61, 252);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 52);
            panel1.TabIndex = 46;
            // 
            // destinationTextBox
            // 
            destinationTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            destinationTextBox.BackColor = Color.FromArgb(249, 249, 249);
            destinationTextBox.BorderStyle = BorderStyle.None;
            destinationTextBox.Cursor = Cursors.IBeam;
            destinationTextBox.Font = new Font("Inter", 10F);
            destinationTextBox.Location = new Point(11, 16);
            destinationTextBox.Name = "destinationTextBox";
            destinationTextBox.PlaceholderText = "Destination";
            destinationTextBox.Size = new Size(318, 21);
            destinationTextBox.TabIndex = 0;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.FromArgb(0, 214, 220);
            Savebutton.FlatStyle = FlatStyle.Flat;
            Savebutton.Font = new Font("Inter", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(61, 339);
            Savebutton.Margin = new Padding(3, 2, 3, 2);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(332, 52);
            Savebutton.TabIndex = 68;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(249, 249, 249);
            panel3.Controls.Add(bookingNameTextBox);
            panel3.Location = new Point(61, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 52);
            panel3.TabIndex = 69;
            // 
            // bookingNameTextBox
            // 
            bookingNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bookingNameTextBox.BackColor = Color.FromArgb(249, 249, 249);
            bookingNameTextBox.BorderStyle = BorderStyle.None;
            bookingNameTextBox.Cursor = Cursors.IBeam;
            bookingNameTextBox.Font = new Font("Inter", 10F);
            bookingNameTextBox.Location = new Point(11, 15);
            bookingNameTextBox.Name = "bookingNameTextBox";
            bookingNameTextBox.PlaceholderText = "Enter Name";
            bookingNameTextBox.Size = new Size(318, 21);
            bookingNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label2.Location = new Point(61, 228);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 70;
            label2.Text = "Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label1.Location = new Point(61, 125);
            label1.Name = "label1";
            label1.Size = new Size(180, 21);
            label1.TabIndex = 71;
            label1.Text = "Pick Up Destination";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold);
            label3.Location = new Point(61, 33);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 72;
            label3.Text = "Name";
            // 
            // BookingTextChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(454, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(Savebutton);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "BookingTextChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookingTextChange";
            TopMost = true;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox pickUpDestinationTextBox;
        private Panel panel14;
        private TextBox destinationTextBox;
        private Button Savebutton;
        private Panel panel3;
        private TextBox bookingNameTextBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel1;
    }
}