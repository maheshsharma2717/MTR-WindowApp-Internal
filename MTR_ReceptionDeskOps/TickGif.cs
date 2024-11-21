using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace MTRDesktopApplication
{
    public partial class TickGif : Form
    {
        private PictureBox pictureBox;

        public TickGif()
        {
            InitializeComponent();
            InitializePictureBox();
            SetPictureBoxTopMost();
        }

        private void InitializePictureBox()
        {
            pictureBox = new PictureBox();
            pictureBox.Image = System.Drawing.Image.FromFile(@"E:\Mtr_Reception_deskOps\MTR_ReceptionDeskOps\Images\icons8-tick.gif");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.BackColor = Color.Transparent; 
            pictureBox.Visible = false;
            this.Controls.Add(pictureBox);
          
            pictureBox.BringToFront();
        }
        private void SetPictureBoxTopMost()
        {
            pictureBox.BringToFront(); 
        }

        
        public void ShowGifAndDisableControls()
        {
            pictureBox.Visible = true;
            foreach (Control control in this.Controls)
            {
                if (control != pictureBox)
                {
                    control.Enabled = false;
                    control.BackColor = Color.LightGray;
                }
            }
        }

      
        public void HideGifAndEnableControls()
        {
            pictureBox.Visible = false;
            foreach (Control control in this.Controls)
            {
                if (control != pictureBox)
                {
                    control.Enabled = true; 
                    control.BackColor = SystemColors.Control; 
                }
            }
        }
    }
}
