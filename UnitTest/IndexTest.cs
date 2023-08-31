using DotNetApp.Pages;
using Bunit;
using System.Diagnostics.Metrics;

namespace UnitTest
{
    public class IndexUnitTest : TestContext
    {
        [Fact]
        public void IndexRenderedProperly()
        {
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<DotNetApp.Pages.Index>();
            cut.Find("h1").MarkupMatches("<h1>Nature Lover</h1>");
        }
    }
}