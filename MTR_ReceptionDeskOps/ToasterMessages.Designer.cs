namespace MTRDesktopApplication
{
    partial class ToasterMessages
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
            components = new System.ComponentModel.Container();
            Type = new Label();
            Message = new Label();
            toastTimer = new System.Windows.Forms.Timer(components);
            toastHide = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Type
            // 
            Type.AccessibleName = "";
            Type.AutoSize = true;
            Type.Font = new Font("Microsoft Sans Serif", 11.249999F, FontStyle.Bold);
            Type.ForeColor = Color.Black;
            Type.Location = new Point(14, 12);
            Type.Name = "Type";
            Type.Size = new Size(57, 24);
            Type.TabIndex = 2;
            Type.Text = "Type";
            // 
            // Message
            // 
            Message.Font = new Font("Microsoft Sans Serif", 9.75F);
            Message.ForeColor = Color.Black;
            Message.Location = new Point(14, 56);
            Message.MaximumSize = new Size(400, 70);
            Message.Name = "Message";
            Message.Size = new Size(400, 50);
            Message.TabIndex = 3;
            Message.Text = "Message";
                      
            // 
            // toastTimer
            // 
            toastTimer.Enabled = true;
            toastTimer.Interval = 5;
            // 
            // ToasterMessages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(422, 117);
            Controls.Add(Message);
            Controls.Add(Type);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ToasterMessages";
            Text = "tostar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Type;
        private Label Message;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
    }
}