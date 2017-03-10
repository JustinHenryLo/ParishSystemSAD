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
    public partial class BloodDonations : Form
    {
        public BloodDonations()
        {
            InitializeComponent();
        }
        
        private void BloodDonations_Load(object sender, EventArgs e)
        {

        }
        #region MOVE FORM
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
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
