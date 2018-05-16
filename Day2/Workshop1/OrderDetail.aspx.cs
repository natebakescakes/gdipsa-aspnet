using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Workshop1
{
    public partial class OrderDetail : System.Web.UI.Page
    {
        FoodBrendaEntities context;
        int orderId;
        Order order;

        protected void Page_Load(object sender, EventArgs e)
        {
            context = new FoodBrendaEntities();

            orderId = Int32.Parse(Request.QueryString["id"]);
            order = context.Orders.Where(x => x.Id == orderId).FirstOrDefault();

            OrderIdLabel.Text = orderId.ToString();
            UserIdTextBox.Text = order.UserId.ToString();
            DishTextBox.Text = order.Dish.Name;
            SizeTextBox.Text = order.DishSize.Size;

            foreach (var option in context.DishOptions)
            {
                OptionRadioButtonList.Items.Add(new ListItem(option.OptionName, option.Id.ToString()));

                if (option.Id == order.DishOption.Id)
                {
                    OptionRadioButtonList.Items[OptionRadioButtonList.Items.Count - 1].Selected = true;
                }
            }
        }
    }
}