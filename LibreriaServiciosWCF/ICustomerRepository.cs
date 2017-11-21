using System.Linq;

namespace LibreriaServiciosWCF
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> Query();
    }
}