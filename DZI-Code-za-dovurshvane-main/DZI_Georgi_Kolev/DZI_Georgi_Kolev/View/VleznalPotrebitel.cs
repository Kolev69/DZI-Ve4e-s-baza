﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZI_Georgi_Kolev
{
    public partial class VleznalPotrebitel : Form
    {
        public VleznalPotrebitel()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VleznalPotrebitel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dZI_Georgi_12ADataSet.potrebitel' table. You can move, or remove it, as needed.
            this.potrebitelTableAdapter.Fill(this.dZI_Georgi_12ADataSet.potrebitel);

        }
    }
}
