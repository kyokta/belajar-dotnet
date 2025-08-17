using System.ComponentModel.DataAnnotations;

namespace BelajarCRUD.ViewModels.Product;

public class ProductCreateViewModel
{
    [Required]
    [Display(Name = "Nama Produk")]
    public string ProductName { get; set; }

    public string? Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public int Stock { get; set; }

    [Display(Name = "Gambar Produk")]
    public IFormFile? ImageFile { get; set; } 
}