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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }
        #region Region for variables
        public String Username;
        public Boolean isLoggedIn = false;
        Image bloodEnabled = OhWell.Properties.Resources.transfusion__1_;
        Image bloodDisabled = OhWell.Properties.Resources.transfusion_DISABLED;
        Image libEnabled = OhWell.Properties.Resources.archive;
        Image libDisabled = OhWell.Properties.Resources.archive_DISABLED;
        Image profitsEnabled = OhWell.Properties.Resources.profits;
        Image profitsDisabled = OhWell.Properties.Resources.profits_DISABLED;
        public Login login = new Login();
        Image bloodHighlight = OhWell.Properties.Resources.Transfusion_Highlight;
        Image libHighlight = OhWell.Properties.Resources.Library_Highlight;
        Image incomeHighlight = OhWell.Properties.Resources.Income_Highlight;
        Image memHighlight = OhWell.Properties.Resources.member_highlight;
        Image memEnable = OhWell.Properties.Resources.member; 

        #endregion

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

        

        public void logCheck()
        {
            if(isLoggedIn == true)
            {
                this.BackColor = Color.MediumAquamarine;
                
                Male.Visible = true;
                Bloodletting.BackgroundImage = bloodEnabled;
                Library.BackgroundImage = libEnabled;
                Profits.BackgroundImage = profitsEnabled;
                WelcomeText.ForeColor = Color.Black;
                WelcomeText.Text = "Welcome, " + Username;
                Bloodletting.Enabled = true;
                Library.Enabled = true;
                Profits.Enabled = true;
                button5.Visible = false;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        Boolean fullScreen = false;
        int width;
        int height;

        private void button2_Click(object sender, EventArgs e)
        {
            if (fullScreen == false)
            {
                width = this.Size.Width;
                height = this.Size.Height;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                fullScreen = true; 
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                fullScreen = false;
            }

        }


        Boolean loginForm = false;
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (loginForm == false)
            {
                
                login.Show();
                login.reference_to_form1 = this;
                loginForm = true;
            }
            else if(loginForm == true && isLoggedIn == true)
            {
                MessageBox.Show("You are already logged in, " + Username, "Logged in already!");

            }
            else if (loginForm == true && isLoggedIn == false)
            {
                login.BringToFront();
           
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized; 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        public static class Globals
        {
            public static int GlobalInt { get; set; }
            public static String username { get; set; }
        }
        
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        LibrarySelect libSelect = new LibrarySelect();
        private void Library_Click(object sender, EventArgs e)
        {
            
            libSelect.Show();
            libSelect.center();
        }

      

        

        private void Bloodletting_MouseHover(object sender, EventArgs e)
        {
            Bloodletting.BackgroundImage = bloodHighlight;
        }








        #region Not used functions
        private void Bloodletting_Enter(object sender, EventArgs e)
        {

        }

        private void Library_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        private void Library_MouseHover(object sender, EventArgs e)
        {
            Library.BackgroundImage = libHighlight;
        }

        private void Profits_MouseHover(object sender, EventArgs e)
        {
            Profits.BackgroundImage = incomeHighlight;
        }

        private void Bloodletting_MouseLeave(object sender, EventArgs e)
        {
            Bloodletting.BackgroundImage = bloodEnabled;
        }

        private void Library_MouseLeave(object sender, EventArgs e)
        {
            Library.BackgroundImage = libEnabled;

        }

        private void Profits_MouseLeave(object sender, EventArgs e)
        {
            Profits.BackgroundImage = profitsEnabled;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
                "Are you sure that you would like to exit?";
            const string caption = "EXIT";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            
            if (result == DialogResult.No)
            {
                
                e.Cancel = true;
            }
        }
        BloodLettingModule blModule = new BloodLettingModule();
        private void Bloodletting_Click(object sender, EventArgs e)
        {
            
            blModule.Show();
            blModule.center();
        }
        Finance.FinanceModule fModule = new Finance.FinanceModule();
        private void Profits_Click(object sender, EventArgs e)
        {
            fModule.Show();
            
        }
    }




}
