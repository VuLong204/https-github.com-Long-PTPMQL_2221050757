using System.ComponentModel.DataAnnotations;

namespace PTPMQL_MVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
        [StringLength(100, ErrorMessage = "Tên sản phẩm không được vượt quá 100 ký tự")]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Vui lòng nhập giá sản phẩm")]
        [Range(1000, 1000000000, ErrorMessage = "Giá phải từ 1.000 đến 1.000.000.000 VNĐ")]
        [Display(Name = "Giá bán")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập danh mục")]
        [StringLength(50, ErrorMessage = "Danh mục không được vượt quá 50 ký tự")]
        [Display(Name = "Danh mục")]
        public string Category { get; set; } = "";
    }
}