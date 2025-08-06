using CarShop.Models;
using SQLite;

namespace CarShop.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly SQLiteAsyncConnection _db;

        public DatabaseService()
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "carshop.db");
            _db = new SQLiteAsyncConnection(dbPath);
        }

        public async Task InitializeAsync()
        {
            await _db.CreateTableAsync<Item>();
        }

        public Task<List<Item>> GetItemsAsync() =>
            _db.Table<Item>().ToListAsync();

        public Task<int> AddItemAsync(Item item) =>
            _db.InsertAsync(item);

        public Task<int> UpdateItemAsync(Item item) =>
            _db.UpdateAsync(item);

        public Task<int> DeleteItemAsync(Item item) =>
            _db.DeleteAsync(item);
    }
}