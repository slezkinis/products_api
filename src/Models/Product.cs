namespace ProductsApi.Models;
using Microsoft.EntityFrameworkCore;

public class Product
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    // public Category? Category { get; set; }
    public long CategoryId { get; set; }
    public long Proteins { get; set; }
    public long Fats { get; set; }
    public long Carbohydrates { get; set; }
}
