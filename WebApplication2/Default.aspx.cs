using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s1 = Request.Params["Text1"];
            string s2 = Text2.Value;
            string s3 = TextBox1.Text;

            Label1.Text = $"{DateTime.Now.ToString()}:{s1}/{s2}/{s3}";
        }
    }
}