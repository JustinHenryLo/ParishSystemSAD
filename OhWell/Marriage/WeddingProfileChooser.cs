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
    public partial class WeddingProfileChooser : Form
    {
        public WeddingProfileChooser()
        {
            InitializeComponent();
        }

        private void WeddingProfileChooser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
        }
    }
}
