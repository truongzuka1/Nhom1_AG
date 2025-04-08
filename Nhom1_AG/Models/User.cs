using Microsoft.AspNetCore.Identity;

namespace Nhom1_AG.Models
{
   

        public class User : IdentityUser
        {
            public string Role { get; set; } = string.Empty;

            public virtual ICollection<Cart> Carts { get; set; } = new HashSet<Cart>();
            public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
            public virtual ICollection<Voucher> Vouchers { get; set; } = new HashSet<Voucher>();
        }
    
}
