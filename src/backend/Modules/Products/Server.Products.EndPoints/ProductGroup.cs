using FastEndpoints;

namespace Server.Products.EndPoints;

internal class ProductGroup:Group
{
    public ProductGroup() 
    {
        Configure("products", _ =>
        {

        });
    }
}
