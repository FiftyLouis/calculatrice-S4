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
            if(calcule.currentState == Calcul.state.afterResult)
            {
                resultat.Clear();
                calcule.result = string.Empty;
                calcule.currentState = Calcul.state.beforeResult;
            }
            resultat.Text += (sender as Button).Text;
            calcule.result += (sender as Button).Text;
        }

        private void buttonEqual_onClick(object sender, EventArgs e)
        {
            calcule.result = resultat.Text;
            try
            {
                resultat.Clear();
                resultat.Text = Convert.ToString(calcule.Calculate());
                calcule.currentState = Calcul.state.afterResult;
                Console.WriteLine(calcule.currentRegex);
            }
            catch (Exception ex)
            {
                resultat.Text = "erreur de format calcul !!!!!";
            }
        }
    }
}