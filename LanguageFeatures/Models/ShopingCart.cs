using System.Collections;

namespace WebApplication16.Models;

public class ShopingCart: IProductSelection
{
    private List<Product> _products = new List<Product>();

    public ShopingCart(params Product[] products)
    {
        _products.AddRange(products);
    }
    public IEnumerable<Product> Products
    {
        get => _products;
    }
    // public IEnumerable<Product> Products { get; set; }
    //
    // public IEnumerator<Product> GetEnumerator()
    // {
    //     return Products.GetEnumerator();
    // }
    //
    // IEnumerator IEnumerable.GetEnumerator()
    // {
    //     return GetEnumerator();
    // }

}