using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            RPN rpn = new RPN();
            rpn.calculate("2,2,+");
        }
    }
}
