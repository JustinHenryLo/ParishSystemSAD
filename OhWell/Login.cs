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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public Form1 reference_to_form1;


        private void button1_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text == "admin" && passwordBox.Text == "admin")
            {
                reference_to_form1.Username = usernameBox.Text;
                reference_to_form1.isLoggedIn = true;
                reference_to_form1.logCheck();
                this.Close();

            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");

            }
            
            
            
            
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
        Boolean VisiblePass = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (VisiblePass == false)
            {
                passwordBox.PasswordChar = '\0';
                VisiblePass = true;
            }
            else
            {
                passwordBox.PasswordChar = '*';
                VisiblePass = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
