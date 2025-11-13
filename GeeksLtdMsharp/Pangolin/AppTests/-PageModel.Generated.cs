using System.Text.RegularExpressions;
using System;
using Pangolin;

// Footer
namespace Modules.CustomModules
{
    public class FooterGenericModule : ModulePageModel
    {
        public FooterGenericModule(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='Footer']";
        
        public HtmlButtonElement GeeksButton => ByXPath<HtmlButtonElement>("Geeks", $"{DataModuleXPath}//*[@name='Geeks']");
        public HtmlButtonElement EmailButton => ByXPath<HtmlButtonElement>("Email", $"{DataModuleXPath}//*[@name='Email']");
        public HtmlButtonElement LinkedInButton => ByXPath<HtmlButtonElement>("LinkedIn", $"{DataModuleXPath}//*[@name='LinkedIn']");
        public HtmlButtonElement FacebookButton => ByXPath<HtmlButtonElement>("Facebook", $"{DataModuleXPath}//*[@name='Facebook']");
        public HtmlButtonElement TwitterButton => ByXPath<HtmlButtonElement>("Twitter", $"{DataModuleXPath}//*[@name='Twitter']");
        public HtmlButtonElement SoftwareDevelopmentButton => ByXPath<HtmlButtonElement>("SoftwareDevelopment", $"{DataModuleXPath}//*[@name='SoftwareDevelopment']");
    }
}

// Header
namespace Modules.CustomModules
{
    public class HeaderGenericModule : ModulePageModel
    {
        public HeaderGenericModule(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='Header']";
        
        public HtmlButtonElement LogoButton => ByXPath<HtmlButtonElement>("Logo", $"{DataModuleXPath}//*[@name='Logo']");
        public HtmlButtonElement BurgerButton => ByXPath<HtmlButtonElement>("Burger", $"{DataModuleXPath}//*[@name='Burger']");
        public HtmlButtonElement LoginButton => ByXPath<HtmlButtonElement>("Login", $"{DataModuleXPath}//*[@name='Login']");
        public HtmlButtonElement LogoutButton => ByXPath<HtmlButtonElement>("Logout", $"{DataModuleXPath}//*[@name='Logout']");
        
        public Modules.Menus.MainMenu MainMenuAccessor => new Modules.Menus.MainMenu(UIContext);
    }
}

// SharedView
namespace Modules.CustomModules
{
    public class SharedViewGenericModule : ModulePageModel
    {
        public SharedViewGenericModule(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='SharedView']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Header", $"{DataModuleXPath}//*[@name='Header']");
    }
}

// AdminSettingsMenu
namespace Modules.Menus
{
    public class AdminSettingsMenu : ModulePageModel
    {
        public AdminSettingsMenu(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='AdminSettingsMenu']";
        
        public HtmlLinkElement ProductCategories => ByXPath<HtmlLinkElement>("ProductCategories", $"{DataModuleXPath}//*[@name='ProductCategories']");
        public HtmlLinkElement Products => ByXPath<HtmlLinkElement>("Products", $"{DataModuleXPath}//*[@name='Products']");
        public HtmlLinkElement Contacts => ByXPath<HtmlLinkElement>("Contacts", $"{DataModuleXPath}//*[@name='Contacts']");
        public HtmlLinkElement Administrators => ByXPath<HtmlLinkElement>("Administrators", $"{DataModuleXPath}//*[@name='Administrators']");
        public HtmlLinkElement GeneralSettings => ByXPath<HtmlLinkElement>("GeneralSettings", $"{DataModuleXPath}//*[@name='GeneralSettings']");
        public HtmlLinkElement ProductSummery => ByXPath<HtmlLinkElement>("ProductSummery", $"{DataModuleXPath}//*[@name='ProductSummery']");
        public HtmlLinkElement Property => ByXPath<HtmlLinkElement>("Property", $"{DataModuleXPath}//*[@name='Property']");
        public HtmlLinkElement Projects => ByXPath<HtmlLinkElement>("Projects", $"{DataModuleXPath}//*[@name='Projects']");
        public HtmlLinkElement ProjectTasks => ByXPath<HtmlLinkElement>("ProjectTasks", $"{DataModuleXPath}//*[@name='ProjectTasks']");
        public HtmlLinkElement AssetTypes => ByXPath<HtmlLinkElement>("AssetTypes", $"{DataModuleXPath}//*[@name='AssetTypes']");
        public HtmlLinkElement Owners => ByXPath<HtmlLinkElement>("Owners", $"{DataModuleXPath}//*[@name='Owners']");
        public HtmlLinkElement AssetsList => ByXPath<HtmlLinkElement>("AssetsList", $"{DataModuleXPath}//*[@name='AssetsList']");
    }
}

// MainMenu
namespace Modules.Menus
{
    public class MainMenu : ModulePageModel
    {
        public MainMenu(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='MainMenu']";
        
        public HtmlButtonElement LogoutButton => ByXPath<HtmlButtonElement>("Logout", $"{DataModuleXPath}//*[@name='Logout']");
    }
}

// AdministratorForm
namespace Modules.Administrator
{
    public class AdministratorForm : ModulePageModel
    {
        public AdministratorForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='AdministratorForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Administrator Details", $"{DataModuleXPath}//*[@name='Administrator Details']");
        public HtmlTextboxElement FirstName => ByXPath<HtmlTextboxElement>("FirstName", $"{DataModuleXPath}//*[@name='FirstName']");
        
        public HtmlTextboxElement LastName => ByXPath<HtmlTextboxElement>("LastName", $"{DataModuleXPath}//*[@name='LastName']");
        
        public HtmlTextboxElement Email => ByXPath<HtmlTextboxElement>("Email", $"{DataModuleXPath}//*[@name='Email']");
        
        public HtmlVerticalRadioButtonsElement IsDeactivated => ByXPath<HtmlVerticalRadioButtonsElement>("IsDeactivated", $"{DataModuleXPath}//*[@id='IsDeactivated']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// AdministratorsList
namespace Modules.Administrator
{
    public class AdministratorsList : ModulePageModel
    {
        public AdministratorsList(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='AdministratorsList']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Administrators", $"{DataModuleXPath}//*[@name='Administrators']");
        public ListRow Row(int rowIndex) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { RowIndex = rowIndex };
        public ListRow Row(string containingText) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { ContainingText = containingText };
        public ListRow Row(That that, string text) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { That = that, ContainingText = text };
        
        public HtmlTextboxElement FullSearch => ByXPath<HtmlTextboxElement>("FullSearch", $"{DataModuleXPath}//*[@name='FullSearch']");
        
        public HtmlButtonElement SearchButton => ByXPath<HtmlButtonElement>("Search", $"{DataModuleXPath}//*[@name='Search']");
        public HtmlButtonElement NewAdministratorButton => ByXPath<HtmlButtonElement>("NewAdministrator", $"{DataModuleXPath}//*[@name='NewAdministrator']");
        
        public class ListRow : ListRowPageModel
        {
            public ListRow(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public HtmlTextElement Email => ByXPath<HtmlTextElement>("Email", $"{RowSelector}//*[contains(@name,'.Email')]");
            public HtmlButtonElement NameButton => ByXPath<HtmlButtonElement>("Name", $"{RowSelector}//*[@name='Name']");
            public HtmlButtonElement EditButton => ByXPath<HtmlButtonElement>("Edit", $"{RowSelector}//*[@name='Edit']");
            public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{RowSelector}//*[@name='Delete']");
        }
    }
}

// ViewAdmin
namespace Modules.Administrator
{
    public class ViewAdminView : ModulePageModel
    {
        public ViewAdminView(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ViewAdmin']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Header", $"{DataModuleXPath}//*[@name='Header']");
        public HtmlButtonElement BackButton => ByXPath<HtmlButtonElement>("Back", $"{DataModuleXPath}//*[@name='Back']");
        public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{DataModuleXPath}//*[@name='Delete']");
    }
}

// AssetTypeForm
namespace Modules.AssetType
{
    public class AssetTypeForm : ModulePageModel
    {
        public AssetTypeForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='AssetTypeForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Asset Types details", $"{DataModuleXPath}//*[@name='Asset Types details']");
        public HtmlTextboxElement Name => ByXPath<HtmlTextboxElement>("Name", $"{DataModuleXPath}//*[@name='Name']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// AssetTypesList
namespace Modules.AssetType
{
    public class AssetTypesList : ModulePageModel
    {
        public AssetTypesList(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='AssetTypesList']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Asset Types", $"{DataModuleXPath}//*[@name='Asset Types']");
        public ListRow Row(int rowIndex) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { RowIndex = rowIndex };
        public ListRow Row(string containingText) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { ContainingText = containingText };
        public ListRow Row(That that, string text) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { That = that, ContainingText = text };
        
        public HtmlButtonElement AddAssetTypeButton => ByXPath<HtmlButtonElement>("AddAssetType", $"{DataModuleXPath}//*[@name='AddAssetType']");
        
        public class ListRow : ListRowPageModel
        {
            public ListRow(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public HtmlTextElement Name => ByXPath<HtmlTextElement>("Name", $"{RowSelector}//*[contains(@name,'.Name')]");
            public HtmlButtonElement EditButton => ByXPath<HtmlButtonElement>("Edit", $"{RowSelector}//*[@name='Edit']");
            public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{RowSelector}//*[@name='Delete']");
        }
    }
}

// AssetForm
namespace Modules.Asset
{
    public class AssetForm : ModulePageModel
    {
        public AssetForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='AssetForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Asset details", $"{DataModuleXPath}//*[@name='Asset details']");
        public HtmlTextboxElement Code => ByXPath<HtmlTextboxElement>("Code", $"{DataModuleXPath}//*[@name='Code']");
        
        public HtmlTextboxElement Name => ByXPath<HtmlTextboxElement>("Name", $"{DataModuleXPath}//*[@name='Name']");
        
        // PageModel.JSService.Inject("Opacity");
        public HtmlDropdownListElement Type => ByXPath<HtmlDropdownListElement>("Type", $"{DataModuleXPath}//*[@name='Type']");
        
        public HtmlTextboxElement Cost => ByXPath<HtmlTextboxElement>("Cost", $"{DataModuleXPath}//*[@name='Cost']");
        
        // PageModel.JSService.Inject("Opacity");
        public HtmlDropdownListElement Owner => ByXPath<HtmlDropdownListElement>("Owner", $"{DataModuleXPath}//*[@name='Owner']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// AssetsList
namespace Modules.Asset
{
    public class AssetsList : ModulePageModel
    {
        public AssetsList(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='AssetsList']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Assets", $"{DataModuleXPath}//*[@name='Assets']");
        public ListRow Row(int rowIndex) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { RowIndex = rowIndex };
        public ListRow Row(string containingText) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { ContainingText = containingText };
        public ListRow Row(That that, string text) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { That = that, ContainingText = text };
        
        // PageModel.JSService.Inject("Opacity");
        public HtmlDropdownListElement Type => ByXPath<HtmlDropdownListElement>("Type", $"{DataModuleXPath}//*[@name='Type']");
        public HtmlTextboxElement FullSearch => ByXPath<HtmlTextboxElement>("FullSearch", $"{DataModuleXPath}//*[@name='FullSearch']");
        
        public HtmlButtonElement SearchButton => ByXPath<HtmlButtonElement>("Search", $"{DataModuleXPath}//*[@name='Search']");
        public HtmlButtonElement AddAssetButton => ByXPath<HtmlButtonElement>("AddAsset", $"{DataModuleXPath}//*[@name='AddAsset']");
        
        public class ListRow : ListRowPageModel
        {
            public ListRow(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public HtmlTextElement Code => ByXPath<HtmlTextElement>("Code", $"{RowSelector}//*[contains(@name,'.Code')]");
            public HtmlTextElement Name => ByXPath<HtmlTextElement>("Name", $"{RowSelector}//*[contains(@name,'.Name')]");
            public HtmlTextElement AssetType => ByXPath<HtmlTextElement>("AssetType", $"{RowSelector}//*[contains(@name,'.AssetType')]");
            public HtmlTextElement Cost => ByXPath<HtmlTextElement>("Cost", $"{RowSelector}//*[contains(@name,'.Cost')]");
            public HtmlTextElement Owner => ByXPath<HtmlTextElement>("Owner", $"{RowSelector}//*[contains(@name,'.Owner')]");
            public HtmlButtonElement ViewButton => ByXPath<HtmlButtonElement>("View", $"{RowSelector}//*[@name='View']");
            public HtmlButtonElement EditButton => ByXPath<HtmlButtonElement>("Edit", $"{RowSelector}//*[@name='Edit']");
            public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{RowSelector}//*[@name='Delete']");
        }
    }
}

// AssetView
namespace Modules.Asset
{
    public class AssetView : ModulePageModel
    {
        public AssetView(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='AssetView']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Asset details", $"{DataModuleXPath}//*[@name='Asset details']");
        public HtmlButtonElement BackButton => ByXPath<HtmlButtonElement>("Back", $"{DataModuleXPath}//*[@name='Back']");
    }
}

// ContactForm
namespace Modules.Contact
{
    public class ContactForm : ModulePageModel
    {
        public ContactForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ContactForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Contact Details", $"{DataModuleXPath}//*[@name='Contact Details']");
        public HtmlTextboxElement FirstName => ByXPath<HtmlTextboxElement>("FirstName", $"{DataModuleXPath}//*[@name='FirstName']");
        
        public HtmlTextboxElement LastName => ByXPath<HtmlTextboxElement>("LastName", $"{DataModuleXPath}//*[@name='LastName']");
        
        public HtmlTextboxElement PhoneNumber => ByXPath<HtmlTextboxElement>("PhoneNumber", $"{DataModuleXPath}//*[@name='PhoneNumber']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// ContactsList
namespace Modules.Contact
{
    public class ContactsList : ModulePageModel
    {
        public ContactsList(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ContactsList']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Contacts", $"{DataModuleXPath}//*[@name='Contacts']");
        public ListRow Row(int rowIndex) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { RowIndex = rowIndex };
        public ListRow Row(string containingText) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { ContainingText = containingText };
        public ListRow Row(That that, string text) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { That = that, ContainingText = text };
        
        public HtmlTextboxElement FullSearch => ByXPath<HtmlTextboxElement>("FullSearch", $"{DataModuleXPath}//*[@name='FullSearch']");
        
        public HtmlButtonElement SearchButton => ByXPath<HtmlButtonElement>("Search", $"{DataModuleXPath}//*[@name='Search']");
        public HtmlButtonElement NewContactButton => ByXPath<HtmlButtonElement>("NewContact", $"{DataModuleXPath}//*[@name='NewContact']");
        
        public class ListRow : ListRowPageModel
        {
            public ListRow(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public HtmlTextElement PhoneNumber => ByXPath<HtmlTextElement>("PhoneNumber", $"{RowSelector}//*[contains(@name,'.PhoneNumber')]");
            public HtmlButtonElement EditButton => ByXPath<HtmlButtonElement>("Edit", $"{RowSelector}//*[@name='Edit']");
            public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{RowSelector}//*[@name='Delete']");
            public HtmlButtonElement C_item_NameButton => ByXPath<HtmlButtonElement>("C_item_Name", $"{RowSelector}//*[@name='C_item_Name']");
        }
    }
}

// ContactView
namespace Modules.Contact
{
    public class ContactView : ModulePageModel
    {
        public ContactView(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ContactView']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Header", $"{DataModuleXPath}//*[@name='Header']");
        public HtmlButtonElement BackButton => ByXPath<HtmlButtonElement>("Back", $"{DataModuleXPath}//*[@name='Back']");
        public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{DataModuleXPath}//*[@name='Delete']");
    }
}

// Error401
namespace Modules.CustomModules
{
    public class Error401GenericModule : ModulePageModel
    {
        public Error401GenericModule(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='Error401']";
    }
}

// OwnerForm
namespace Modules.Owner
{
    public class OwnerForm : ModulePageModel
    {
        public OwnerForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='OwnerForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Owner details", $"{DataModuleXPath}//*[@name='Owner details']");
        public HtmlTextboxElement FirstName => ByXPath<HtmlTextboxElement>("FirstName", $"{DataModuleXPath}//*[@name='FirstName']");
        
        public HtmlTextboxElement LastName => ByXPath<HtmlTextboxElement>("LastName", $"{DataModuleXPath}//*[@name='LastName']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// OwnersList
namespace Modules.Owner
{
    public class OwnersList : ModulePageModel
    {
        public OwnersList(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='OwnersList']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Owners", $"{DataModuleXPath}//*[@name='Owners']");
        public ListRow Row(int rowIndex) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { RowIndex = rowIndex };
        public ListRow Row(string containingText) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { ContainingText = containingText };
        public ListRow Row(That that, string text) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { That = that, ContainingText = text };
        
        public HtmlButtonElement AddOwnerButton => ByXPath<HtmlButtonElement>("AddOwner", $"{DataModuleXPath}//*[@name='AddOwner']");
        
        public class ListRow : ListRowPageModel
        {
            public ListRow(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public HtmlTextElement FirstName => ByXPath<HtmlTextElement>("FirstName", $"{RowSelector}//*[contains(@name,'.FirstName')]");
            public HtmlTextElement LastName => ByXPath<HtmlTextElement>("LastName", $"{RowSelector}//*[contains(@name,'.LastName')]");
            public HtmlButtonElement EditButton => ByXPath<HtmlButtonElement>("Edit", $"{RowSelector}//*[@name='Edit']");
            public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{RowSelector}//*[@name='Delete']");
        }
    }
}

// ProductCategoriesList
namespace Modules.ProductCategory
{
    public class ProductCategoriesList : ModulePageModel
    {
        public ProductCategoriesList(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProductCategoriesList']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Product Category", $"{DataModuleXPath}//*[@name='Product Category']");
        public ListRow Row(int rowIndex) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { RowIndex = rowIndex };
        public ListRow Row(string containingText) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { ContainingText = containingText };
        public ListRow Row(That that, string text) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { That = that, ContainingText = text };
        
        public HtmlTextboxElement FullSearch => ByXPath<HtmlTextboxElement>("FullSearch", $"{DataModuleXPath}//*[@name='FullSearch']");
        
        public HtmlButtonElement SearchButton => ByXPath<HtmlButtonElement>("Search", $"{DataModuleXPath}//*[@name='Search']");
        public HtmlButtonElement NewProductCategoryButton => ByXPath<HtmlButtonElement>("NewProductCategory", $"{DataModuleXPath}//*[@name='NewProductCategory']");
        
        public class ListRow : ListRowPageModel
        {
            public ListRow(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public HtmlTextElement Name => ByXPath<HtmlTextElement>("Name", $"{RowSelector}//*[contains(@name,'.Name')]");
            public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{RowSelector}//*[@name='Save']");
            public HtmlButtonElement EditButton => ByXPath<HtmlButtonElement>("Edit", $"{RowSelector}//*[@name='Edit']");
            public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{RowSelector}//*[@name='Delete']");
        }
    }
}

// ProductCategoryForm_Products_DetailsForm
namespace ProductCategoryForm.Products
{
    public class DetailsForm : ModulePageModel
    {
        public DetailsForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProductCategoryForm_Products_DetailsForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Serviced Properties", $"{DataModuleXPath}//*[@name='Serviced Properties']");
        public HtmlTextboxElement Name => ByXPath<HtmlTextboxElement>("Name", $"{DataModuleXPath}//*[@name='Name']");
        
        public HtmlDateAndTimePickerElement ProductionDate_time => ByXPath<HtmlDateAndTimePickerElement>("ProductionDate_time", $"{DataModuleXPath}//*[@name='ProductionDate_time']");
        
        public HtmlHorizontalRadioButtonsElement IsFood => ByXPath<HtmlHorizontalRadioButtonsElement>("IsFood", $"{DataModuleXPath}//*[@id='IsFood']");
        
        public HtmlTextboxElement ProductWebsite => ByXPath<HtmlTextboxElement>("ProductWebsite", $"{DataModuleXPath}//*[@name='ProductWebsite']");
        
        // PageModel.JSService.Inject("FileUpload");
        public HtmlFileUploadElement Photo => ByXPath<HtmlFileUploadElement>("Photo", $"{DataModuleXPath}//input[@id='Photo_fileInput']");
        
        public HtmlButtonElement AddProductButton => ByXPath<HtmlButtonElement>("AddProduct", $"{DataModuleXPath}//*[@name='AddProduct']");
    }
}

// ProductCategoryForm
namespace Modules.ProductCategory
{
    public class ProductCategoryForm : ModulePageModel
    {
        public ProductCategoryForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProductCategoryForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Product Category Details", $"{DataModuleXPath}//*[@name='Product Category Details']");
        public HtmlTextboxElement Name => ByXPath<HtmlTextboxElement>("Name", $"{DataModuleXPath}//*[@name='Name']");
        
        public ProductsDetails Products => new ProductsDetails(UIContext, ListRenderMode.ResponsiveGrid, DataModuleXPath);
        public class ProductsDetails : ListRowPageModel
        {
            public ProductsDetails(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public ProductsDetails Row(int rowIndex) => new ProductsDetails(UIContext, ListRenderMode.ResponsiveGrid, DataModuleXPath) { RowIndex = rowIndex };
            public ProductsDetails Row(string containingText) => new ProductsDetails(UIContext, ListRenderMode.ResponsiveGrid, DataModuleXPath) { ContainingText = containingText };
            public ProductsDetails Row(That that, string text) => new ProductsDetails(UIContext, ListRenderMode.ResponsiveGrid, DataModuleXPath) { That = that, ContainingText = text };
            
            public HtmlTextboxElement Name => ByXPath<HtmlTextboxElement>("Name", $"{RowSelector}//*[contains(@name,'.Name')]");
            public HtmlDateAndTimePickerElement ProductionDate_time => ByXPath<HtmlDateAndTimePickerElement>("ProductionDate_time", $"{RowSelector}//*[contains(@name,'.ProductionDate_time')]");
            public HtmlHorizontalRadioButtonsElement IsFood => ByXPath<HtmlHorizontalRadioButtonsElement>("IsFood", $"{RowSelector}//*[contains(@name,'.IsFood')]");
            public HtmlTextboxElement ProductWebsite => ByXPath<HtmlTextboxElement>("ProductWebsite", $"{RowSelector}//*[contains(@name,'.ProductWebsite')]");
            public HtmlFileUploadElement Photo => ByXPath<HtmlFileUploadElement>("Photo", $"{RowSelector}//*[contains(@name,'.Photo')]");
            public HtmlButtonElement AddProductButton => ByXPath<HtmlButtonElement>("AddProduct", $"{RowSelector}//*[@name='AddProduct']");
        }
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// ProductCategoryView
namespace Modules.ProductCategory
{
    public class ProductCategoryView : ModulePageModel
    {
        public ProductCategoryView(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProductCategoryView']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Header", $"{DataModuleXPath}//*[@name='Header']");
        public HtmlButtonElement BackButton => ByXPath<HtmlButtonElement>("Back", $"{DataModuleXPath}//*[@name='Back']");
        public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{DataModuleXPath}//*[@name='Delete']");
        public HtmlButtonElement ProductButton => ByXPath<HtmlButtonElement>("Product", $"{DataModuleXPath}//*[@name='Product']");
    }
}

// ProductForm
namespace Modules.Product
{
    public class ProductForm : ModulePageModel
    {
        public ProductForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProductForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Product Details", $"{DataModuleXPath}//*[@name='Product Details']");
        public HtmlTextboxElement Name => ByXPath<HtmlTextboxElement>("Name", $"{DataModuleXPath}//*[@name='Name']");
        
        public HtmlDateAndTimePickerElement ProductionDate_time => ByXPath<HtmlDateAndTimePickerElement>("ProductionDate_time", $"{DataModuleXPath}//*[@name='ProductionDate_time']");
        
        public HtmlHorizontalRadioButtonsElement IsFood => ByXPath<HtmlHorizontalRadioButtonsElement>("IsFood", $"{DataModuleXPath}//*[@id='IsFood']");
        
        public HtmlTextboxElement ProductWebsite => ByXPath<HtmlTextboxElement>("ProductWebsite", $"{DataModuleXPath}//*[@name='ProductWebsite']");
        
        // PageModel.JSService.Inject("FileUpload");
        public HtmlFileUploadElement Photo => ByXPath<HtmlFileUploadElement>("Photo", $"{DataModuleXPath}//input[@id='Photo_fileInput']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// ProductsList
namespace Modules.Product
{
    public class ProductsList : ModulePageModel
    {
        public ProductsList(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProductsList']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Products", $"{DataModuleXPath}//*[@name='Products']");
        public ListRow Row(int rowIndex) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { RowIndex = rowIndex };
        public ListRow Row(string containingText) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { ContainingText = containingText };
        public ListRow Row(That that, string text) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { That = that, ContainingText = text };
        
        public HtmlHorizontalRadioButtonsElement ProductCategory => ByXPath<HtmlHorizontalRadioButtonsElement>("ProductCategory", $"{DataModuleXPath}//*[@id='ProductCategory']");
        public HtmlTextboxElement Name => ByXPath<HtmlTextboxElement>("Name", $"{DataModuleXPath}//*[@name='Name']");
        
        public HtmlButtonElement SearchButton => ByXPath<HtmlButtonElement>("Search", $"{DataModuleXPath}//*[@name='Search']");
        public HtmlButtonElement NewProductButton => ByXPath<HtmlButtonElement>("NewProduct", $"{DataModuleXPath}//*[@name='NewProduct']");
        public HtmlButtonElement ThisButtonExportsToCSVButton => ByXPath<HtmlButtonElement>("ThisButtonExportsToCSV", $"{DataModuleXPath}//*[@name='ThisButtonExportsToCSV']");
        public HtmlButtonElement ThisButtonExportsToExcelButton => ByXPath<HtmlButtonElement>("ThisButtonExportsToExcel", $"{DataModuleXPath}//*[@name='ThisButtonExportsToExcel']");
        
        public class ListRow : ListRowPageModel
        {
            public ListRow(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public HtmlButtonElement C_item_NameButton => ByXPath<HtmlButtonElement>("C_item_Name", $"{RowSelector}//*[@name='C_item_Name']");
            public HtmlButtonElement PhotoButton => ByXPath<HtmlButtonElement>("Photo", $"{RowSelector}//*[@name='Photo']");
            public HtmlButtonElement EditButton => ByXPath<HtmlButtonElement>("Edit", $"{RowSelector}//*[@name='Edit']");
            public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{RowSelector}//*[@name='Delete']");
        }
    }
}

// ProductView
namespace Modules.Product
{
    public class ProductView : ModulePageModel
    {
        public ProductView(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProductView']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Header", $"{DataModuleXPath}//*[@name='Header']");
        public HtmlButtonElement BackButton => ByXPath<HtmlButtonElement>("Back", $"{DataModuleXPath}//*[@name='Back']");
        public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{DataModuleXPath}//*[@name='Delete']");
    }
}

// ProjectTaskAdd
namespace Modules.ProjectTask
{
    public class ProjectTaskAddForm : ModulePageModel
    {
        public ProjectTaskAddForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProjectTaskAdd']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Task Details", $"{DataModuleXPath}//*[@name='Task Details']");
        // PageModel.JSService.Inject("Opacity");
        public HtmlDropdownListElement Project => ByXPath<HtmlDropdownListElement>("Project", $"{DataModuleXPath}//*[@name='Project']");
        
        public HtmlTextboxElement Title => ByXPath<HtmlTextboxElement>("Title", $"{DataModuleXPath}//*[@name='Title']");
        
        public HtmlTextboxElement Description => ByXPath<HtmlTextboxElement>("Description", $"{DataModuleXPath}//*[@name='Description']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// ProjectTaskEdit
namespace Modules.ProjectTask
{
    public class ProjectTaskEditForm : ModulePageModel
    {
        public ProjectTaskEditForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProjectTaskEdit']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Task Details", $"{DataModuleXPath}//*[@name='Task Details']");
        public HtmlHorizontalCheckBoxesElement Done => ByXPath<HtmlHorizontalCheckBoxesElement>("Done", $"{DataModuleXPath}//*[@name='Done']");
        
        public HtmlTextboxElement Title => ByXPath<HtmlTextboxElement>("Title", $"{DataModuleXPath}//*[@name='Title']");
        
        public HtmlTextboxElement Description => ByXPath<HtmlTextboxElement>("Description", $"{DataModuleXPath}//*[@name='Description']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// ProjectTaskList
namespace Modules.ProjectTask
{
    public class ProjectTaskList : ModulePageModel
    {
        public ProjectTaskList(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProjectTaskList']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Tasks", $"{DataModuleXPath}//*[@name='Tasks']");
        public ListRow Row(int rowIndex) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { RowIndex = rowIndex };
        public ListRow Row(string containingText) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { ContainingText = containingText };
        public ListRow Row(That that, string text) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { That = that, ContainingText = text };
        
        public HtmlButtonElement AddTaskButton => ByXPath<HtmlButtonElement>("AddTask", $"{DataModuleXPath}//*[@name='AddTask']");
        
        public class ListRow : ListRowPageModel
        {
            public ListRow(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public HtmlTextElement Project => ByXPath<HtmlTextElement>("Project", $"{RowSelector}//*[contains(@name,'.Project')]");
            public HtmlTextElement Title => ByXPath<HtmlTextElement>("Title", $"{RowSelector}//*[contains(@name,'.Title')]");
            public HtmlTextElement Description => ByXPath<HtmlTextElement>("Description", $"{RowSelector}//*[contains(@name,'.Description')]");
            public HtmlTextElement IsDone => ByXPath<HtmlTextElement>("IsDone", $"{RowSelector}//*[contains(@name,'.IsDone')]");
            public HtmlButtonElement ViewButton => ByXPath<HtmlButtonElement>("View", $"{RowSelector}//*[@name='View']");
            public HtmlButtonElement EditButton => ByXPath<HtmlButtonElement>("Edit", $"{RowSelector}//*[@name='Edit']");
            public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{RowSelector}//*[@name='Delete']");
        }
    }
}

// ProjectTaskView
namespace Modules.ProjectTask
{
    public class ProjectTaskView : ModulePageModel
    {
        public ProjectTaskView(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProjectTaskView']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Tasks", $"{DataModuleXPath}//*[@name='Tasks']");
        public HtmlButtonElement BackButton => ByXPath<HtmlButtonElement>("Back", $"{DataModuleXPath}//*[@name='Back']");
    }
}

// ProjectAdd
namespace Modules.Project
{
    public class ProjectAddForm : ModulePageModel
    {
        public ProjectAddForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProjectAdd']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Project Details", $"{DataModuleXPath}//*[@name='Project Details']");
        public HtmlTextboxElement Name => ByXPath<HtmlTextboxElement>("Name", $"{DataModuleXPath}//*[@name='Name']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// ProjectEdit
namespace Modules.Project
{
    public class ProjectEditForm : ModulePageModel
    {
        public ProjectEditForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProjectEdit']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Project Details", $"{DataModuleXPath}//*[@name='Project Details']");
        public HtmlTextboxElement Name => ByXPath<HtmlTextboxElement>("Name", $"{DataModuleXPath}//*[@name='Name']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// ProjectsList
namespace Modules.Project
{
    public class ProjectsList : ModulePageModel
    {
        public ProjectsList(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ProjectsList']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Projects", $"{DataModuleXPath}//*[@name='Projects']");
        public ListRow Row(int rowIndex) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { RowIndex = rowIndex };
        public ListRow Row(string containingText) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { ContainingText = containingText };
        public ListRow Row(That that, string text) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { That = that, ContainingText = text };
        
        public HtmlButtonElement NewProjectButton => ByXPath<HtmlButtonElement>("NewProject", $"{DataModuleXPath}//*[@name='NewProject']");
        
        public class ListRow : ListRowPageModel
        {
            public ListRow(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public HtmlTextElement Name => ByXPath<HtmlTextElement>("Name", $"{RowSelector}//*[contains(@name,'.Name')]");
            public HtmlButtonElement EditButton => ByXPath<HtmlButtonElement>("Edit", $"{RowSelector}//*[@name='Edit']");
            public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{RowSelector}//*[@name='Delete']");
        }
    }
}

// PropertiesList
namespace Modules.Property
{
    public class PropertiesList : ModulePageModel
    {
        public PropertiesList(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='PropertiesList']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Properties", $"{DataModuleXPath}//*[@name='Properties']");
        public ListRow Row(int rowIndex) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { RowIndex = rowIndex };
        public ListRow Row(string containingText) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { ContainingText = containingText };
        public ListRow Row(That that, string text) => new ListRow(UIContext, ListRenderMode.Grid, DataModuleXPath) { That = that, ContainingText = text };
        
        public HtmlTextboxElement FullSearch => ByXPath<HtmlTextboxElement>("FullSearch", $"{DataModuleXPath}//*[@name='FullSearch']");
        
        public HtmlButtonElement SearchButton => ByXPath<HtmlButtonElement>("Search", $"{DataModuleXPath}//*[@name='Search']");
        public HtmlButtonElement NewPropertyButton => ByXPath<HtmlButtonElement>("NewProperty", $"{DataModuleXPath}//*[@name='NewProperty']");
        
        public class ListRow : ListRowPageModel
        {
            public ListRow(UIContext ctx, ListRenderMode listMode, string container) : base(ctx, listMode, container + "//table[contains(concat(' ', normalize-space(@class), ' '), ' grid ')]") { }
            public HtmlTextElement Price => ByXPath<HtmlTextElement>("Price", $"{RowSelector}//*[contains(@name,'.Price')]");
            public HtmlButtonElement C_item_NameButton => ByXPath<HtmlButtonElement>("C_item_Name", $"{RowSelector}//*[@name='C_item_Name']");
            public HtmlButtonElement EditButton => ByXPath<HtmlButtonElement>("Edit", $"{RowSelector}//*[@name='Edit']");
            public HtmlButtonElement DeleteButton => ByXPath<HtmlButtonElement>("Delete", $"{RowSelector}//*[@name='Delete']");
        }
    }
}

// PropertyForm_Address_MergedForm
namespace PropertyForm.Address
{
    public class MergedForm : ModulePageModel
    {
        public MergedForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='PropertyForm_Address_MergedForm']";
        
        public HtmlTextboxElement Address_AddressLine1 => ByXPath<HtmlTextboxElement>("Address_AddressLine1", $"{DataModuleXPath}//*[@name='Address_AddressLine1']");
        
        public HtmlTextboxElement Address_AddressLine2 => ByXPath<HtmlTextboxElement>("Address_AddressLine2", $"{DataModuleXPath}//*[@name='Address_AddressLine2']");
        
        public HtmlTextboxElement Address_Town => ByXPath<HtmlTextboxElement>("Address_Town", $"{DataModuleXPath}//*[@name='Address_Town']");
        
        public HtmlTextboxElement Address_PostalCode => ByXPath<HtmlTextboxElement>("Address_PostalCode", $"{DataModuleXPath}//*[@name='Address_PostalCode']");
    }
}

// PropertyForm
namespace Modules.Property
{
    public class PropertyForm : ModulePageModel
    {
        public PropertyForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='PropertyForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Property Details", $"{DataModuleXPath}//*[@name='Property Details']");
        public HtmlTextboxElement Name => ByXPath<HtmlTextboxElement>("Name", $"{DataModuleXPath}//*[@name='Name']");
        
        public HtmlNumericUpDownElement Price => ByXPath<HtmlNumericUpDownElement>("Price", $"{DataModuleXPath}//*[@name='Price']");
        
        public HtmlTextboxElement Owner => ByXPath<HtmlTextboxElement>("Owner", $"{DataModuleXPath}//*[@name='Owner']");
        
        public HtmlNumericUpDownElement Age => ByXPath<HtmlNumericUpDownElement>("Age", $"{DataModuleXPath}//*[@name='Age']");
        
        public HtmlTextboxElement Address_AddressLine1 => ByXPath<HtmlTextboxElement>("Address_AddressLine1", $"{DataModuleXPath}//*[@name='Address_AddressLine1']");
        
        public HtmlTextboxElement Address_AddressLine2 => ByXPath<HtmlTextboxElement>("Address_AddressLine2", $"{DataModuleXPath}//*[@name='Address_AddressLine2']");
        
        public HtmlTextboxElement Address_Town => ByXPath<HtmlTextboxElement>("Address_Town", $"{DataModuleXPath}//*[@name='Address_Town']");
        
        public HtmlTextboxElement Address_PostalCode => ByXPath<HtmlTextboxElement>("Address_PostalCode", $"{DataModuleXPath}//*[@name='Address_PostalCode']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// PropertyView
namespace Modules.Property
{
    public class PropertyView : ModulePageModel
    {
        public PropertyView(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='PropertyView']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Property Details", $"{DataModuleXPath}//*[@name='Property Details']");
        public HtmlButtonElement CloseButton => ByXPath<HtmlButtonElement>("Close", $"{DataModuleXPath}//*[@name='Close']");
    }
}

// GeneralSettingsForm
namespace Modules.Settings
{
    public class GeneralSettingsForm : ModulePageModel
    {
        public GeneralSettingsForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='GeneralSettingsForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Settings", $"{DataModuleXPath}//*[@name='Settings']");
        public HtmlNumericUpDownElement PasswordResetTicketExpiryMinutes => ByXPath<HtmlNumericUpDownElement>("PasswordResetTicketExpiryMinutes", $"{DataModuleXPath}//*[@name='PasswordResetTicketExpiryMinutes']");
        
        public HtmlButtonElement SaveButton => ByXPath<HtmlButtonElement>("Save", $"{DataModuleXPath}//*[@name='Save']");
    }
}

// ConfirmPasswordReset
namespace Modules.User
{
    public class ConfirmPasswordResetView : ModulePageModel
    {
        public ConfirmPasswordResetView(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ConfirmPasswordReset']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Header", $"{DataModuleXPath}//*[@name='Header']");
        public HtmlButtonElement ProceedToTheLoginPageButton => ByXPath<HtmlButtonElement>("ProceedToTheLoginPage", $"{DataModuleXPath}//*[@name='ProceedToTheLoginPage']");
    }
}

// LoginForm
namespace Modules.User
{
    public class LoginForm : ModulePageModel
    {
        public LoginForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='LoginForm']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Login", $"{DataModuleXPath}//*[@name='Login']");
        public HtmlTextboxElement Email => ByXPath<HtmlTextboxElement>("Email", $"{DataModuleXPath}//*[@name='Email']");
        
        public HtmlTextboxElement Password => ByXPath<HtmlTextboxElement>("Password", $"{DataModuleXPath}//*[@name='Password']");
        
        public HtmlButtonElement LoginButton => ByXPath<HtmlButtonElement>("Login", $"{DataModuleXPath}//*[@name='Login']");
        public HtmlButtonElement ForgotPasswordButton => ByXPath<HtmlButtonElement>("ForgotPassword", $"{DataModuleXPath}//*[@name='ForgotPassword']");
    }
}

// RequestUserPasswordResetTicket
namespace Modules.User
{
    public class RequestUserPasswordResetTicketForm : ModulePageModel
    {
        public RequestUserPasswordResetTicketForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='RequestUserPasswordResetTicket']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Forgot Your Password?", $"{DataModuleXPath}//*[@name='Forgot Your Password?']");
        public HtmlTextboxElement Email => ByXPath<HtmlTextboxElement>("Email", $"{DataModuleXPath}//*[@name='Email']");
        
        public HtmlButtonElement SendButton => ByXPath<HtmlButtonElement>("Send", $"{DataModuleXPath}//*[@name='Send']");
    }
}

// ResetUserPassword
namespace Modules.User
{
    public class ResetUserPasswordForm : ModulePageModel
    {
        public ResetUserPasswordForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='ResetUserPassword']";
        public HtmlTextElement Header => ByXPath<HtmlTextElement>("Reset Your Password", $"{DataModuleXPath}//*[@name='Reset Your Password']");
        public HtmlTextboxElement Password => ByXPath<HtmlTextboxElement>("Password", $"{DataModuleXPath}//*[@name='Password']");
        
        public HtmlButtonElement CancelButton => ByXPath<HtmlButtonElement>("Cancel", $"{DataModuleXPath}//*[@name='Cancel']");
        public HtmlButtonElement ResetButton => ByXPath<HtmlButtonElement>("Reset", $"{DataModuleXPath}//*[@name='Reset']");
    }
}

// SocialMediaLogin
namespace Modules.User
{
    public class SocialMediaLoginForm : ModulePageModel
    {
        public SocialMediaLoginForm(UIContext ctx) : base(ctx) => DataModuleXPath = "//*[@data-module='SocialMediaLogin']";
        
        public HtmlButtonElement FacebookButton => ByXPath<HtmlButtonElement>("Facebook", $"{DataModuleXPath}//*[@name='Facebook']");
        public HtmlButtonElement GoogleButton => ByXPath<HtmlButtonElement>("Google", $"{DataModuleXPath}//*[@name='Google']");
    }
}