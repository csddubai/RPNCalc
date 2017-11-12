using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RPNCalc
{
    [TestFixture]
    class TestRPNClass
    {
        [Test]
        public void TestCalculate()
        {
            string expr = "2,2,+,3,-";
            RPN rpn = new RPN();
            Assert.AreEqual(12, rpn.calculate(expr));

        }

        [Test]
        public void TestStringForValidLength()
        {
            try
            {
                RPN rpn = new RPN();
                string expr = "2,2*";
                Assert.Ignore(rpn.calculate(expr).ToString());  
            }
            catch (Exception exp)
            {
                Assert.AreEqual("Expression should have at least 3 characters", exp.Message);

            }


        }

        [Test]
        public void TestStringForCommas()
        {
            try
            {
                RPN rpn = new RPN();
                string expr = "2,2*";
                Assert.Ignore(rpn.calculate(expr).ToString());
            }
            catch (Exception exp)
            {
                Assert.AreEqual("Expression should have at least two commas", exp.Message);

            }


        }

        [Test]
        public void TestStack()
        {
                RPN rpn = new RPN();
                string expr = "2,2,*,5";
                string[] exprArray = new string[expr.Length];
                exprArray= expr.Split(',');
                string[] exprArrayReverse =  exprArray.Reverse().ToArray();

                Stack<string> stack = rpn.GetStackFromArray(exprArray);
                string[] exprArrayReverse2 = stack.ToArray();

                Assert.AreEqual(exprArrayReverse2, exprArrayReverse);
                
            


        }

        [Test]
        public void TestPerformoperation()
        {
            RPN rpn = new RPN();
            string operators = "*";
            string operand1 = "3";
            string operand2 = "6";
            Assert.AreEqual(18,rpn.PerformOperation(operators,operand1,operand2));




        }
        [Test]
        public void TestFail()
        {
            string expr = "1,2,3,+,-";//2,2,+,3,-,2,+";
            RPN rpn = new RPN();
            Assert.AreEqual(-4, rpn.calculate(expr));

        }


    }
}
