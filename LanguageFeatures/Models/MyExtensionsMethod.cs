using System.Collections;

namespace WebApplication16.Models;

public static class MyExtensionsMethod{
    public static decimal TotalPricec(this  IEnumerable<Product> products)
    {
        decimal total = 0;
        foreach (Product product in products)
        {
            total += product?.Price ?? 0;
        }
    
        return total;
    }

    public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productsEnum, decimal minimumPrice)
    {
        foreach (var priduct in productsEnum)
        {
            if ((priduct?.Price??0)>=minimumPrice)
            {
                yield return priduct;
            }
        }
    }

    public static IEnumerable<Product> FilterByName(this IEnumerable<Product> productsEnum, char firstLetter)
    {
        foreach (var prod in productsEnum)
        {
            if (prod?.Name[0]==firstLetter)
            {
                yield return prod;
            }
        }
        
    }

    public static IEnumerable<Product> Filter(this IEnumerable<Product> productsEnum, Func<Product, bool> selector)
    {
        foreach (var prod in productsEnum)
        {
            if (selector(prod))
            {
                yield return prod;
            }
        }
    }





}