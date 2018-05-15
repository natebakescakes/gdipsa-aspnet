using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Workshop1
{
    public partial class OrderSummary : System.Web.UI.Page
    {
        FoodBrendaEntities context;

        protected void Page_Load(object sender, EventArgs e)
        {
            context = new FoodBrendaEntities();

            if (!IsPostBack)
            {
                foreach (var order in context.Orders)
                {
                    var link = new HyperLink
                    {
                        Text = $"{order.Id} by {order.UserId}",
                        NavigateUrl = $"~/OrderDetail.aspx?id={order.Id}"
                    };

                    OrderPlaceHolder.Controls.Add(link);
                    OrderPlaceHolder.Controls.Add(new LiteralControl("<br />"));
                }
            }
        }
    }
}