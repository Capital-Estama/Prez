using System.ComponentModel.DataAnnotations;

namespace Category.Models;

public class Category 
{
    [Key]
    public int CategoryId {get; set;}
    [Required]
    public string CategoryName {get; set;}
}