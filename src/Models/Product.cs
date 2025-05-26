namespace ProductsApi.Models;

public class Product
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category {get; set; }
    public long Proteins { get; set; }
    public long Fats { get; set; }
    public long Carbohydrates { get; set; }
}
