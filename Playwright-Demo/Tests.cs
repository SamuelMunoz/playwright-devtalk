using System.Text.RegularExpressions;
using Microsoft.Playwright.NUnit;

namespace Playwright_Demo;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task HomePageHasGoogleInItsTitle()
    {
        await Page.GotoAsync("https://google.com");
        await Expect(Page).ToHaveTitleAsync(new Regex("Google"));
    }
}