using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IIdentity id = User.Identity;
            Label1.Text = $"IsAuthenticated:{id.IsAuthenticated},Name:{id.Name},Type:{id.AuthenticationType}";
        }
    }
}