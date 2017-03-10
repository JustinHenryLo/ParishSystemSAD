using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhWell.Baptismal
{
    public partial class addBaptism : Form
    {
        public addBaptism()
        {
            InitializeComponent();
        }
        public BaptismalSelect reference;

        private void profileBtn_Click(object sender, EventArgs e)
        {
            BaptismalSelector bs = new BaptismalSelector();
            bs.Show();
               
        }

        private void addBaptism_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void addBaptism_Load(object sender, EventArgs e)
        {

        }


        public void clear()
        {
            idBox.Text = "";
            nameBox.Text = "";
            recordNumberBox.Text = "";
            pageNumberBox.Text = "";
            registryNumberBox.Text = "";
            baptismYearPicker.Value = DateTime.Now;
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
            reference.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
