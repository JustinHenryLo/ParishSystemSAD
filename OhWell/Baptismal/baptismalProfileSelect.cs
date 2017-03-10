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
    public partial class BaptismalSelect : Form
    {
        public BaptismalSelect()
        {
            InitializeComponent();
        }

        private void BaptismalSelect_Load(object sender, EventArgs e)
        {

        }
        #region Region of FORM no border drag thingy
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
        }
        Baptismal.addBaptism ab = new Baptismal.addBaptism();
        private void button2_Click(object sender, EventArgs e)
        {
            ab.reference = this;
            ab.clear();
            ab.Show();
            
            this.Hide();
            
        }

        private void BaptismalSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        Baptismal.BaptismalProfiles bp = new Baptismal.BaptismalProfiles();
        private void button3_Click(object sender, EventArgs e)
        {
            bp.center();
            bp.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
