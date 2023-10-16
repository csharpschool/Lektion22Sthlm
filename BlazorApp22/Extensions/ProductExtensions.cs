using BlazorApp22.Classes;

namespace BlazorApp22.Extensions;

public static class ProductExtensions
{
    public static double GetVat(this Categories category)
    {
        switch (category)
        {
            case Categories.Books: return 0.06;
            case Categories.Food: return 0.12;
            case Categories.Electronics: return 0.25;
            default: return 0.25;
        }
    }

    /*public static Product CalculatePrice(this Product product)
    {
        if (product == null) throw new ArgumentNullException("No product available.");
        var vat = product.Category.GetVat();
        product.Total = product.Price + product.Price * vat;
        return product;
    }

    public static Product CalculateTotal(this Product product)
    {
        if (product == null) throw new ArgumentNullException("No product available.");
        product.Total *= product.Count;
        return product;
    }*/

    public static double CalculatePrice(this Product product)
    {
        if (product == null) throw new ArgumentNullException("No product available.");
        var vat = product.Category.GetVat();
        return product.Price + product.Price * vat;
    }

    public static double CalculateTotal(this double price, int count)
    {
        return price *= count;
    }



}
