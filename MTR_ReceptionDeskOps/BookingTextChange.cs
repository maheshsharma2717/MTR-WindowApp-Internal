using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTRDesktopApplication
{
    public partial class BookingTextChange : Form
    {
        public string TextBoxValue { get; private set; }
        public BookingTextChange(string textBoxName)
        {
            InitializeComponent();
            SetRoundButton(Savebutton);
            SetRoundPanel(panel1, 7, Color.LightGray);
            SetRoundPanel(panel2, 7, Color.LightGray);
            SetRoundPanel(panel3, 7, Color.LightGray);
            destinationTextBox.Visible = false;
            pickUpDestinationTextBox.Visible = false;
            bookingNameTextBox.Visible = false;
            switch (textBoxName)
            {
                case "destination":
                    destinationTextBox.Visible = true;
                    break;
                case "pickupDestination":
                    pickUpDestinationTextBox.Visible = true;
                    break;
                case "bookingName":
                    bookingNameTextBox.Visible = true;
                    break;
            }
        }
        private void SetRoundButton(Button button)
        {
            int radius = 10;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = button.ClientRectangle;
            bounds.Inflate(-1, -1);
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }
        private void SetRoundPanel(Panel panel, int radius, Color borderColor)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(borderColor, 1))
                {
                    Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                    DrawRoundedRectangle(g, pen, rect, radius);
                }
            };
        }
        private void DrawRoundedRectangle(Graphics g, Pen pen, Rectangle bounds, int cornerRadius)
        {
            int diameter = cornerRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            g.DrawArc(pen, arc, 180, 90);
            arc.X = bounds.Right - diameter;
            g.DrawArc(pen, arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            g.DrawArc(pen, arc, 0, 90);
            arc.X = bounds.Left;
            g.DrawArc(pen, arc, 90, 90);
            g.DrawLine(pen, bounds.Left + cornerRadius, bounds.Top, bounds.Right - cornerRadius, bounds.Top);
            g.DrawLine(pen, bounds.Right, bounds.Top + cornerRadius, bounds.Right, bounds.Bottom - cornerRadius);
            g.DrawLine(pen, bounds.Left + cornerRadius, bounds.Bottom, bounds.Right - cornerRadius, bounds.Bottom);
            g.DrawLine(pen, bounds.Left, bounds.Top + cornerRadius, bounds.Left, bounds.Bottom - cornerRadius);
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (destinationTextBox.Visible)
            {
                TextBoxValue = destinationTextBox.Text;
            }
            else if (pickUpDestinationTextBox.Visible)
            {
                TextBoxValue = pickUpDestinationTextBox.Text;
            }
            else if (bookingNameTextBox.Visible)
            {
                TextBoxValue = bookingNameTextBox.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
