﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shantir_Nir
{
    public partial class ResHuman : Form
    {
        public ResHuman()
        {
            InitializeComponent();
        }

        private void ResHuman_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home n = new Home();
            n.Show();
        }
    }
}
