using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerInventoryCSSAreasADOnet.Data
    {
    public class Inventory
        {

        public int Id { get; set; }

        [Required(ErrorMessage = "Product Number is Required - Max Length 50 chars.")]
        public string ProductNumber { get; set; }

        [Required(ErrorMessage = "Description - Max Length 75 chars.")]
        public string Description { get; set; }
               
        public int ProductCategoryId { get; set; }
        public int VendorId { get; set; }
        public string SellingUnit { get; set; }
        public string StockingUnit { get; set; }
        public int OnHandQty { get; set; }
        public decimal ListPrice { get; set; }
        }
    }
