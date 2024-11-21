using System.Runtime.CompilerServices;

namespace MTRDesktopApplication
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            outer_most_panel = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            passwordtextBox = new TextBox();
            button1 = new Button();
            mailTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tickButtonPictureBox = new PictureBox();
            outer_most_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // outer_most_panel
            // 
            outer_most_panel.BackColor = Color.White;
            outer_most_panel.BackgroundImageLayout = ImageLayout.None;
            outer_most_panel.Controls.Add(pictureBox1);
            outer_most_panel.Controls.Add(panel1);
            outer_most_panel.Controls.Add(tickButtonPictureBox);
            outer_most_panel.Dock = DockStyle.Fill;
            outer_most_panel.Font = new Font("Inter", 9F);
            outer_most_panel.Location = new Point(0, 0);
            outer_most_panel.Margin = new Padding(3, 4, 3, 4);
            outer_most_panel.Name = "outer_most_panel";
            outer_most_panel.Size = new Size(1309, 1055);
            outer_most_panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(651, 364);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 295);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(244, 255, 255);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passwordtextBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(mailTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(50, 136);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 764);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label3.Location = new Point(263, 321);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // passwordtextBox
            // 
            passwordtextBox.Anchor = AnchorStyles.None;
            passwordtextBox.Location = new Point(264, 364);
            passwordtextBox.Margin = new Padding(3, 4, 3, 4);
            passwordtextBox.Multiline = true;
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.PasswordChar = '*';
            passwordtextBox.Size = new Size(257, 33);
            passwordtextBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(255, 159, 180);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 445);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(480, 43);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // mailTextBox
            // 
            mailTextBox.Anchor = AnchorStyles.None;
            mailTextBox.Font = new Font("Inter", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailTextBox.Location = new Point(41, 364);
            mailTextBox.Margin = new Padding(3, 4, 3, 4);
            mailTextBox.Multiline = true;
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(197, 33);
            mailTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 10.1999989F, FontStyle.Bold);
            label2.Location = new Point(41, 321);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 100);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 1;
            label1.Text = "Admin Login";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(41, 89);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 55);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
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
            tickButtonPictureBox.Size = new Size(1309, 1055);
            tickButtonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tickButtonPictureBox.TabIndex = 28;
            tickButtonPictureBox.TabStop = false;
            tickButtonPictureBox.UseWaitCursor = true;
            tickButtonPictureBox.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 1055);
            Controls.Add(outer_most_panel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Form1";
            outer_most_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickButtonPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel outer_most_panel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox mailTextBox;
        private Label label2;
        private Label label3;
        private TextBox passwordtextBox;
        private PictureBox tickButtonPictureBox;
    }
}