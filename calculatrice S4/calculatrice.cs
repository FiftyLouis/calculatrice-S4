namespace calculatrice_S4
{
    public partial class calculatrice : Form
    {
        public calculatrice()
        {
            InitializeComponent();
        }

        private void six_Click(object sender, EventArgs e)
        {
            resultat.Text += "6";
        }

        private void sept_Click(object sender, EventArgs e)
        {
            resultat.Text += "7";
        }

        private void neuf_Click(object sender, EventArgs e)
        {
            resultat.Text += "9";
        }

        private void un_Click(object sender, EventArgs e)
        {
            resultat.Text += "1";
        }

        private void deux_Click(object sender, EventArgs e)
        {
            resultat.Text += "2";
        }

        private void trois_Click(object sender, EventArgs e)
        {
            resultat.Text += "3";
        }

        private void quatre_Click(object sender, EventArgs e)
        {
            resultat.Text += "4";
        }

        private void cinq_Click(object sender, EventArgs e)
        {
            resultat.Text += "5";
        }

        private void huit_Click(object sender, EventArgs e)
        {
            resultat.Text += "8";
        }

        private void resultat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void zero_Click(object sender, EventArgs e)
        {
            resultat.Text += "0";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resultat.Clear();
        }

        private void egale_Click(object sender, EventArgs e)
        {
            resultat.Text = "sa marche";
        }

        private void point_Click(object sender, EventArgs e)
        {
            resultat.Text += ".";
        }

        private void add_Click(object sender, EventArgs e)
        {
            resultat.Text += "+";
        }

        private void sous_Click(object sender, EventArgs e)
        {
            resultat.Text += "-";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            resultat.Text += "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            resultat.Text += "/";
        }
    }
}