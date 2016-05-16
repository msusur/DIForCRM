using System;
using Microsoft.Xrm.Sdk;
using SampleImplementation.Container;
using SampleImplementation.Services;

namespace SampleImplementation.Plugins
{
    public abstract class SuperPlugin : IPlugin
    {
        private static readonly Lazy<IDependencyResolver> DependencyResolverTrunk = new Lazy<IDependencyResolver>(ResolverFactory);

        public void Execute(IServiceProvider serviceProvider)
        {
            // initialize a static container instance if not available
            var containerWrapper = new ContainerWrapper
            {
                PluginContext = serviceProvider.GetService(typeof(IPluginExecutionContext)) as IPluginExecutionContext,
                Resolver = DependencyResolverTrunk.Value
            };
            OnExecution(containerWrapper);
        }

        protected abstract void OnExecution(IDependencyResolver resolver);

        private static IDependencyResolver ResolverFactory()
        {
            var resolver = new ResolverInstance();
            Setup(resolver);
            return resolver;
        }

        private static void Setup(IDependencyResolver resolver)
        {
            resolver.Register<IService, Service>();
        }
    }
}