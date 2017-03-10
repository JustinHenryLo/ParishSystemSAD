﻿using System;
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
    public partial class ConfirmationProfilesView : Form
    {
        public ConfirmationProfilesView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ArchivedConfirmation ac = new ArchivedConfirmation();
            ac.Show();
        }
    }
}