using System.ComponentModel.DataAnnotations;

namespace Nhom1_AG.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Shoe> Shoes { get; set; } = new HashSet<Shoe>();

    }
}
