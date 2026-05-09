using AutomationExerciseTests.Base;
using AutomationExerciseTests.Pages;
using System.Text.RegularExpressions;

namespace AutomationExerciseTests.Tests;

public class HomePageTests : BaseTest
{
    private HomePage _homePage = null!;

    [SetUp]
    public void SetupPage()
    {
        _homePage = new HomePage(Page);
    }

    [Test]
    public async Task VerifyHomePageLoads()
    {
        await _homePage.GoToHomePage();
        await Expect(Page).ToHaveTitleAsync(new Regex("Automation"));
    }

    [Test]
    public async Task VerifyTestCasesPage()
    {
        await _homePage.GoToTestCasesPage();
        await Expect(Page).ToHaveURLAsync(new Regex("test_cases"));
    }

    [Test]
    public async Task VerifyProductsPage()
    {
        await _homePage.GoToProductsPage();
        await Expect(Page).ToHaveURLAsync(new Regex("products"));
    }

    [Test]
    public async Task VerifyLoginPage()
    {
        await _homePage.GoToLoginPage();
        await Expect(Page).ToHaveURLAsync(new Regex("login"));
    }

    [Test]
    public async Task VerifyContactUsPage()
    {
        await _homePage.GoToContactUsPage();
        await Expect(Page).ToHaveURLAsync(new Regex("contact_us"));
    }

    [Test]
    public async Task VerifyCartPage()
    {
        await _homePage.GoToCartPage();
        await Expect(Page).ToHaveURLAsync(new Regex("view_cart"));
    }

    [Test]
    public async Task VerifyApiListPage()
    {
        await _homePage.GoToApiListPage();
        await Expect(Page).ToHaveURLAsync(new Regex("api_list"));
    }

    [Test]
    public async Task VerifyProductDetailsPage()
    {
        await _homePage.GoToProductDetailsPage();
        await Expect(Page).ToHaveURLAsync(new Regex("product_details/1"));
    }

    [Test]
    public async Task VerifyBrandProductsPage()
    {
        await _homePage.GoToBrandProductsPage();
        await Expect(Page).ToHaveURLAsync(new Regex("brand_products/Polo"));
    }

    [Test]
    public async Task VerifyCategoryProductsPage()
    {
        await _homePage.GoToCategoryProductsPage();
        await Expect(Page).ToHaveURLAsync(new Regex("category_products/1"));
    }
    [Test]
    public async Task VerifyLoginFormFields()
    {
        await _homePage.GoToLoginPage();

        await Expect(Page.Locator("input[data-qa='login-email']")).ToBeVisibleAsync();
        await Expect(Page.Locator("input[data-qa='login-password']")).ToBeVisibleAsync();
        await Expect(Page.Locator("button[data-qa='login-button']")).ToBeVisibleAsync();
    }

    [Test]
    public async Task VerifySearchProductField()
    {
        await _homePage.GoToProductsPage();

        await Expect(Page.Locator("#search_product")).ToBeVisibleAsync();
        await Expect(Page.Locator("#submit_search")).ToBeVisibleAsync();
    }

    [Test]
    public async Task VerifyCartPageContent()
    {
        await _homePage.GoToCartPage();

        await Expect(Page).ToHaveURLAsync(new Regex("view_cart"));
        await Expect(Page.Locator("body")).ToBeVisibleAsync();
    }
}