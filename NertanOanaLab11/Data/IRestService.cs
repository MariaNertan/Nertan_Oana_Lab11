using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NertanOanaLab11;
using NertanOanaLab11.Models;

namespace NertanOanaLab11.Data
{
    public interface IRestService 
    { 
        Task<List<ShopList>> RefreshDataAsync(); 
        Task SaveShopListAsync(ShopList item, bool isNewItem); 
        Task DeleteShopListAsync(int id); 
    }
}
