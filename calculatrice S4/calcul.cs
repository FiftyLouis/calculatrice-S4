using System;
using System.Data;
using System.Text.RegularExpressions;

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

        public String result{ get; set; }


        public Calcul()
        {
            this.result = string.Empty;
        }

        public double Calculate()
        {
            /*Regex add = new Regex(@"(?<numberA>\d+)\+(?<numberB>\d+)");

            if (add.IsMatch(this.result))
            {
               string[] operands =  Regex.Split(result, @"\s+");
               double n0 = Convert.ToDouble(operands[0]);
               double n1 = Convert.ToDouble(operands[1]);
                Console.WriteLine(n1 + n0);
            }*/

            return Convert.ToDouble(new DataTable().Compute(result, null));

        }
    }
}