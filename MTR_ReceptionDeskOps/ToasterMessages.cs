using System;
using System.Windows.Forms;

namespace MTRDesktopApplication
{
    public partial class ToasterMessages : Form
    {
        private System.Windows.Forms.Timer closeTimer;
        public ToasterMessages()
        {
            InitializeComponent();
            this.Load += ToasterMessages_Load;
        }

        public void ShowMessage(string message, MessageType messageType)
        {
            Message.Text = message;
            Type.Text = messageType.ToString();
            BackColor = GetBackgroundColor(messageType);
            Message.ForeColor = Color.White;
            Type.ForeColor = Color.White;
        }

        private Color GetBackgroundColor(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Success:
                    return Color.Green;
                case MessageType.Error:
                    return Color.Red;
                case MessageType.Warning:
                    return Color.Yellow;
                default:
                    return DefaultBackColor;
            }
        }

        private void ToasterMessages_Load(object sender, EventArgs e)
        {
            position();
            closeTimer = new System.Windows.Forms.Timer();
            closeTimer.Interval = 3000;
            closeTimer.Tick += (s, args) => this.Close();
            closeTimer.Start();
        }

        private void position()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int x = screenWidth - this.Width - 10;
            int y = 20;

            this.Location = new Point(x, y);
        }      
    }

    public enum MessageType
    {
        Success,
        Error,
        Warning
    }
}
