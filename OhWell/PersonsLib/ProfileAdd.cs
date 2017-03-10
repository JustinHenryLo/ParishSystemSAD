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
    public partial class ProfileAdd : Form
    {
        public ProfileAdd()
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
        private void ProfileAdd_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            firstNameBox.Text = "";
            middleNameBox.Text = "";
            lastNameBox.Text = "";
            GenderComboBox.Text = "";
            BirthdatePicker.Value = DateTime.Now;
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
