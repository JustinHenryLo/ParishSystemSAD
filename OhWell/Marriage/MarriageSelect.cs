using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhWell
{
    public partial class MarriageSelect : Form
    {
        public MarriageSelect()
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

        public LibrarySelect ls;


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MarriageSelect_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(Cursor.Position.X + e.X, Cursor.Position.Y + e.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ls.Show();
            ls.center();
        }
        public Boolean weddingFormOpen = false;
        Marriage.WeddingForm wf = new Marriage.WeddingForm();
        private void button2_Click(object sender, EventArgs e)
        {
            
               
            wf.Show();
            this.Hide();
            wf.reference = this;
            
            

        }
        Marriage.WeddingProfilesView wpv = new Marriage.WeddingProfilesView();
        private void button3_Click_1(object sender, EventArgs e)
        {
            wpv.Show();
        }

        private void MarriageSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            ls.Show();
        }
    }
}
