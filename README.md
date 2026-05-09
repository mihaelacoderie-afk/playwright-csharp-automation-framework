# Playwright C# Automation Framework

UI Automation Framework built using **Playwright**, **C#**, **NUnit**, and the **Page Object Model** design pattern.

## Tested Application

https://automationexercise.com/

## Technologies Used

- C#
- .NET 8
- Playwright
- NUnit
- Visual Studio 2022
- Git & GitHub

## Project Structure

- `Base` – base test setup, timeout configuration, screenshots on failure and video recording
- `Pages` – Page Object classes and reusable page actions
- `Tests` – automated test cases
- `Utilities` – reserved for future helper classes

## Features

- Automated UI testing
- Page Object Model architecture
- Screenshot capture on failed tests
- Video recording for test execution
- Stable UI validation tests
- GitHub repository integration
- Reusable and maintainable test structure

## Automated Test Coverage

The framework currently includes **13 automated tests**, covering:

- Home Page
- Login Page
- Login form validation
- Products Page
- Search field validation
- Test Cases Page
- Contact Us Page
- Cart Page
- Cart page content validation
- API List Page
- Product Details Page
- Brand Products Page
- Category Products Page

## How to Run Tests

Clone the repository:

```bash
git clone https://github.com/mihaelacoderie-afk/playwright-csharp-automation-framework.git
```

Navigate to the project folder:

```bash
cd playwright-csharp-automation-framework
```

Run the tests:

```bash
dotnet test
```

## Test Evidence

The framework includes:

- screenshots on failed tests
- video recordings for test execution

These help with debugging and provide useful evidence for test results.

## GitHub Repository

https://github.com/mihaelacoderie-afk/playwright-csharp-automation-framework

## Author

Mihaela