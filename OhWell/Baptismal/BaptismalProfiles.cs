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
    public partial class BaptismalProfiles : Form
    {
        public BaptismalProfiles()
        {
            InitializeComponent();
        }

        private void BaptismalProfiles_Load(object sender, EventArgs e)
        {

        }
        public void center()
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ArchiveBaptism ab = new ArchiveBaptism();
            ab.Show();
        }
    }
}
