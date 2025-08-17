using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BelajarCRUD.Models;

[Table("products")]
public class Product
{
    [Key]
    [Column("productID")]
    public int ProductID { get; set; }

    [AllowNull]
    [Column("productName")]
    public string ProductName { get; set; }

    [AllowNull]
    [Column("imageUrl")]
    public string ImageUrl { get; set; }

    [AllowNull]
    [Column("description")]
    public string Description { get; set; }

    [Column("price")]
    public decimal Price { get; set; }

    [Column("stock")]
    public int Stock { get; set; }
}