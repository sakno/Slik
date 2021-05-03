using Containerd.Services.Version.V1;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Slik.Cord.IntegrationTests
{
    [TestClass]
    public class VersionServiceTests : ServiceTestsBase
    {
        [TestMethod]
        [DataRow("v1.4.4")]
        public async Task Version_ReturnsExpectedVersion(string expectedVersion)
        {
            var client = new Version.VersionClient(Fixture.Channel);
            var response = await client.VersionAsync(new Empty(), Fixture.Headers);
            Assert.IsTrue(response.Version.Equals(expectedVersion));
        }
    }
}
