//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab4.Models.Northwind
{
    using Lab4.Models.Annotations;
    using System;
    using System.Collections.Generic;
    using System.Web.DynamicData;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        [Key]
        public int ProductID { get; set; }
        [LimitNumWords(3)]
        [Display (Name="Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Supplier")]
        public Nullable<int> SupplierID { get; set; }
        [Display(Name = "Category")]
        public Nullable<int> CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        [Display(Name = "Unit Price")]
        [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "You must include exactly 2 decimal places (#.##)" )]
        [Range(0, 9999999999999999.99)]
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
