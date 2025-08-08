namespace CarShop.Models
{
    public class ReceiptItem
    {
        public bool IsHeader { get; set; } = false;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Quantity { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;

        public int QuantityValue => int.TryParse(Quantity, out var q) ? q : 0;
        public decimal PriceValue => decimal.TryParse(Price, out var p) ? p : 0m;

        public decimal Total => QuantityValue * PriceValue;
    }
}