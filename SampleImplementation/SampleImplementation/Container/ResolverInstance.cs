using EasyDependencyInjection.Abstraction;
using EasyDependencyInjection.Easy;

namespace SampleImplementation.Container
{
    internal class ResolverInstance : IDependencyResolver
    {
        private readonly EasyDependencyContainer _container = new EasyDependencyContainer();

        public void Register<TInterface, TClass>()
        {
            _container.RegisterType(typeof(TInterface), typeof(TClass), Registration.RegistrationTypes.Transient);
        }

        public TInterface Resolve<TInterface>()
        {
            return _container.ResolveType<TInterface>();
        }
    }
}