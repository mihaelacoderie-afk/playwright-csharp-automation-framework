using Microsoft.Playwright;

namespace AutomationExerciseTests.Pages;

public class HomePage
{
    private readonly IPage _page;
    private const string BaseUrl = "https://automationexercise.com/";

    public HomePage(IPage page)
    {
        _page = page;
    }

    public async Task GoToHomePage()
    {
        await _page.GotoAsync(BaseUrl);
    }

    public async Task GoToTestCasesPage()
    {
        await _page.GotoAsync($"{BaseUrl}test_cases");
    }

    public async Task GoToProductsPage()
    {
        await _page.GotoAsync($"{BaseUrl}products");
    }

    public async Task GoToLoginPage()
    {
        await _page.GotoAsync($"{BaseUrl}login");
    }

    public async Task GoToContactUsPage()
    {
        await _page.GotoAsync($"{BaseUrl}contact_us");
    }

    public async Task GoToCartPage()
    {
        await _page.GotoAsync($"{BaseUrl}view_cart");
    }

    public async Task GoToApiListPage()
    {
        await _page.GotoAsync($"{BaseUrl}api_list");
    }

    public async Task GoToProductDetailsPage()
    {
        await _page.GotoAsync($"{BaseUrl}product_details/1");
    }

    public async Task GoToBrandProductsPage()
    {
        await _page.GotoAsync($"{BaseUrl}brand_products/Polo");
    }

    public async Task GoToCategoryProductsPage()
    {
        await _page.GotoAsync($"{BaseUrl}category_products/1");
    }
    public async Task LoginWithInvalidCredentials(string email, string password)
    {
        await GoToLoginPage();

        await _page.Locator("input[data-qa='login-email']").FillAsync(email);
        await _page.Locator("input[data-qa='login-password']").FillAsync(password);
        await _page.Locator("button[data-qa='login-button']").ClickAsync();
    }

    public async Task SearchProduct(string productName)
    {
        await GoToProductsPage();

        await _page.Locator("#search_product").FillAsync(productName);
        await _page.Locator("#submit_search").ClickAsync();
    }

    public async Task AddFirstProductToCart()
    {
        await GoToProductsPage();

        await _page.Locator(".product-image-wrapper").First.HoverAsync();
        await _page.Locator(".overlay-content a.add-to-cart").First.ClickAsync();
        await _page.GetByRole(AriaRole.Link, new() { Name = "View Cart" }).ClickAsync();
    }
}