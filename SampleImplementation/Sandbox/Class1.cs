using System;
using Moq;
using SampleImplementation.Plugins;
using Xunit;

namespace Sandbox
{
    public class DepedencySampleTestish
    {
        [Fact]
        public void ShouldWork()
        {
            var plugin = new MyPlugin();
            var serviceProviderMock = new Mock<IServiceProvider>();

            plugin.Execute(serviceProviderMock.Object);

        }
    }
}
