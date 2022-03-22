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
            calcule.CalculState = CalculStateEnum.AquireOperand1;
        }


        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if (calcule.CalculState == CalculStateEnum.BeginAquireOperand2)
            {
                calcule.CalculState = CalculStateEnum.AquireOperand2;
            }else if(calcule.CalculState == CalculStateEnum.Calculation)
            {
                resultat.Clear();
                calcule.CalculState = CalculStateEnum.AquireOperand1;
            }

            resultat.Text += (sender as Button).Text;
        }


        private void buttonCal_onClick(object sender, EventArgs e)
        {
            if(calcule.CalculState == CalculStateEnum.AquireOperand1)
            {
                calcule.Operand1 = Convert.ToDouble(resultat.Text);
                resultat.Clear();
                calcule.Operation = (sender as Button).Text;
                calcule.CalculState = CalculStateEnum.BeginAquireOperand2;
            }
        }

        private void buttonEqual_onClick(object sender, EventArgs e)
        {
            if(calcule.CalculState == CalculStateEnum.AquireOperand2)
            {
                calcule.Openrad2 = Convert.ToDouble(resultat.Text);
                resultat.Clear();
                resultat.Text = Convert.ToString(calcule.Calculate());
                calcule.CalculState = CalculStateEnum.Calculation;
            }
        }
    }
}