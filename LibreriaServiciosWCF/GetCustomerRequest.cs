using System.Runtime.Serialization;

namespace LibreriaServiciosWCF
{
    [DataContract]
    public class GetCustomerRequest
    {
        [DataMember]
        public int CustomerId { get; set; }
    }
}