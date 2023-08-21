using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

namespace UAT
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    [Category("Counter")]
    public class CounterTest : PageTest
    {
        [Test]
        public async Task MyTest()
        {
            await Context.Tracing.StartAsync(new (){
                Screenshots = true,
                Snapshots = true,
                Sources = true
            });        
            
            // Null check for environment otherwise to got localhost
            await Page.GotoAsync(Environment.GetEnvironmentVariable("https://main.d2rqvn71lrkvxm.amplifyapp.com");
            
            await Page.GetByRole(AriaRole.Link, new() { Name = "Counter" }).ClickAsync();

            await Page.GetByRole(AriaRole.Button, new() { Name = "Click me" }).ClickAsync();

            // await Expect(Page.GetByRole(AriaRole.Status)).ToHaveTextAsync("Current count: 1");
            await Expect(Page.GetByText("Current count: 1", new() { Exact = true })).ToBeVisibleAsync();

            await Context.Tracing.StopAsync(new (){
                Path = "trace.zip",
            });
        }
    }
}