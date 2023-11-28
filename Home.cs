namespace Shantir_Nir
{
    public partial class Home : Form
    {
        public Home()
        {

            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donation h = new Donation();
            h.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdoptPet h = new AdoptPet();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdoptBaby b = new AdoptBaby();
            b.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RescueHome h = new RescueHome();
            h.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            VolunteerApply n = new VolunteerApply();
            n.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDash n = new AdminDash();
            n.Show();

        }
    }
}