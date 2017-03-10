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
    public partial class Profiles : Form
    {
        public Profiles()
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
        PersonsLib.ProfileAdd pa = new PersonsLib.ProfileAdd();
        PersonsLib.ProfileList pl = new PersonsLib.ProfileList();
        public LibrarySelect ls;

        private void addProfileBtn_Click(object sender, EventArgs e)
        {
            pa.Show();
            
            pa.clear();
        }

        private void viewProfileBtn_Click(object sender, EventArgs e)
        {
            pl.Show();
            pl.BringToFront();
            pl.center();
        }

        private void Profiles_Load(object sender, EventArgs e)
        {

        }

        private void Profiles_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Profiles_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ls.Show();
            ls.center();
        }

        public void center()
        {
            this.CenterToScreen();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
