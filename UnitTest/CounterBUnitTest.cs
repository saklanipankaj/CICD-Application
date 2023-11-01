using DotNetApp.Pages;
using Bunit;
using System.Diagnostics.Metrics;

namespace UnitTest
{
    public class CounterBUnitTest : TestContext
    {
        [Fact]
        public void CounterShouldIncreamentWhenClicked()
        {
            var cut = RenderComponent<Counter>();

            cut.Find("button").Click();
            cut.Find("p").MarkupMatches("<p role=\"Status\">Current count: 1</p>");
        }

        [Fact]
        public void CounterShouldIncreamentByValueWhenClicked()
        {
            var cut = RenderComponent<Counter>(parameters => parameters.Add(p=> p.IncrementAmount, 2));

            cut.Find("button").Click();
            cut.Find("p").MarkupMatches("<p role=\"Status\">Current count: 2</p>");
        }
        
    }
}