using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Calculatrice
{

    public class Calcul
    {
        public enum regex
        {
            add,
            sub,
            div,
            mul,
            nothing
        }

        public enum state
        {
            beforeResult,
            afterResult
        }

        public String result{ get; set; }

        public regex currentRegex { get; set; }

        public state currentState { get; set; }


        public Calcul()
        {
            this.result = string.Empty;
            this.currentRegex = regex.nothing;
            this.currentState = state.beforeResult;
        }

        public double Calculate()
        {
            Regex add = new Regex(@"(?<numberA>\d+)\+(?<numberB>\d+)");
            Regex sous = new Regex(@"(?<numberA>-?\d+\.?\d*)\s*\-\s*(?<numberB>-?\d+\.?\d*)");
            Regex mul = new Regex(@"(?<numberA>-?\d+\.?\d*)\s*\*\s*(?<numberB>-?\d+\.?\d*)");
            Regex div = new Regex(@"(?<numberA>-?\d+\.?\d*)\s*\/\s*(?<numberB>-?\d+\.?\d*)");

            if (add.IsMatch(this.result))
            {
                this.currentRegex = regex.add;
                return Convert.ToDouble(new DataTable().Compute(result, null));
            } 
            else if (sous.IsMatch(this.result))
            {
                this.currentRegex = regex.sub;
                return Convert.ToDouble(new DataTable().Compute(result, null));
            }
            else if (mul.IsMatch(this.result))
            {
                this.currentRegex = regex.mul;
                return Convert.ToDouble(new DataTable().Compute(result, null));
            }
            else if(div.IsMatch(this.result))
            {
                this.currentRegex= regex.div;
                return Convert.ToDouble(new DataTable().Compute(result, null));
            }
            else
            {
                return Convert.ToDouble(new DataTable().Compute(result, null));
            }

        }
    }
}