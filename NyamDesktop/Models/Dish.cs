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
    
    public partial class Dish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dish()
        {
            this.OrderDishes = new HashSet<OrderDish>();
            this.Recipes = new HashSet<Recipe>();
        }
    
        public int ID { get; set; }
        public string DishName { get; set; }
        public int BaseServings { get; set; }
        public int CategoryID { get; set; }
        public string ImagePath { get; set; }
        public string SourceRecipeLink { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDish> OrderDishes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}