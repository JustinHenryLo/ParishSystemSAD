using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhWell.Finance
{
    public partial class FinanceModule : Form
    {
        public FinanceModule()
        {
            InitializeComponent();
        }
        Finance.Contributor c = new Finance.Contributor();
        private void button2_Click(object sender, EventArgs e)
        {
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
            
        }
        Finance.CashRelease cr = new Finance.CashRelease();
        private void button3_Click(object sender, EventArgs e)
        {
            cr.Show();
        }

        private void FinanceModule_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
