using Soenneker.Tests.HostedUnit;

namespace Soenneker.Docusign.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class DocusignOpenApiClientTests : HostedUnitTest
{
    public DocusignOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
