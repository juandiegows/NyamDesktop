//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NyamDesktop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDish
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int DishesID { get; set; }
    
        public virtual Dish Dish { get; set; }
        public virtual Order Order { get; set; }
    }
}