using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace OhWell
{
    public partial class LibrarySelect : Form
    {
        public LibrarySelect()
        {
            InitializeComponent();
        }

        #region Variables
        MarriageSelect ms = new MarriageSelect();
        BaptismalSelect bs = new BaptismalSelect();
        ConfirmationSelect cs = new ConfirmationSelect();
        PersonsLib.Profiles profiles = new PersonsLib.Profiles();

        #endregion


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
        private void Marriage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ms.Show();
            ms.ls = this;
            
        }

        private void Marriage_Enter(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            cs.Show();

        }

        private void LibrarySelect_Load(object sender, EventArgs e)
        {

        }

        private void LibrarySelect_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        public void center()
        {
            this.CenterToScreen();
        }
        private void Profiles_Click(object sender, EventArgs e)
        {
            this.Hide();
            profiles.Show();
            profiles.BringToFront();
            profiles.ls = this;
            profiles.center();
        }
    }

}
