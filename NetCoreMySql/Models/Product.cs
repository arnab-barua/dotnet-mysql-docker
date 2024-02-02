using System.ComponentModel.DataAnnotations;

namespace NetCoreMySql.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
