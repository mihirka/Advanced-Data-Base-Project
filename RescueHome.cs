using System;
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
    public partial class RescueHome : Form
    {
        public RescueHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResAnimal n = new ResAnimal();
            n.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home n = new Home();
            n.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ResHuman n = new ResHuman();
            n.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResAnimal n = new ResAnimal();
            n.Show();   
        }
    }
}
