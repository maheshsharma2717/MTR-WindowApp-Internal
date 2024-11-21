namespace MTRDesktopApplication
{
    partial class MultipleHotelId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleHotelId));
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblPageNumber = new Label();
            Savebutton = new Button();
            btnPrevious = new Panel();
            btnNext = new Panel();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(7, 10);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(331, 253);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageNumber.Location = new Point(16, 267);
            lblPageNumber.Margin = new Padding(4, 0, 4, 0);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(87, 15);
            lblPageNumber.TabIndex = 1;
            lblPageNumber.Text = "Page Number";
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.FromArgb(0, 214, 220);
            Savebutton.FlatStyle = FlatStyle.Flat;
            Savebutton.Font = new Font("Inter", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(144, 291);
            Savebutton.Margin = new Padding(3, 2, 3, 2);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(182, 32);
            Savebutton.TabIndex = 12;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Left;
            btnPrevious.BackColor = Color.FromArgb(0, 214, 220);
            btnPrevious.BackgroundImage = (Image)resources.GetObject("btnPrevious.BackgroundImage");
            btnPrevious.BackgroundImageLayout = ImageLayout.Center;
            btnPrevious.Location = new Point(14, 289);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(39, 34);
            btnPrevious.TabIndex = 13;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(0, 214, 220);
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Center;
            btnNext.Location = new Point(96, 289);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(39, 34);
            btnNext.TabIndex = 14;
            // 
            // MultipleHotelId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(346, 332);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(Savebutton);
            Controls.Add(lblPageNumber);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MultipleHotelId";
            Text = "HotelId";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblPageNumber;
        private Button Savebutton;
        private Panel BackBtn;
        private Panel btnNext;
        private Panel btnPrevious;
    }
}