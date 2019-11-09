using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client {
    public partial class main : Form {
        public main() {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        #region Form Design
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveLocation(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private const int gripSize = 20; // Grip size
        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x84) {  // WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);
                if (pos.X >= Width - gripSize && pos.Y >= Height - gripSize) {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void main_SizeChanged(object sender, EventArgs e) {
            server1.Size = new Size(Width, Height - TopBar.Height);
        }
        #endregion

        private void main_Load(object sender, EventArgs e) {

        }

        private void min_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void max_Click(object sender, EventArgs e) {
            if (WindowState.Equals(FormWindowState.Maximized))
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void exit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
