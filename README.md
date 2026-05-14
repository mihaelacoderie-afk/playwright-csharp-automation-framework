# Playwright C# Automation Framework

## Project Overview

This project represents a UI Automation Testing Framework developed using Playwright with C#, NUnit, and the Page Object Model (POM) design pattern.

The goal of the project was to automate multiple user flows from the Automation Exercise website while keeping the framework clean, reusable, and easy to maintain.

The framework was designed with scalability and maintainability in mind and includes reusable page methods, organized test scenarios, screenshot capture on failure, and video recording for test execution.

---

# Technologies Used

* C#
* .NET 8
* Playwright
* NUnit
* Visual Studio 2022
* Git & GitHub

---

# Framework Structure

## Base

Contains:

* Playwright initialization
* Browser configuration
* Timeout setup
* Screenshot capture on failure
* Video recording configuration

## Pages

Contains Page Object classes with:

* locators
* reusable methods
* page actions

## Tests

Contains all automated test scenarios implemented using NUnit.

---

# Automated Test Scenarios

## TC01 – Verify Home Page Loads

Purpose:
Verify that the home page opens correctly.

Expected Result:
The home page should load successfully.

---

## TC02 – Verify Login Page

Purpose:
Verify that the login page is accessible.

Expected Result:
The login page should open correctly.

---

## TC03 – Verify Invalid Login

Purpose:
Verify that invalid login credentials display an error message.

Expected Result:
An error message should be displayed for invalid credentials.

---

## TC04 – Verify Contact Us Page

Purpose:
Verify navigation to the Contact Us page.

Expected Result:
The Contact Us page should load successfully.

---

## TC05 – Verify Products Page

Purpose:
Verify that the products page displays correctly.

Expected Result:
The products page should contain product listings.

---

## TC06 – Verify Product Details Page

Purpose:
Verify that product details are displayed correctly.

Expected Result:
Product details should be visible and displayed correctly.

---

## TC07 – Verify Product Search

Purpose:
Verify the search functionality.

Expected Result:
Search results should match the entered keyword.

---

## TC08 – Verify Add To Cart

Purpose:
Verify that a product can be added to the cart.

Expected Result:
The selected product should be successfully added to the cart.

---

## TC09 – Verify Cart Page

Purpose:
Verify that the cart page loads correctly.

Expected Result:
The products added to the cart should be displayed correctly.

---

## TC10 – Verify Brand Products Page

Purpose:
Verify products displayed for a selected brand.

Expected Result:
Brand products should be displayed correctly.

---

## TC11 – Verify Category Products Page

Purpose:
Verify products displayed for a selected category.

Expected Result:
Category products should be displayed correctly.

---

## TC12 – Verify API List Page

Purpose:
Verify that the API list page loads correctly.

Expected Result:
The API list page should display the expected API information.

---

# Features Implemented

* Page Object Model architecture
* Reusable page methods
* NUnit assertions
* Screenshot capture on failed tests
* Video recording during test execution
* Timeout handling
* Organized project structure
* GitHub repository integration

---

# Additional Recommended Test Scenarios

## Responsive Design Testing

The application could also be tested on different screen resolutions and device sizes to validate UI responsiveness.

## Cross-Browser Testing

Tests could be executed on:

* Chrome
* Edge
* Firefox

## Performance Testing

Basic performance checks could be added to monitor page loading speed and responsiveness.

## Negative Testing

Additional negative test scenarios could be implemented to validate error handling and application stability.

---

# Test Execution

Run the tests using:

```bash
dotnet test
```

Or directly from Visual Studio Test Explorer.

---

# Challenges Encountered

During development, several challenges were encountered and resolved, including:

* synchronization and timeout issues
* Git merge conflicts
* unstable locators
* framework organization and structure

These challenges helped improve debugging and troubleshooting skills while working with Playwright and Git.

---

# GitHub Repository

Repository Link:

[https://github.com/mihaelacoderie-afk/playwright-csharp-automation-framework](https://github.com/mihaelacoderie-afk/playwright-csharp-automation-framework)

---

# Conclusion

This project helped improve practical knowledge related to:

* UI automation testing
* Playwright automation
* C# programming
* NUnit testing
* Git and GitHub workflows
* automation framework organization

The framework was designed to be scalable and maintainable and can easily be extended with additional automated test scenarios in the future.

---

# Author

Mihaela
