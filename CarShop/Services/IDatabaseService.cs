using CarShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Services
{
    public interface IDatabaseService
    {
        Task InitializeAsync();

        Task<List<Item>> GetItemsAsync();
        Task<int> AddItemAsync(Item item);
        Task<int> UpdateItemAsync(Item item);
        Task<int> DeleteItemAsync(Item item);
    }
}
