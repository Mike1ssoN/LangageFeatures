using System.Diagnostics;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using WebApplication16.Models;

namespace WebApplication16.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        IProductSelection cart = new ShopingCart(

            new Product {Name = "Kayak", Price = 275m},
            new Product {Name = "Lifejack", Price = 48.95m},
            new Product {Name = "Soccer ball", Price = 19.50m},
            new Product {Name = "Corner falg", Price = 34.95m}
        );
        return View(cart.Names);




// List<string> results = new List<string>();
        //
        // foreach (var p in Product.GetProducts())
        // {
        //     string name = p?.Name ?? "<NoName>";
        //     decimal? price = p?.Price?? 0;
        //     string relatedName = p?.Related?.Name?? "<None>";
        //     results.Add($"Name:{name},Price: {price:C2},Related: {relatedName}");
        // }
        //
        // return View(results);

        // Dictionary<string, Product> result = new Dictionary<string, Product>
        // {
        //     ["Kayal"] = new Product {Name = "Kayak", Price = 275m},
        //     ["Lifejack"] = new Product {Name = "Lifejack", Price = 48.95m}
        // };
        // return View("Index", result.Keys);


        // object[] data = new object [] {275M, 29.95M, "apple", "orange", 100, 0};
        // decimal tottal = 0;
        //
        // for (int i = 0; i < data.Length; i++)
        // {
        //     switch (data[i])
        //     {
        //         case decimal decimalValue:
        //             tottal += decimalValue;
        //             break;
        //         case int intValue when  intValue>50:
        //             tottal += intValue;
        //             break;
        //     }
        // }
        //
        // return View("Index", new string[] {$"Total:{tottal:C2}"});

        // bool FilterByPrice(Product p)
        // {
        //     return (p?.Price ?? 0) >= 20;
        // }
        //
        // ShopingCart cart = new ShopingCart {Products = Product.GetProducts()};
        // Product[] producrArray =
        // {
        //     new Product {Name = "Kayak", Price = 275m},
        //     new Product {Name = "Lifejack", Price = 48.95m},
        //     new Product {Name = "Soccer ball", Price = 19.50m},
        //     new Product {Name = "Corner falg", Price = 34.95m}
        // };
        //
        // // Func<Product,bool> nameFilter = delegate(Product product) { return product?.Name?[0] == 'S';};
        // // decimal priceFiltertotal = producrArray.Filter(FilterByPrice).TotalPricec();
        // // decimal nameFilterTotal = producrArray.Filter(nameFilter).TotalPricec();
        // decimal priceFiltertotal = producrArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPricec();
        // decimal nameFilterTotal = producrArray.Filter(p => p?.Name[0] == 'S').TotalPricec();
        //
        // return View("Index", new string[]
        // {
        //     $"Price Total: {priceFiltertotal:c2}",
        //     $"Name Total: {nameFilterTotal:c2}"
        // });
    }
    
}