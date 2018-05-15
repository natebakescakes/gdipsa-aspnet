using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Default : System.Web.UI.Page
    {
        int count;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["ct"] = 0;
            }

            int count = (int)ViewState["ct"];
            count++;
            ViewState["ct"] = count;
            Label1.Text = count.ToString();
        }
    }
}