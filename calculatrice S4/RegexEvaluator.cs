using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace calculatrice_S4
{
    public class RegexEvaluator
    {


        public int PriorityGroup { get; set; }
        public Regex Regex { get; set; }


        public RegexEvaluator(String pattern, int priorityGroup)
        {
            Regex = new Regex(pattern, RegexOptions.Compiled);
            PriorityGroup = priorityGroup;
        }
    }
}
