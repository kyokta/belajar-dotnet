using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BelajarCRUD.Models;

[Table("customers")]
public class Customer
{
    [Key]
    [Column("customerID")] 
    public int CustomerID { get; set; }

    [AllowNull]
    [Column("customerName")] 
    public string CustomerName { get; set; }

    [AllowNull]
    [Column("email")] 
    public string Email { get; set; }

    [Column("birthDate")] 
    public DateTime BirthDate { get; set; }
}