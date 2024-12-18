using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nertan_Oana_Lab11;
using Nertan_Oana_Lab11.Models;

namespace Nertan_Oana_Lab11.Data
{
    public class ShoppingListDatabase
    {
        IRestService restService; 
        public ShoppingListDatabase(IRestService service) 
        { 
            restService = service; 
        }
        public Task<List<ShopList>> GetShopListsAsync()
        { 
            return restService.RefreshDataAsync(); 
        }

        public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
        {
            return restService.SaveShopListAsync(item, isNewItem);
        }
        public Task DeleteShopListAsync(ShopList item) 
        { 
            return restService.DeleteShopListAsync(item.ID); 
        }


    }
}
