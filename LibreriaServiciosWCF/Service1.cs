using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LibreriaServiciosWCF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        private readonly ICustomerRepository _customerRepository;

        public Service1(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public GetCustomerResponse GetCustomer(GetCustomerRequest request)
        {
            var query = from customer in _customerRepository.Query()
                        where customer.Id == request.CustomerId
                        select new GetCustomerResponse
                        {
                            FirstName = customer.FirstName,
                            LastName = customer.LastName
                        };

            return query.FirstOrDefault();
        }
    }
}
