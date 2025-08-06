using CarShop.Models;

namespace CarShop.Services
{
    public class ItemService : IItemService
    {
        private readonly IDatabaseService _db;

        public ItemService(IDatabaseService db)
        {
            _db = db;
        }

        public Task<List<Item>> GetAllAsync() => _db.GetItemsAsync();

        public async Task<Item> GetByIdAsync(int id)
        {
            var items = await _db.GetItemsAsync();
            return items.FirstOrDefault(i => i.Id == id)!; // or handle null properly
        }

        public Task AddAsync(Item item) => _db.AddItemAsync(item);

        public Task UpdateAsync(Item item) => _db.UpdateItemAsync(item);

        public Task DeleteAsync(Item item) => _db.DeleteItemAsync(item);
    }
}