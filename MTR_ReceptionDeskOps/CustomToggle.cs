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

namespace MTRDesktopApplication {
    public partial class CustomToggle : Form {
        public CustomToggle() {
            InitializeComponent();
        }


        private void PaymentSettings_Load(object sender, EventArgs e) {
            
        }
    }

    public class PaymentSetting : CheckBox {
        private Color onBackColor = Color.LightGreen;
        private Color onToggleColor = Color.Linen;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidColor = true;

        public Color OnBackColor { get => onBackColor; set { onBackColor = value; this.Invalidate(); } }
        public Color OnToggleColor { get => onToggleColor; set { onToggleColor = value; this.Invalidate(); } }
        public Color OffBackColor { get => offBackColor; set { offBackColor = value; this.Invalidate(); } }
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; this.Invalidate(); } }
        public bool SolidColor { get => solidColor; set { solidColor = value; this.Invalidate(); } }

        public PaymentSetting() {
            this.MinimumSize = new Size(45, 23);
        }

        private GraphicsPath GetFigurePath() {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent) {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) {
                if (SolidColor)
                    pevent.Graphics.FillPath(new SolidBrush(OnBackColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(OnBackColor, 2), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(OnToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else {
                if (SolidColor)
                    pevent.Graphics.FillPath(new SolidBrush(OffBackColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(OffBackColor, 2), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(OffToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
