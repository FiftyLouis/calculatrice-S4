namespace Calculatrice
{
    public enum CalculStateEnum
    {
        AquireOperand1,
        BeginAquireOperand2,
        AquireOperand2,
        Calculation
    }

    public class Calcul
    {

        /// <summary>
        /// Resultat du Calcul
        /// </summary>
        private double result;

        /// <summary>
        /// Etat du Calcul
        /// </summary>
        private CalculStateEnum calculState;
        public CalculStateEnum CalculState
        {
            get { return calculState; }
            set { calculState = value; }
        }

        private double operand1;
        public double Operand1
        {
            get { return operand1; }
            set { operand1 = value; }
        }

        private double operand2;
        public double Openrad2
        {
            get { return operand2; }
            set { operand2 = value; }
        }

        private string operation;
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public Calcul()
        {
            calculState = CalculStateEnum.AquireOperand1;
            operand1 = Double.PositiveInfinity;
            operand2 = Double.PositiveInfinity;
            operation = string.Empty;
        }

        public double Calculate()
        {
            if (operation == "+")
            {
                result = operand1 + operand2;
            }
            if (operation == "-")
            {
                result = operand1 - operand2;
            }
            if (operation == "*")
            {
                result = operand1 * operand2;
            }
            if (operation == "/")
            {
                result = operand1 / operand2;
            }
            if (operation == "%")
            {

            }
            return result;
        }
    }
}