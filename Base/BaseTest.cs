using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework.Interfaces;
using System.IO;

namespace AutomationExerciseTests.Base;

public class BaseTest : PageTest
{
    public override BrowserNewContextOptions ContextOptions()
    {
        return new BrowserNewContextOptions
        {
            RecordVideoDir = "Videos/",
            ViewportSize = new ViewportSize
            {
                Width = 1920,
                Height = 1080
            }
        };
    }

    [SetUp]
    public void BaseSetUp()
    {
        Page.SetDefaultTimeout(60000);
    }

    [TearDown]
    public async Task TakeScreenshotOnFailure()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
        {
            Directory.CreateDirectory("Screenshots");

            var fileName =
                $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:yyyyMMdd_HHmmss}.png";

            await Page.ScreenshotAsync(new()
            {
                Path = $"Screenshots/{fileName}",
                FullPage = true
            });
        }
    }
}