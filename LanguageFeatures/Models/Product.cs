namespace WebApplication16.Models;

public class Product
{
    public Product(bool inStock = true)
    {
        InStock = inStock;
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; } = "Watersport";
    public Product Related { get; set; }
    public bool InStock { get; } = true;
    public bool NameBeginsWithS => Name[0] == 'S';

    public static Product[] GetProducts()
    {
        Product kayak = new Product()
        {
            Name = "Kayak",
            Price = 275m,
            Category = "Water Craft"
        };
        Product lifejacet = new Product(false)
        {
            Name = "LifeJacet",
            Price = 48.95m
        };
        kayak.Related = lifejacet;
        return new Product[] {kayak, lifejacet, null};
    }
}