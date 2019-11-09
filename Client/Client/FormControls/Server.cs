using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormControls {
    public partial class Server : UserControl {
        public Server() {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e) {
            panel1.Location = new Point(Width / 2 - panel1.Width / 2, Height /2 - panel1.Height /2);
        }

        private void Server_SizeChanged(object sender, EventArgs e) {
            panel1.Location = new Point(Width / 2 - panel1.Width / 2, Height / 2 - panel1.Height / 2);
        }
    }
}
