using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RPNCalc
{
    class RPN
    {

        public int calculate(string expr)
        {
            int result = 0;

            if (expr.Length < 5)
            {
                throw new Exception("Expression should have at least 5 characters");

            }

            string[] exprArray = new string[expr.Length];

            if (! expr.Contains(","))
            {
                throw new Exception("Expression should have at least two commas");

            }
            exprArray = expr.Split(',');
            exprArray= exprArray.Reverse().ToArray();

            Stack<string> stack = GetStackFromArray(exprArray);
            string operater="";
            string operand1="";
            string operand2="";


              



           

            while (stack.Count > 1)
            {
                operand1 = stack.Pop();
                operand2 = stack.Pop();

                operater = stack.Pop();
                result = PerformOperation(operater, operand1, operand2);
                stack.Push(result.ToString());
                
            }


            result = Convert.ToInt32(stack.Pop());
         
            return result;
        }

        public int PerformOperation( string operater, string operand1, string operand2)
        {
            int result = 0;
            switch(operater)
            {
                case "+":
                    result =  Convert.ToInt32(operand1) + Convert.ToInt32(operand2);
                    break;

                case "-":
                    result = Convert.ToInt32(operand1) - Convert.ToInt32(operand2);
                    break;

                case "*":
                    result = Convert.ToInt32(operand1) * Convert.ToInt32(operand2);
                    break;

                case "/":
                    result = Convert.ToInt32(operand1) / Convert.ToInt32(operand2);
                    break;
            }

            return result;

        }

        public Stack<string> GetStackFromArray(string[] stringArray)
        {

            Stack<String> stack = new Stack<string>();
            stack.Clear();

            foreach (string str in stringArray)
            {
                stack.Push(str);

            }

            return stack;
        }
    }
}
