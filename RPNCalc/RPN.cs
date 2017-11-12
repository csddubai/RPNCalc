using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RPNCalc
{
    public class RPN
    {

        public int calculate(string expr)
        {
            int result = 0;

            if (expr.Length < 5)
            {
                throw new Exception("Expression should have at least 5 characters");

            }

            string[] exprArray = new string[expr.Length];

            if (!expr.Contains(","))
            {
                throw new Exception("Expression should have at least two commas");

            }
            exprArray = expr.Split(',');
            //exprArray = exprArray.Reverse().ToArray();

            Stack<string> stack = new Stack<string>();
            string operatorStr;
            string operand1;
            string operand2;
            foreach (string str in exprArray)
            {
                if(! IsOperator(str))
                {
                    stack.Push(str);
                }
                else
                {
                    operatorStr = str;
                    if (operatorStr != "%")
                    {
                        operand2 = stack.Pop();
                    }
                    else
                        operand2 = "100";
                    
                    operand1 = stack.Pop();
                                        
                    result = PerformOperation(operatorStr, operand1, operand2);
                    stack.Push(result.ToString());

                }
            }
            
            result = Convert.ToInt32(stack.Pop());

            return result;
        }

        public int PerformOperation(string operater, string operand1, string operand2)
        {
            int result = 0;
            switch (operater)
            {
                case "+":
                    result = Convert.ToInt32(operand1) + Convert.ToInt32(operand2);
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

                case "^":
                    result = Convert.ToInt32(Math.Pow(Convert.ToDouble(operand1), Convert.ToDouble(operand2)));
                    break;

                case "%":
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

        public bool IsOperator(string operatorStr)
        {

            if (operatorStr == "+" || operatorStr == "-" || operatorStr == "*" || operatorStr == "/" || operatorStr == "^" || operatorStr == "%")
                return true;
            else
                return false;
        }
    }
}
