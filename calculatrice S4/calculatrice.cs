using Calculatrice;

namespace calculatrice_S4
{
    public partial class calculatrice : Form
    {


        private Calcul calcule;
        public calculatrice()
        {
            InitializeComponent();

            calcule = new Calcul();
        }


        private void resultat_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resultat.Clear();
            calcule.result = string.Empty;
        }


        private void buttonNumber_Click(object sender, EventArgs e)
        {
            resultat.Text += (sender as Button).Text;
            calcule.result += (sender as Button).Text;
        }


        private void buttonCal_onClick(object sender, EventArgs e)
        {
            
        }

        private void buttonEqual_onClick(object sender, EventArgs e)
        {
            resultat.Clear();
            try
            {
                resultat.Text = Convert.ToString(calcule.Calculate());
            }
            catch (Exception ex)
            {
                resultat.Text = "erreur de format calcul !!!!!";
            }
        }
    }
}