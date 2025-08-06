using SQLite;
using System.Windows.Input;

namespace CarShop.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100), NotNull]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        [Ignore]
        public ICommand? EditCommand { get; set; }
    }
}