using Pangolin;

namespace AppTests
{
    /// <summary>
    /// Example test class demonstrating how to write tests using Pangolin page models.
    /// NOTE: You may need to adjust method names based on the actual Pangolin.NETCore API.
    /// Refer to Pangolin documentation for correct method signatures.
    /// </summary>
    [TestClass]
    public sealed class Test1
    {
        // Base URL for your application - update this with your actual URL
        private const string BaseUrl = "https://your-app-url.com";
        
        private UIContext? _uiContext;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize UIContext - check Pangolin docs for exact initialization
            // Example: _uiContext = new UIContext();
            // Or: _uiContext = new UIContext(BrowserType.Chrome);
            _uiContext = new UIContext();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Clean up the browser session - check Pangolin docs for proper method
            // Options: _uiContext?.Close(); _uiContext?.Quit(); _uiContext?.Dispose();
            _uiContext?.Close();
        }

        [TestMethod]
        public void LoginPage_ShouldDisplayLoginForm()
        {
            // Navigate to the login page
            // Check Pangolin docs for navigation method: NavigateToUrl, GoToUrl, etc.
            _uiContext!.NavigateToUrl($"{BaseUrl}/login");

            // Create the page model instance using UIContext
            var loginPage = new Modules.User.LoginForm(_uiContext);

            // Verify the page loaded correctly
            // Adjust method names based on Pangolin API: WaitUntilVisible, WaitForElement, etc.
            loginPage.Header.WaitUntilVisible();

            // Verify form elements are present
            // Adjust assertion methods based on Pangolin API: IsVisible, Exists, etc.
            Assert.IsTrue(loginPage.Header.Exists(), "Login header should exist");
            Assert.IsTrue(loginPage.Email.Exists(), "Email field should exist");
            Assert.IsTrue(loginPage.Password.Exists(), "Password field should exist");
            Assert.IsTrue(loginPage.LoginButton.Exists(), "Login button should exist");
        }

        [TestMethod]
        public void LoginPage_ShouldNavigateToForgotPassword()
        {
            _uiContext!.NavigateToUrl($"{BaseUrl}/login");

            var loginPage = new Modules.User.LoginForm(_uiContext);

            // Click the Forgot Password button
            loginPage.ForgotPasswordButton.Click();

            // Verify navigation to forgot password page
            var forgotPasswordPage = new Modules.User.RequestUserPasswordResetTicketForm(_uiContext);
            forgotPasswordPage.Header.WaitUntilVisible();
            
            // Check Pangolin API for getting text: .Text, .GetText(), .Value, etc.
            string headerText = forgotPasswordPage.Header.GetText();
            Assert.IsTrue(headerText.Contains("Forgot Your Password"), 
                "Should navigate to forgot password page");
        }

        [TestMethod]
        public void ProductsList_ShouldDisplayProducts()
        {
            // First, login (assuming you need authentication)
            _uiContext!.NavigateToUrl($"{BaseUrl}/login");
            var loginPage = new Modules.User.LoginForm(_uiContext);
            loginPage.Email.Set("admin@example.com");
            loginPage.Password.Set("password123");
            loginPage.LoginButton.Click();

            // Navigate to products list
            _uiContext.NavigateToUrl($"{BaseUrl}/products");

            // Create the products list page model
            var productsList = new Modules.Product.ProductsList(_uiContext);

            // Verify the page loaded
            productsList.Header.WaitUntilVisible();
            string headerText = productsList.Header.GetText();
            Assert.IsTrue(headerText.Contains("Products"), 
                "Products page header should be visible");

            // Verify search functionality is available
            Assert.IsTrue(productsList.Name.Exists(), "Name search field should exist");
            Assert.IsTrue(productsList.SearchButton.Exists(), "Search button should exist");
            Assert.IsTrue(productsList.NewProductButton.Exists(), "New Product button should exist");
        }

        [TestMethod]
        public void ProductsList_ShouldSearchProducts()
        {
            // Login first
            _uiContext!.NavigateToUrl($"{BaseUrl}/login");
            var loginPage = new Modules.User.LoginForm(_uiContext);
            loginPage.Email.Set("admin@example.com");
            loginPage.Password.Set("password123");
            loginPage.LoginButton.Click();

            // Navigate to products
            _uiContext.NavigateToUrl($"{BaseUrl}/products");
            var productsList = new Modules.Product.ProductsList(_uiContext);

            // Perform a search
            productsList.Name.Set("Test Product");
            productsList.SearchButton.Click();

            // Wait for results to load (adjust timing as needed)
            // Consider using Pangolin's wait methods instead of Thread.Sleep
            System.Threading.Thread.Sleep(2000);

            // Verify search was executed
            Assert.IsTrue(productsList.Header.Exists(), "Products list should still be visible after search");
        }

        [TestMethod]
        public void ContactForm_ShouldCreateNewContact()
        {
            // Login
            _uiContext!.NavigateToUrl($"{BaseUrl}/login");
            var loginPage = new Modules.User.LoginForm(_uiContext);
            loginPage.Email.Set("admin@example.com");
            loginPage.Password.Set("password123");
            loginPage.LoginButton.Click();

            // Navigate to contacts list
            _uiContext.NavigateToUrl($"{BaseUrl}/contacts");
            var contactsList = new Modules.Contact.ContactsList(_uiContext);

            // Click New Contact button
            contactsList.NewContactButton.Click();

            // Fill out the contact form
            var contactForm = new Modules.Contact.ContactForm(_uiContext);
            contactForm.Header.WaitUntilVisible();
            
            contactForm.FirstName.Set("John");
            contactForm.LastName.Set("Doe");
            contactForm.PhoneNumber.Set("123-456-7890");

            // Save the contact
            contactForm.SaveButton.Click();

            // Verify we're back at the contacts list
            contactsList.Header.WaitUntilVisible();
            string headerText = contactsList.Header.GetText();
            Assert.IsTrue(headerText.Contains("Contacts"), 
                "Should return to contacts list after saving");
        }

        [TestMethod]
        public void ProductsList_ShouldWorkWithListRows()
        {
            // Example of working with list rows
            _uiContext!.NavigateToUrl($"{BaseUrl}/login");
            var loginPage = new Modules.User.LoginForm(_uiContext);
            loginPage.Email.Set("admin@example.com");
            loginPage.Password.Set("password123");
            loginPage.LoginButton.Click();

            _uiContext.NavigateToUrl($"{BaseUrl}/products");
            var productsList = new Modules.Product.ProductsList(_uiContext);
            productsList.Header.WaitUntilVisible();

            // Access a specific row by index (first row)
            var firstRow = productsList.Row(0);
            
            // Or find a row by containing text
            // var productRow = productsList.Row("Product Name");
            
            // Interact with row elements
            // firstRow.C_item_NameButton.Click();
            // firstRow.EditButton.Click();
        }
    }
}
