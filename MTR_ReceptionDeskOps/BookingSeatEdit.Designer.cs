namespace MTRDesktopApplication
{
    partial class BookingSeatEdit
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
            Savebutton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            clearSelectionBtn = new Button();
            SuspendLayout();
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.FromArgb(0, 214, 220);
            Savebutton.FlatStyle = FlatStyle.Flat;
            Savebutton.Font = new Font("Inter", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(26, 484);
            Savebutton.Margin = new Padding(3, 2, 3, 2);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(535, 52);
            Savebutton.TabIndex = 69;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(389, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 30);
            panel1.TabIndex = 70;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Green;
            panel2.Location = new Point(389, 247);
            panel2.Name = "panel2";
            panel2.Size = new Size(30, 30);
            panel2.TabIndex = 71;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Orange;
            panel3.Location = new Point(389, 298);
            panel3.Name = "panel3";
            panel3.Size = new Size(30, 30);
            panel3.TabIndex = 72;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(430, 201);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "Available";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 251);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Selected";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(434, 303);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "Booked";
            // 
            // clearSelectionBtn
            // 
            clearSelectionBtn.Anchor = AnchorStyles.None;
            clearSelectionBtn.BackColor = Color.LightGray;
            clearSelectionBtn.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearSelectionBtn.Location = new Point(387, 348);
            clearSelectionBtn.Name = "clearSelectionBtn";
            clearSelectionBtn.Size = new Size(155, 51);
            clearSelectionBtn.TabIndex = 73;
            clearSelectionBtn.Text = "Clear Selection";
            clearSelectionBtn.UseVisualStyleBackColor = false;
            clearSelectionBtn.Click += clearSelectionBtn_Click;
            // 
            // BookingSeatEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 540);
            Controls.Add(clearSelectionBtn);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Savebutton);
            Name = "BookingSeatEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BookingTextEdit";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Savebutton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button clearSelectionBtn;
        private Panel panelSelectedSeats;
    }
}