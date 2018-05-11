using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            

            switch (DropDownList1.Text)
            {
                case "+":
                    Label1.Text = $"{(Double.Parse(TextBox1.Text) + Double.Parse(TextBox2.Text)):0.##}";
                    break;
                case "-":
                    Label1.Text = $"{(Double.Parse(TextBox1.Text) - Double.Parse(TextBox2.Text)):0.##}";
                    break;
                case "*":
                    Label1.Text = $"{(Double.Parse(TextBox1.Text) * Double.Parse(TextBox2.Text)):0.##}";
                    break;
                case "/":
                    Label1.Text = $"{(Double.Parse(TextBox1.Text) / Double.Parse(TextBox2.Text)):0.##}";
                    break;
                default:
                    break;
            }
        }
    }
}