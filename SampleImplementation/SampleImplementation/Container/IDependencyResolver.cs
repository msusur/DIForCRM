namespace SampleImplementation.Container
{
    public interface IDependencyResolver
    {
        void Register<TInterface, TClass>();

        TInterface Resolve<TInterface>();
    }
}