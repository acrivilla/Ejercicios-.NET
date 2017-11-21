using Microsoft.Practices.Unity;
using Unity.Wcf;

namespace LibreriaServiciosWCF
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
			container
                .RegisterType<IService1, Service1>()
                .RegisterType<ICustomerRepository, CustomerRepository>();
        }
    }    
}