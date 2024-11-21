using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MTRDesktopApplication.CustomControls
{
    public class CustomTimePicker : DateTimePicker
    {
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;
        private RectangleF upButtonArea;
        private RectangleF downButtonArea;
        private const int arrowButtonWidth = 17;

        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public CustomTimePicker()
        {
            SetStyle(ControlStyles.UserPaint, true);
            MinimumSize = new Size(0, 35);
            Font = new Font(Font.Name, 9.5F);
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "hh:mm tt";
            ShowUpDown = true;
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            base.OnValueChanged(eventargs);
            Invalidate();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Graphics graphics = e.Graphics)
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, Width - 0.5F, Height - 0.5F);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;
                graphics.FillRectangle(skinBrush, clientArea);
                graphics.DrawString(Text, Font, textBrush, clientArea, textFormat);
                if (borderSize >= 1)
                    graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                DrawArrowButton(graphics, upButtonArea, ArrowDirection.Up);
                DrawArrowButton(graphics, downButtonArea, ArrowDirection.Down);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int buttonWidth = 15;
            int buttonHeight = 10;
            upButtonArea = new RectangleF(Width - buttonWidth - 2, 2, buttonWidth, buttonHeight);
            downButtonArea = new RectangleF(Width - buttonWidth - 2, Height - buttonHeight - 2, buttonWidth, buttonHeight);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (upButtonArea.Contains(e.Location) || downButtonArea.Contains(e.Location))
                Cursor = Cursors.Hand;
            else
                Cursor = Cursors.Default;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (upButtonArea.Contains(e.Location))
            {
                Value = Value.AddMinutes(1);
            }
            else if (downButtonArea.Contains(e.Location))
            {
                Value = Value.AddMinutes(-1);
            }
        }
        private void DrawArrowButton(Graphics graphics, RectangleF area, ArrowDirection direction)
        {
            Point center = new Point((int)(area.Left + area.Width / 2), (int)(area.Top + area.Height / 2));
            Point[] arrowPoints;
            switch (direction)
            {
                case ArrowDirection.Up:
                    arrowPoints = new Point[]
                    {
                        new Point(center.X - 3, center.Y + 2),
                        new Point(center.X + 3, center.Y + 2),
                        new Point(center.X, center.Y - 2)
                    };
                    break;
                case ArrowDirection.Down:
                    arrowPoints = new Point[]
                    {
                        new Point(center.X - 3, center.Y - 2),
                        new Point(center.X + 3, center.Y - 2),
                        new Point(center.X, center.Y + 2)
                    };
                    break;
                default:
                    throw new NotImplementedException();
            }
            using (SolidBrush brush = new SolidBrush(textColor))
            {
                graphics.FillPolygon(brush, arrowPoints);
            }
        }

        private enum ArrowDirection
        {
            Up,
            Down
        }
    }
}
