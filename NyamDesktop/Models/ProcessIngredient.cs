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
    
    public partial class ProcessIngredient
    {
        public int IngredientsID { get; set; }
        public int ProcessID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Ingredient Ingredient { get; set; }
        public virtual Process Process { get; set; }
    }
}
