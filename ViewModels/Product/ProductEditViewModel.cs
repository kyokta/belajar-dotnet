using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace BelajarCRUD.ViewModels.Product;

public class ProductEditViewModel
{
    public int ProductID { get; set; }

    [Required(ErrorMessage = "Nama produk tidak boleh kosong")]
    [Display(Name = "Nama Produk")]
    public string ProductName { get; set; }

    [Display(Name = "Deskripsi")]
    public string? Description { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Harga harus positif")]
    public decimal Price { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Stok harus positif")]
    public int Stock { get; set; }

    public string? ExistingImageUrl { get; set; }

    [Display(Name = "Gambar Produk Baru (Opsional)")]
    public IFormFile? ImageFile { get; set; }
}