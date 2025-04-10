using FastEndpoints;

namespace Server.ModuleName.EndPoints;

internal class ProductGroup:Group
{
    public ProductGroup() 
    {
        Configure("products", _ =>
        {

        });
    }
}
