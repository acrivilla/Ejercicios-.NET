using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LibreriaServiciosWCF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        GetCustomerResponse GetCustomer(GetCustomerRequest request);

        // TODO: agregue aquí sus operaciones de servicio
    }

}
