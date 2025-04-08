namespace Nhom1_AG.ViewModels
{
    public class CartViewModel
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public List<CartItemViewModel> Items { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class CartItemViewModel
    {
        public int CartItemId { get; set; }
        public int ShoeId { get; set; }
        public string ShoeName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice => Price * Quantity;
    }
}
