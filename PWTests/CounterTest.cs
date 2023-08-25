using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PWTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
[Category("Counter")]
public class CounterTest : PageTest
{
    [Test]
    public async Task Counter_Increments_WhenBtnClicked()
    {
        await Context.Tracing.StartAsync(new (){
            Screenshots = true,
            Snapshots = true,
            Sources = true
        });        
        
        // Null check for environment otherwise to got localhost
        await Page.GotoAsync("https://test.d2rqvn71lrkvxm.amplifyapp.com");
        
        await Page.GetByRole(AriaRole.Link, new() { Name = "Counter" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { Name = "Click me" }).ClickAsync();

        // await Expect(Page.GetByRole(AriaRole.Status)).ToHaveTextAsync("Current count: 1");
        await Expect(Page.GetByText("Current count: 1", new() { Exact = true })).ToBeVisibleAsync();

        await Context.Tracing.StopAsync(new (){
            Path = "trace.zip",
        });
    }
}