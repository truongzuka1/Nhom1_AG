namespace Nhom1_AG.ViewModels
{
    public class UpdateOrderViewModel
    {
        public int OrderId { get; set; }
        public string Status { get; set; }  // "Pending", "Shipped", "Delivered", "Cancelled"
    }
}
