using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerInventoryCSSAreasADOnet.Data
 {
    public class ProductService
        {
        readonly InventoryDataAccessLayer ProductDAL = new InventoryDataAccessLayer();

        public void AddtoInventory(Inventory inventory)
            {
            ProductDAL.AddProduct(inventory);

            }   

        }
 }      

      