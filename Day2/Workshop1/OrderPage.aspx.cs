using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Workshop1
{
    public partial class OrderPage : System.Web.UI.Page
    {
        FoodBrendaEntities context;

        protected void Page_Load(object sender, EventArgs e)
        {
            context = new FoodBrendaEntities();

            foreach (var dish in context.Dishes)
                DishDropDownList.Items.Add(new ListItem(dish.Name, dish.Id.ToString()));

            foreach (var size in context.DishSizes)
                SizeDropDownList.Items.Add(new ListItem(size.Size, size.Id.ToString()));

            foreach (var option in context.DishOptions)
                OptionRadioButtonList.Items.Add(new ListItem(option.OptionName, option.Id.ToString()));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}