# How to Build Tests for Pages in AppTests

## Overview

This project uses **Pangolin.NETCore** for UI automation testing with the **Page Object Model (POM)** pattern. The page models are auto-generated in `-PageModel.Generated.cs`.

## Basic Test Structure

### 1. Test Class Setup

```csharp
using Pangolin;

[TestClass]
public class YourTestClass
{
    private UIContext? _uiContext;
    
    [TestInitialize]
    public void TestInitialize()
    {
        // Initialize UIContext - check Pangolin docs for exact initialization
        _uiContext = new UIContext();
        // May need: _uiContext = new UIContext(browserType, options);
    }
    
    [TestCleanup]
    public void TestCleanup()
    {
        // Clean up - check Pangolin docs for proper disposal
        _uiContext?.Close(); // or Dispose(), Quit(), etc.
    }
}
```

### 2. Basic Test Pattern

```csharp
[TestMethod]
public void YourTestName()
{
    // Step 1: Navigate to the page
    // Check Pangolin docs for navigation method:
    // _uiContext.NavigateToUrl("https://your-app.com/page");
    // or: _uiContext.GoToUrl("https://your-app.com/page");
    
    // Step 2: Create page model instance
    var loginPage = new Modules.User.LoginForm(_uiContext);
    
    // Step 3: Interact with elements
    loginPage.Email.Set("user@example.com");
    loginPage.Password.Set("password123");
    loginPage.LoginButton.Click();
    
    // Step 4: Assert/Verify
    // Check Pangolin docs for assertion methods:
    // Assert.IsTrue(loginPage.Header.Exists());
    // or: loginPage.Header.Should().BeVisible();
}
```

## Available Page Models

All page models are in `-PageModel.Generated.cs`. Here are the main ones:

### User/Authentication
- `Modules.User.LoginForm` - Login page
- `Modules.User.RequestUserPasswordResetTicketForm` - Forgot password
- `Modules.User.ResetUserPasswordForm` - Reset password

### Products
- `Modules.Product.ProductsList` - Products listing page
- `Modules.Product.ProductForm` - Create/Edit product form
- `Modules.Product.ProductView` - View product details

### Contacts
- `Modules.Contact.ContactsList` - Contacts listing
- `Modules.Contact.ContactForm` - Create/Edit contact form
- `Modules.Contact.ContactView` - View contact details

### Administrators
- `Modules.Administrator.AdministratorsList` - Admin users list
- `Modules.Administrator.AdministratorForm` - Create/Edit admin form

### Product Categories
- `Modules.ProductCategory.ProductCategoriesList` - Categories list
- `Modules.ProductCategory.ProductCategoryForm` - Create/Edit category form

### Properties
- `Modules.Property.PropertiesList` - Properties list
- `Modules.Property.PropertyForm` - Create/Edit property form

### Common UI Components
- `Modules.CustomModules.HeaderGenericModule` - Header navigation
- `Modules.CustomModules.FooterGenericModule` - Footer
- `Modules.Menus.MainMenu` - Main menu
- `Modules.Menus.AdminSettingsMenu` - Admin settings menu

## Element Interaction Patterns

### Text Input
```csharp
pageModel.TextboxElement.Set("value");
pageModel.TextboxElement.Clear();
string value = pageModel.TextboxElement.GetValue(); // Check Pangolin API
```

### Buttons
```csharp
pageModel.ButtonElement.Click();
pageModel.ButtonElement.IsEnabled(); // Check Pangolin API
```

### Lists/Tables
```csharp
// Access rows by index
var row = listPage.Row(0);
row.EditButton.Click();

// Find row by text
var row = listPage.Row("Search Text");
row.DeleteButton.Click();
```

### Radio Buttons
```csharp
pageModel.RadioButtonsElement.Select("Option1");
```

### File Upload
```csharp
pageModel.FileUploadElement.Upload("path/to/file");
```

## Common Test Scenarios

### 1. Simple Page Verification
```csharp
[TestMethod]
public void LoginPage_ShouldDisplayCorrectly()
{
    NavigateToLogin();
    var loginPage = new Modules.User.LoginForm(_uiContext);
    
    // Verify elements exist (adjust method names per Pangolin API)
    Assert.IsNotNull(loginPage.Email);
    Assert.IsNotNull(loginPage.Password);
    Assert.IsNotNull(loginPage.LoginButton);
}
```

### 2. Form Submission
```csharp
[TestMethod]
public void ContactForm_ShouldCreateContact()
{
    NavigateToContacts();
    var contactsList = new Modules.Contact.ContactsList(_uiContext);
    contactsList.NewContactButton.Click();
    
    var form = new Modules.Contact.ContactForm(_uiContext);
    form.FirstName.Set("John");
    form.LastName.Set("Doe");
    form.PhoneNumber.Set("123-456-7890");
    form.SaveButton.Click();
    
    // Verify success
    var list = new Modules.Contact.ContactsList(_uiContext);
    // Assert contact appears in list
}
```

### 3. List Operations
```csharp
[TestMethod]
public void ProductsList_ShouldSearchAndEdit()
{
    NavigateToProducts();
    var productsList = new Modules.Product.ProductsList(_uiContext);
    
    // Search
    productsList.Name.Set("Product Name");
    productsList.SearchButton.Click();
    
    // Edit first result
    var row = productsList.Row(0);
    row.EditButton.Click();
    
    var form = new Modules.Product.ProductForm(_uiContext);
    form.Name.Set("Updated Name");
    form.SaveButton.Click();
}
```

## Important Notes

1. **Check Pangolin.NETCore Documentation**: The exact method names (NavigateToUrl, IsVisible, WaitUntilVisible, etc.) may differ. Refer to the Pangolin.NETCore 2.0.4 documentation for the correct API.

2. **Base URL Configuration**: Update the `BaseUrl` constant in your test class with your actual application URL.

3. **Browser Configuration**: You may need to configure browser settings (Chrome, Firefox, etc.) in app.config or via UIContext initialization.

4. **Wait Strategies**: Use appropriate wait strategies for elements that load dynamically. Pangolin may provide methods like `WaitUntilVisible()`, `WaitForElement()`, or similar.

5. **Assertions**: Use MSTest `Assert` class or Pangolin's built-in assertion methods (check documentation).

## Next Steps

1. Review Pangolin.NETCore 2.0.4 documentation for exact API methods
2. Update test examples with correct method names
3. Configure browser settings for your environment
4. Start writing tests for your specific pages

