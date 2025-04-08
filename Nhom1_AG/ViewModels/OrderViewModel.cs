namespace Nhom1_AG.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public string UserId
        {
            get; set;
        }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }  // "Pending", "Shipped", "Delivered", "Cancelled"
        public List<OrderItemViewModel> Items { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class OrderItemViewModel
    {
        public int OrderItemId { get; set; }
        public int ShoeId { get; set; }
        public string ShoeName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice => Price * Quantity;
    }
}
