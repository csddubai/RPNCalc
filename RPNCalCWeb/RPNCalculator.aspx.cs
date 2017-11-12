using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPNCalc;

namespace RPNCalCWeb
{
    public partial class RPNCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string expr = this.TextBox1.Text;
            RPN rpn = new RPN();
            int result = rpn.calculate(expr);

            this.TextBox2.Text = result.ToString();
        }
    }
}