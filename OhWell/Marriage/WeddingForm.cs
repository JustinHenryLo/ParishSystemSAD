using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhWell.Marriage
{
    public partial class WeddingForm : Form
    {
        public WeddingForm()
        {
            InitializeComponent();
        }

        public MarriageSelect reference;

        

        TextBox profileBox = new TextBox(); /* This textbox variable is used to assign 
        the current selected textbox when opening the ProfileChooser. That way,
        it can be used as a reference on where to pass the selected data on the chooser. */

        public Boolean chooserVisible = false;
        WeddingProfileChooser wpc = new WeddingProfileChooser();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            clear();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            wpc.Show();
            wpc.BringToFront();
            
        }

        private void WeddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wpc.Show();
            wpc.BringToFront();
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

        public void clear()
        {
            profileA_idBox.Text = "";
            profileB_idBox.Text = "";
            profileA_nameBox.Text = "";
            profileB_nameBox.Text = "";
            recordNumberBox.Text = "";
            marriageYearPicker.Value = DateTime.Now;
            pageNumberBox.Text = "";
            this.CenterToScreen();
            reference.Show();
        }

        private void WeddingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
