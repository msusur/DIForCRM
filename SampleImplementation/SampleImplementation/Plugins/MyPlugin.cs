using Microsoft.Xrm.Sdk;
using SampleImplementation.Container;
using SampleImplementation.Services;

namespace SampleImplementation.Plugins
{
    public class MyPlugin : SuperPlugin, IPlugin
    { //you need to specify the IPlugin here as well because of a bug on Plugin Registration Tool.

        protected override void OnExecution(IDependencyResolver resolver)
        {
            var service = resolver.Resolve<IService>();
        }
    }
}