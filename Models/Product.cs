using System.ComponentModel.DataAnnotations;

namespace Prodcut.Models;

public class Product 
{
    [Key]
    public int ProductId {get; set;}
    [Required]
    public string ProductName {get; set;}
    [Required]
    public string Description {get; set;}
    [Required]
    public int CategoryId {get; set;}

}