using System.Runtime.Serialization;

namespace LibreriaServiciosWCF
{
    [DataContract]
    public class GetCustomerResponse
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }
}