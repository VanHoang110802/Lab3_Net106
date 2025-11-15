using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lab3_Net106.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Giá sản phẩm phải >= 0")]
        public int Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Số lượng tồn kho không được âm")]
        public int Stock { get; set; } = 0;

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Required]
        public int CategoryId { get; set; }

        /* Nếu để nguyên, khi serialize (vòng tuần hoàn lặp lại) JSON sẽ tạo vòng lặp vô hạn:
         Product -> Category -> Products -> Product -> Category... => gây lỗi 500
         Thêm [JsonIgnore] để bỏ qua property này khi trả về JSON tạm cắt đứt vòng lặp vô hạn, nhớ phải pmc lại*/
        [JsonIgnore]
        public Category? Category { get; set; }
    }
}
