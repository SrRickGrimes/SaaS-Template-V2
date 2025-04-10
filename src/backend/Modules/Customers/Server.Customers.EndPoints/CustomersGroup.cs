using FastEndpoints;

namespace Server.Customers.EndPoints
{
    internal class CustomersGroup : Group
    {
        public CustomersGroup()
        {
            Configure(nameof(Customers).ToLower(), _ =>
            {

            });
        }
    }
}
