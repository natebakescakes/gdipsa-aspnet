//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Workshop1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int DishId { get; set; }
        public int DishSize { get; set; }
        public Nullable<int> DishOption { get; set; }
    
        public virtual Dish Dish { get; set; }
        public virtual DishOption DishOption1 { get; set; }
        public virtual DishSize DishSize1 { get; set; }
    }
}
