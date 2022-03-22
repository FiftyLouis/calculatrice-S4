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

        private double result;

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
            operand1 = 0;
            operand2 = 0;
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