using System.ComponentModel.DataAnnotations;

namespace Nhom1_AG.ViewModels
{
    public class VoucherViewModel
    {
        public int VoucherId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Voucher Code")]
        public string Code { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid discount amount.")]
        [Display(Name = "Discount Amount")]
        public decimal DiscountAmount { get; set; }

        [Required]
        [Display(Name = "Expiry Date")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [Display(Name = "User")]
        public int UserId { get; set; }
    }
}
