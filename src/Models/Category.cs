namespace ProductsApi.Models;
using Microsoft.EntityFrameworkCore;


public class Category
{
    public long Id { get; set; }
    public string Name {get; set; }
    // public long ProductId { get; set; }
    // [ForeignKey("ProductId")]
    // public Product Product { get; set; } = null!;
    public ICollection<Product> Products { get; } = new List<Product>();
}