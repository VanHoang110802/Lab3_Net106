using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lab3_Net106.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        // Một danh mục sản phẩm có nhiều sản phẩm:
        //[JsonIgnore]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
