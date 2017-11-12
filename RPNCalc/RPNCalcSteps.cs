using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
namespace RPNCalc
{
    [Binding]
    public class RPNCalcSteps
    {
        string expression = "";
        [Given(@"User enters ""(.*)""")]
        public void GivenUserEnters(string p0)
        {
            expression = p0;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            RPN obj = new RPN();
            Assert.AreEqual(p0, obj.calculate(expression));
        }
    }
}
