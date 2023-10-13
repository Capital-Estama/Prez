using System.ComponentModel.DataAnnotations;

namespace Customer.Models;

public class Customer 
{
    [Key]
    public int Id {get; set;}
    [Required]
    public string Name {get; set;}
    [Range(1, 150)]
    public int Age {get; set;}
    public DateTime CreatedAt  {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;
}