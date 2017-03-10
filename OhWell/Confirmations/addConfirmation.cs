using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhWell.Confirmations
{
    public partial class addConfirmation : Form
    {
        public addConfirmation()
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
        private void addConfirmation_Load(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            idBox.Text = "";
            nameBox.Text = "";
            recordNumberBox.Text = "";
            pageNumberBox.Text = "";
            
            confirmationYearPicker.Value = DateTime.Now;
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            clear();
        }
        Confirmations.ConfirmationProfiles cp = new Confirmations.ConfirmationProfiles();
        private void profileBtn_Click(object sender, EventArgs e)
        {
            
            cp.Show();
        }
    }
}
