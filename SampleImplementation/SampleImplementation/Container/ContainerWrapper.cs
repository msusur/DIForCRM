using Microsoft.Xrm.Sdk;

namespace SampleImplementation.Container
{
    public class ContainerWrapper : IDependencyResolver
    {
        public IPluginExecutionContext PluginContext { get; set; }

        public IDependencyResolver Resolver { get; set; }

        public void Register<TInterface, TClass>()
        {
            Resolver.Register<TInterface, TClass>();
        }

        public TInterface Resolve<TInterface>()
        {
            return Resolver.Resolve<TInterface>();
        }
    }
}