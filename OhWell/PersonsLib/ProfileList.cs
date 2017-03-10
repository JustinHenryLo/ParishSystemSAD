using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhWell.PersonsLib
{
    public partial class ProfileList : Form
    {
        public ProfileList()
        {
            InitializeComponent();
        }
        #region Move Form
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        #endregion
        private void ProfilesView_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void center()
        {
            this.CenterToScreen();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
