using DotNetApp.Pages;
using Bunit;

namespace UnitTest{
    public class CounterUnitTest: TestContext
    {
        [Fact]
        public void CounterComponentRendersCorrectly(){
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Counter>();
            cut.MarkupMatches("<h1>Counter</h1><p role=\"Status\">Current count: 0</p><button class=\"btn btn-primary\">Click me</button>");
        }

        [Fact]
        public void CounterIncrementsAfterClicked()
        {
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Counter>();
            cut.Find("p").MarkupMatches("<p role=\"Status\">Current count: 0</p>");
            var btnElm  = cut.Find("button");
            btnElm.Click();
            cut.Find("p").MarkupMatches("<p role=\"Status\">Current count: 1</p>");
            btnElm.Click();
            cut.Find("p").MarkupMatches("<p role=\"Status\">Current count: 2</p>");
        }

        [Fact]
        public void CounterResetCounter()
        {
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Counter>();

            cut.Find("p").MarkupMatches("<p role=\"Status\">Current count: 0</p>");
            var btnElm  = cut.Find("button");
            btnElm.Click();
            btnElm.Click();
            cut.Find("p").MarkupMatches("<p role=\"Status\">Current count: 2</p>");
            
            cut.InvokeAsync(() => cut.Instance.ResetCount());
            cut.Find("p").MarkupMatches("<p role=\"Status\">Current count: 0</p>");
        }
    }
}
