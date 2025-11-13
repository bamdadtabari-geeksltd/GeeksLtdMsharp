// ********************************************************************
// WARNING: This file is auto-generated from M# Model.
// and may be overwritten at any time. Do not change it manually.
// ********************************************************************

namespace MSharp
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Olive.Entities;
    using Olive;
    using Domain;
    using _F = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using _L = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    
    [EscapeGCop("Auto generated code.")]
    static partial class SchemaExtensions
    {
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Address> AddressLine1(
            this ListModule<Domain.Address>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.AddressLine1, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Address> AddressLine2(
            this ListModule<Domain.Address>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.AddressLine2, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Address> PostalCode(
            this ListModule<Domain.Address>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.PostalCode, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Address> Property(
            this ListModule<Domain.Address>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Property, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Address> Town(
            this ListModule<Domain.Address>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Town, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Administrator> Email(
            this ListModule<Domain.Administrator>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Administrator> FirstName(
            this ListModule<Domain.Administrator>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Administrator> ImpersonationToken(
            this ListModule<Domain.Administrator>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.ImpersonationToken, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Administrator> IsDeactivated(
            this ListModule<Domain.Administrator>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.IsDeactivated, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Administrator> LastName(
            this ListModule<Domain.Administrator>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Administrator> Name(
            this ListModule<Domain.Administrator>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Administrator> Password(
            this ListModule<Domain.Administrator>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Password, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Administrator> Salt(
            this ListModule<Domain.Administrator>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Salt, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Asset> Code(
            this ListModule<Domain.Asset>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Code, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Asset> Cost(
            this ListModule<Domain.Asset>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Cost, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Asset> Name(
            this ListModule<Domain.Asset>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Asset> Owner(
            this ListModule<Domain.Asset>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Owner, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Asset> Type(
            this ListModule<Domain.Asset>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Type, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.AssetType> Name(
            this ListModule<Domain.AssetType>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.AuditEvent> Date(
            this ListModule<Domain.AuditEvent>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.AuditEvent> Event(
            this ListModule<Domain.AuditEvent>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Event, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.AuditEvent> ItemData(
            this ListModule<Domain.AuditEvent>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.ItemData, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.AuditEvent> ItemGroup(
            this ListModule<Domain.AuditEvent>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.ItemGroup, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.AuditEvent> ItemId(
            this ListModule<Domain.AuditEvent>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.ItemId, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.AuditEvent> ItemType(
            this ListModule<Domain.AuditEvent>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.ItemType, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.AuditEvent> UserId(
            this ListModule<Domain.AuditEvent>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.UserId, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.AuditEvent> UserIp(
            this ListModule<Domain.AuditEvent>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.UserIp, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.City> Country(
            this ListModule<Domain.City>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Country, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.City> Name(
            this ListModule<Domain.City>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Client> Company(
            this ListModule<Domain.Client>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Company, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Client> Invoices(
            this ListModule<Domain.Client>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Invoices, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Contact> FirstName(
            this ListModule<Domain.Contact>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Contact> LastName(
            this ListModule<Domain.Contact>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Contact> Name(
            this ListModule<Domain.Contact>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Contact> PhoneNumber(
            this ListModule<Domain.Contact>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.PhoneNumber, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Country> Cities(
            this ListModule<Domain.Country>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Cities, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Country> Customers(
            this ListModule<Domain.Country>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Customers, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Country> IsEuropean(
            this ListModule<Domain.Country>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.IsEuropean, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Country> Name(
            this ListModule<Domain.Country>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Country> Resellers(
            this ListModule<Domain.Country>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Resellers, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Customer> Country(
            this ListModule<Domain.Customer>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Country, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Customer> Name(
            this ListModule<Domain.Customer>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Customer> Reseller(
            this ListModule<Domain.Customer>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Reseller, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Developer> FirstName(
            this ListModule<Domain.Developer>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Developer> FullName(
            this ListModule<Domain.Developer>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.FullName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Developer> LastName(
            this ListModule<Domain.Developer>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Developer> LatestWork(
            this ListModule<Domain.Developer>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.LatestWork, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Developer> TimeLogs(
            this ListModule<Domain.Developer>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.TimeLogs, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Developer> TotalWork(
            this ListModule<Domain.Developer>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.TotalWork, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Employee> Email(
            this ListModule<Domain.Employee>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Employee> FirstName(
            this ListModule<Domain.Employee>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Employee> IDCard(
            this ListModule<Domain.Employee>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.IDCard, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Employee> LastName(
            this ListModule<Domain.Employee>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Employee> Warnings(
            this ListModule<Domain.Employee>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Warnings, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Invoice> Amount(
            this ListModule<Domain.Invoice>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Amount, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Invoice> Client(
            this ListModule<Domain.Invoice>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Client, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Invoice> Date(
            this ListModule<Domain.Invoice>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Invoice> Description(
            this ListModule<Domain.Invoice>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Description, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.LogonFailure> Attempts(
            this ListModule<Domain.LogonFailure>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Attempts, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.LogonFailure> Date(
            this ListModule<Domain.LogonFailure>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.LogonFailure> Email(
            this ListModule<Domain.LogonFailure>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.LogonFailure> IP(
            this ListModule<Domain.LogonFailure>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.IP, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Owner> FirstName(
            this ListModule<Domain.Owner>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Owner> LastName(
            this ListModule<Domain.Owner>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.PasswordResetTicket> DateCreated(
            this ListModule<Domain.PasswordResetTicket>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.DateCreated, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.PasswordResetTicket> IsExpired(
            this ListModule<Domain.PasswordResetTicket>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.IsExpired, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.PasswordResetTicket> IsUsed(
            this ListModule<Domain.PasswordResetTicket>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.IsUsed, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.PasswordResetTicket> User(
            this ListModule<Domain.PasswordResetTicket>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.User, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Product> IsFood(
            this ListModule<Domain.Product>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.IsFood, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Product> Name(
            this ListModule<Domain.Product>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Product> Photo(
            this ListModule<Domain.Product>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Photo, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Product> ProductCategory(
            this ListModule<Domain.Product>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.ProductCategory, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Product> ProductionDate_time(
            this ListModule<Domain.Product>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.ProductionDate_time, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Product> ProductWebsite(
            this ListModule<Domain.Product>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.ProductWebsite, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Product> Thumbnail(
            this ListModule<Domain.Product>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Thumbnail, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.ProductCategory> Name(
            this ListModule<Domain.ProductCategory>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.ProductCategory> Products(
            this ListModule<Domain.ProductCategory>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Products, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Project> Name(
            this ListModule<Domain.Project>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.ProjectTask> Description(
            this ListModule<Domain.ProjectTask>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Description, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.ProjectTask> Done(
            this ListModule<Domain.ProjectTask>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Done, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.ProjectTask> Project(
            this ListModule<Domain.ProjectTask>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Project, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.ProjectTask> Title(
            this ListModule<Domain.ProjectTask>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Title, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Project2> Name(
            this ListModule<Domain.Project2>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Project2> TimeLogs(
            this ListModule<Domain.Project2>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.TimeLogs, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Project2> TotalWorkHours(
            this ListModule<Domain.Project2>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.TotalWorkHours, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Property> Address(
            this ListModule<Domain.Property>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Address, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Property> Age(
            this ListModule<Domain.Property>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Age, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Property> Name(
            this ListModule<Domain.Property>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Property> Owner(
            this ListModule<Domain.Property>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Owner, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Property> Price(
            this ListModule<Domain.Property>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Price, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Register> DateOfBirth(
            this ListModule<Domain.Register>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.DateOfBirth, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Register> Email(
            this ListModule<Domain.Register>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Register> FirstName(
            this ListModule<Domain.Register>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Register> InvitationCode(
            this ListModule<Domain.Register>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.InvitationCode, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Register> LastName(
            this ListModule<Domain.Register>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Register> Password(
            this ListModule<Domain.Register>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Password, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Reseller> Country(
            this ListModule<Domain.Reseller>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Country, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Reseller> Name(
            this ListModule<Domain.Reseller>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Settings> CacheVersion(
            this ListModule<Domain.Settings>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.CacheVersion, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Settings> Name(
            this ListModule<Domain.Settings>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.Settings> PasswordResetTicketExpiryMinutes(
            this ListModule<Domain.Settings>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.PasswordResetTicketExpiryMinutes, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.TimeLog> Date(
            this ListModule<Domain.TimeLog>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.TimeLog> Details(
            this ListModule<Domain.TimeLog>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Details, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.TimeLog> Developer(
            this ListModule<Domain.TimeLog>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Developer, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.TimeLog> EndTime(
            this ListModule<Domain.TimeLog>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.EndTime, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.TimeLog> Hours(
            this ListModule<Domain.TimeLog>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Hours, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.TimeLog> Project2(
            this ListModule<Domain.TimeLog>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Project2, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.TimeLog> StartTime(
            this ListModule<Domain.TimeLog>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.StartTime, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.User> Email(
            this ListModule<Domain.User>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.User> FirstName(
            this ListModule<Domain.User>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.User> IsDeactivated(
            this ListModule<Domain.User>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.IsDeactivated, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.User> LastName(
            this ListModule<Domain.User>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.User> Name(
            this ListModule<Domain.User>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.User> Password(
            this ListModule<Domain.User>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Password, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static PropertyFilterElement<Domain.User> Salt(
            this ListModule<Domain.User>.SearchComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Search(x => x.Salt, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Address, string> AddressLine1(
            this ViewModule<Domain.Address>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.AddressLine1, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Address, string> AddressLine2(
            this ViewModule<Domain.Address>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.AddressLine2, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Address, string> PostalCode(
            this ViewModule<Domain.Address>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.PostalCode, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Address, Domain.Property> Property(
            this ViewModule<Domain.Address>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Property, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Address, string> Town(
            this ViewModule<Domain.Address>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Town, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Administrator, string> Email(
            this ViewModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Administrator, string> FirstName(
            this ViewModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Administrator, string> ImpersonationToken(
            this ViewModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ImpersonationToken, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Administrator, bool> IsDeactivated(
            this ViewModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsDeactivated, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Administrator, string> LastName(
            this ViewModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Administrator, string> Name(
            this ViewModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Administrator, string> Password(
            this ViewModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Password, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Administrator, string> Salt(
            this ViewModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Salt, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Asset, string> Code(
            this ViewModule<Domain.Asset>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Code, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Asset, decimal?> Cost(
            this ViewModule<Domain.Asset>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Cost, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Asset, string> Name(
            this ViewModule<Domain.Asset>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Asset, Domain.Owner> Owner(
            this ViewModule<Domain.Asset>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Owner, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Asset, Domain.AssetType> Type(
            this ViewModule<Domain.Asset>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Type, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.AssetType, string> Name(
            this ViewModule<Domain.AssetType>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.AuditEvent, DateTime> Date(
            this ViewModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.AuditEvent, string> Event(
            this ViewModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Event, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.AuditEvent, string> ItemData(
            this ViewModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ItemData, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.AuditEvent, string> ItemGroup(
            this ViewModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ItemGroup, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.AuditEvent, string> ItemId(
            this ViewModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ItemId, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.AuditEvent, string> ItemType(
            this ViewModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ItemType, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.AuditEvent, string> UserId(
            this ViewModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.UserId, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.AuditEvent, string> UserIp(
            this ViewModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.UserIp, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.City, Domain.Country> Country(
            this ViewModule<Domain.City>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Country, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.City, string> Name(
            this ViewModule<Domain.City>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Client, string> Company(
            this ViewModule<Domain.Client>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Company, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Client, IDatabaseQuery<Domain.Invoice>> Invoices(
            this ViewModule<Domain.Client>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Invoices, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Contact, string> FirstName(
            this ViewModule<Domain.Contact>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Contact, string> LastName(
            this ViewModule<Domain.Contact>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Contact, string> Name(
            this ViewModule<Domain.Contact>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Contact, string> PhoneNumber(
            this ViewModule<Domain.Contact>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.PhoneNumber, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Country, IDatabaseQuery<Domain.City>> Cities(
            this ViewModule<Domain.Country>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Cities, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Country, IDatabaseQuery<Domain.Customer>> Customers(
            this ViewModule<Domain.Country>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Customers, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Country, bool> IsEuropean(
            this ViewModule<Domain.Country>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsEuropean, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Country, string> Name(
            this ViewModule<Domain.Country>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Country, IDatabaseQuery<Domain.Reseller>> Resellers(
            this ViewModule<Domain.Country>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Resellers, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Customer, Domain.Country> Country(
            this ViewModule<Domain.Customer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Country, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Customer, string> Name(
            this ViewModule<Domain.Customer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Customer, Domain.Reseller> Reseller(
            this ViewModule<Domain.Customer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Reseller, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Developer, string> FirstName(
            this ViewModule<Domain.Developer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Developer, string> FullName(
            this ViewModule<Domain.Developer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FullName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Developer, string> LastName(
            this ViewModule<Domain.Developer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Developer, string> LatestWork(
            this ViewModule<Domain.Developer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LatestWork, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Developer, IDatabaseQuery<Domain.TimeLog>> TimeLogs(
            this ViewModule<Domain.Developer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.TimeLogs, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Developer, decimal> TotalWork(
            this ViewModule<Domain.Developer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.TotalWork, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Employee, string> Email(
            this ViewModule<Domain.Employee>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Employee, string> FirstName(
            this ViewModule<Domain.Employee>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Employee, Blob> IDCard(
            this ViewModule<Domain.Employee>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IDCard, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Employee, string> LastName(
            this ViewModule<Domain.Employee>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Employee, string> Warnings(
            this ViewModule<Domain.Employee>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Warnings, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Invoice, decimal?> Amount(
            this ViewModule<Domain.Invoice>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Amount, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Invoice, Domain.Client> Client(
            this ViewModule<Domain.Invoice>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Client, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Invoice, DateTime?> Date(
            this ViewModule<Domain.Invoice>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Invoice, string> Description(
            this ViewModule<Domain.Invoice>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Description, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.LogonFailure, int> Attempts(
            this ViewModule<Domain.LogonFailure>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Attempts, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.LogonFailure, DateTime> Date(
            this ViewModule<Domain.LogonFailure>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.LogonFailure, string> Email(
            this ViewModule<Domain.LogonFailure>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.LogonFailure, string> IP(
            this ViewModule<Domain.LogonFailure>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IP, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Owner, string> FirstName(
            this ViewModule<Domain.Owner>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Owner, string> LastName(
            this ViewModule<Domain.Owner>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.PasswordResetTicket, DateTime> DateCreated(
            this ViewModule<Domain.PasswordResetTicket>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.DateCreated, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.PasswordResetTicket, bool> IsExpired(
            this ViewModule<Domain.PasswordResetTicket>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsExpired, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.PasswordResetTicket, bool> IsUsed(
            this ViewModule<Domain.PasswordResetTicket>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsUsed, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.PasswordResetTicket, Domain.User> User(
            this ViewModule<Domain.PasswordResetTicket>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.User, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Product, bool> IsFood(
            this ViewModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsFood, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Product, string> Name(
            this ViewModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Product, Blob> Photo(
            this ViewModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Photo, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Product, Domain.ProductCategory> ProductCategory(
            this ViewModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ProductCategory, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Product, DateTime> ProductionDate_time(
            this ViewModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ProductionDate_time, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Product, string> ProductWebsite(
            this ViewModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ProductWebsite, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Product, Blob> Thumbnail(
            this ViewModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Thumbnail, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.ProductCategory, string> Name(
            this ViewModule<Domain.ProductCategory>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.ProductCategory, IDatabaseQuery<Domain.Product>> Products(
            this ViewModule<Domain.ProductCategory>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Products, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Project, string> Name(
            this ViewModule<Domain.Project>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.ProjectTask, string> Description(
            this ViewModule<Domain.ProjectTask>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Description, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.ProjectTask, bool> Done(
            this ViewModule<Domain.ProjectTask>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Done, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.ProjectTask, Domain.Project> Project(
            this ViewModule<Domain.ProjectTask>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Project, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.ProjectTask, string> Title(
            this ViewModule<Domain.ProjectTask>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Title, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Project2, string> Name(
            this ViewModule<Domain.Project2>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Project2, IDatabaseQuery<Domain.TimeLog>> TimeLogs(
            this ViewModule<Domain.Project2>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.TimeLogs, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Project2, decimal> TotalWorkHours(
            this ViewModule<Domain.Project2>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.TotalWorkHours, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Property, Task<Address>> Address(
            this ViewModule<Domain.Property>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Address, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Property, int?> Age(
            this ViewModule<Domain.Property>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Age, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Property, string> Name(
            this ViewModule<Domain.Property>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Property, string> Owner(
            this ViewModule<Domain.Property>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Owner, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Property, decimal> Price(
            this ViewModule<Domain.Property>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Price, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Register, DateTime> DateOfBirth(
            this ViewModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.DateOfBirth, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Register, string> Email(
            this ViewModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Register, string> FirstName(
            this ViewModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Register, string> InvitationCode(
            this ViewModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.InvitationCode, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Register, string> LastName(
            this ViewModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Register, string> Password(
            this ViewModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Password, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Reseller, Domain.Country> Country(
            this ViewModule<Domain.Reseller>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Country, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Reseller, string> Name(
            this ViewModule<Domain.Reseller>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Settings, int> CacheVersion(
            this ViewModule<Domain.Settings>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.CacheVersion, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Settings, string> Name(
            this ViewModule<Domain.Settings>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.Settings, int> PasswordResetTicketExpiryMinutes(
            this ViewModule<Domain.Settings>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.PasswordResetTicketExpiryMinutes, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.TimeLog, DateTime> Date(
            this ViewModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.TimeLog, string> Details(
            this ViewModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Details, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.TimeLog, Domain.Developer> Developer(
            this ViewModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Developer, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.TimeLog, TimeSpan> EndTime(
            this ViewModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.EndTime, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.TimeLog, decimal> Hours(
            this ViewModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Hours, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.TimeLog, Domain.Project2> Project2(
            this ViewModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Project2, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.TimeLog, TimeSpan> StartTime(
            this ViewModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.StartTime, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.User, string> Email(
            this ViewModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.User, string> FirstName(
            this ViewModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.User, bool> IsDeactivated(
            this ViewModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsDeactivated, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.User, string> LastName(
            this ViewModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.User, string> Name(
            this ViewModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.User, string> Password(
            this ViewModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Password, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static ViewElement<Domain.User, string> Salt(
            this ViewModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Salt, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Address, string> AddressLine1(
            this ListModule<Domain.Address>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.AddressLine1, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Address, string> AddressLine2(
            this ListModule<Domain.Address>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.AddressLine2, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Address, string> PostalCode(
            this ListModule<Domain.Address>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.PostalCode, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Address, Domain.Property> Property(
            this ListModule<Domain.Address>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Property, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Address, string> Town(
            this ListModule<Domain.Address>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Town, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Administrator, string> Email(
            this ListModule<Domain.Administrator>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Email, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Administrator, string> FirstName(
            this ListModule<Domain.Administrator>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.FirstName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Administrator, string> ImpersonationToken(
            this ListModule<Domain.Administrator>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.ImpersonationToken, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Administrator, bool> IsDeactivated(
            this ListModule<Domain.Administrator>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.IsDeactivated, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Administrator, string> LastName(
            this ListModule<Domain.Administrator>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.LastName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Administrator, string> Name(
            this ListModule<Domain.Administrator>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Administrator, string> Password(
            this ListModule<Domain.Administrator>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Password, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Administrator, string> Salt(
            this ListModule<Domain.Administrator>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Salt, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Asset, string> Code(
            this ListModule<Domain.Asset>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Code, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Asset, decimal?> Cost(
            this ListModule<Domain.Asset>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Cost, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Asset, string> Name(
            this ListModule<Domain.Asset>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Asset, Domain.Owner> Owner(
            this ListModule<Domain.Asset>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Owner, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Asset, Domain.AssetType> Type(
            this ListModule<Domain.Asset>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Type, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.AssetType, string> Name(
            this ListModule<Domain.AssetType>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.AuditEvent, DateTime> Date(
            this ListModule<Domain.AuditEvent>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Date, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.AuditEvent, string> Event(
            this ListModule<Domain.AuditEvent>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Event, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.AuditEvent, string> ItemData(
            this ListModule<Domain.AuditEvent>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.ItemData, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.AuditEvent, string> ItemGroup(
            this ListModule<Domain.AuditEvent>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.ItemGroup, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.AuditEvent, string> ItemId(
            this ListModule<Domain.AuditEvent>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.ItemId, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.AuditEvent, string> ItemType(
            this ListModule<Domain.AuditEvent>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.ItemType, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.AuditEvent, string> UserId(
            this ListModule<Domain.AuditEvent>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.UserId, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.AuditEvent, string> UserIp(
            this ListModule<Domain.AuditEvent>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.UserIp, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.City, Domain.Country> Country(
            this ListModule<Domain.City>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Country, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.City, string> Name(
            this ListModule<Domain.City>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Client, string> Company(
            this ListModule<Domain.Client>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Company, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Client, IDatabaseQuery<Domain.Invoice>> Invoices(
            this ListModule<Domain.Client>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Invoices, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Contact, string> FirstName(
            this ListModule<Domain.Contact>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.FirstName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Contact, string> LastName(
            this ListModule<Domain.Contact>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.LastName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Contact, string> Name(
            this ListModule<Domain.Contact>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Contact, string> PhoneNumber(
            this ListModule<Domain.Contact>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.PhoneNumber, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Country, IDatabaseQuery<Domain.City>> Cities(
            this ListModule<Domain.Country>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Cities, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Country, IDatabaseQuery<Domain.Customer>> Customers(
            this ListModule<Domain.Country>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Customers, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Country, bool> IsEuropean(
            this ListModule<Domain.Country>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.IsEuropean, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Country, string> Name(
            this ListModule<Domain.Country>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Country, IDatabaseQuery<Domain.Reseller>> Resellers(
            this ListModule<Domain.Country>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Resellers, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Customer, Domain.Country> Country(
            this ListModule<Domain.Customer>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Country, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Customer, string> Name(
            this ListModule<Domain.Customer>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Customer, Domain.Reseller> Reseller(
            this ListModule<Domain.Customer>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Reseller, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Developer, string> FirstName(
            this ListModule<Domain.Developer>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.FirstName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Developer, string> FullName(
            this ListModule<Domain.Developer>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.FullName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Developer, string> LastName(
            this ListModule<Domain.Developer>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.LastName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Developer, string> LatestWork(
            this ListModule<Domain.Developer>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.LatestWork, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Developer, IDatabaseQuery<Domain.TimeLog>> TimeLogs(
            this ListModule<Domain.Developer>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.TimeLogs, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Developer, decimal> TotalWork(
            this ListModule<Domain.Developer>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.TotalWork, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Employee, string> Email(
            this ListModule<Domain.Employee>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Email, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Employee, string> FirstName(
            this ListModule<Domain.Employee>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.FirstName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Employee, Blob> IDCard(
            this ListModule<Domain.Employee>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.IDCard, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Employee, string> LastName(
            this ListModule<Domain.Employee>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.LastName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Employee, string> Warnings(
            this ListModule<Domain.Employee>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Warnings, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Invoice, decimal?> Amount(
            this ListModule<Domain.Invoice>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Amount, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Invoice, Domain.Client> Client(
            this ListModule<Domain.Invoice>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Client, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Invoice, DateTime?> Date(
            this ListModule<Domain.Invoice>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Date, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Invoice, string> Description(
            this ListModule<Domain.Invoice>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Description, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.LogonFailure, int> Attempts(
            this ListModule<Domain.LogonFailure>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Attempts, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.LogonFailure, DateTime> Date(
            this ListModule<Domain.LogonFailure>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Date, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.LogonFailure, string> Email(
            this ListModule<Domain.LogonFailure>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Email, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.LogonFailure, string> IP(
            this ListModule<Domain.LogonFailure>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.IP, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Owner, string> FirstName(
            this ListModule<Domain.Owner>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.FirstName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Owner, string> LastName(
            this ListModule<Domain.Owner>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.LastName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.PasswordResetTicket, DateTime> DateCreated(
            this ListModule<Domain.PasswordResetTicket>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.DateCreated, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.PasswordResetTicket, bool> IsExpired(
            this ListModule<Domain.PasswordResetTicket>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.IsExpired, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.PasswordResetTicket, bool> IsUsed(
            this ListModule<Domain.PasswordResetTicket>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.IsUsed, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.PasswordResetTicket, Domain.User> User(
            this ListModule<Domain.PasswordResetTicket>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.User, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Product, bool> IsFood(
            this ListModule<Domain.Product>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.IsFood, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Product, string> Name(
            this ListModule<Domain.Product>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Product, Blob> Photo(
            this ListModule<Domain.Product>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Photo, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Product, Domain.ProductCategory> ProductCategory(
            this ListModule<Domain.Product>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.ProductCategory, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Product, DateTime> ProductionDate_time(
            this ListModule<Domain.Product>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.ProductionDate_time, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Product, string> ProductWebsite(
            this ListModule<Domain.Product>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.ProductWebsite, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Product, Blob> Thumbnail(
            this ListModule<Domain.Product>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Thumbnail, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.ProductCategory, string> Name(
            this ListModule<Domain.ProductCategory>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.ProductCategory, IDatabaseQuery<Domain.Product>> Products(
            this ListModule<Domain.ProductCategory>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Products, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Project, string> Name(
            this ListModule<Domain.Project>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.ProjectTask, string> Description(
            this ListModule<Domain.ProjectTask>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Description, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.ProjectTask, bool> Done(
            this ListModule<Domain.ProjectTask>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Done, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.ProjectTask, Domain.Project> Project(
            this ListModule<Domain.ProjectTask>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Project, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.ProjectTask, string> Title(
            this ListModule<Domain.ProjectTask>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Title, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Project2, string> Name(
            this ListModule<Domain.Project2>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Project2, IDatabaseQuery<Domain.TimeLog>> TimeLogs(
            this ListModule<Domain.Project2>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.TimeLogs, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Project2, decimal> TotalWorkHours(
            this ListModule<Domain.Project2>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.TotalWorkHours, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Property, Task<Address>> Address(
            this ListModule<Domain.Property>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Address, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Property, int?> Age(
            this ListModule<Domain.Property>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Age, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Property, string> Name(
            this ListModule<Domain.Property>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Property, string> Owner(
            this ListModule<Domain.Property>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Owner, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Property, decimal> Price(
            this ListModule<Domain.Property>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Price, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Register, DateTime> DateOfBirth(
            this ListModule<Domain.Register>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.DateOfBirth, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Register, string> Email(
            this ListModule<Domain.Register>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Email, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Register, string> FirstName(
            this ListModule<Domain.Register>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.FirstName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Register, string> InvitationCode(
            this ListModule<Domain.Register>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.InvitationCode, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Register, string> LastName(
            this ListModule<Domain.Register>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.LastName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Register, string> Password(
            this ListModule<Domain.Register>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Password, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Reseller, Domain.Country> Country(
            this ListModule<Domain.Reseller>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Country, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Reseller, string> Name(
            this ListModule<Domain.Reseller>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Settings, int> CacheVersion(
            this ListModule<Domain.Settings>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.CacheVersion, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Settings, string> Name(
            this ListModule<Domain.Settings>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.Settings, int> PasswordResetTicketExpiryMinutes(
            this ListModule<Domain.Settings>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.PasswordResetTicketExpiryMinutes, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.TimeLog, DateTime> Date(
            this ListModule<Domain.TimeLog>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Date, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.TimeLog, string> Details(
            this ListModule<Domain.TimeLog>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Details, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.TimeLog, Domain.Developer> Developer(
            this ListModule<Domain.TimeLog>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Developer, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.TimeLog, TimeSpan> EndTime(
            this ListModule<Domain.TimeLog>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.EndTime, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.TimeLog, decimal> Hours(
            this ListModule<Domain.TimeLog>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Hours, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.TimeLog, Domain.Project2> Project2(
            this ListModule<Domain.TimeLog>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Project2, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.TimeLog, TimeSpan> StartTime(
            this ListModule<Domain.TimeLog>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.StartTime, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.User, string> Email(
            this ListModule<Domain.User>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Email, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.User, string> FirstName(
            this ListModule<Domain.User>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.FirstName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.User, bool> IsDeactivated(
            this ListModule<Domain.User>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.IsDeactivated, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.User, string> LastName(
            this ListModule<Domain.User>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.LastName, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.User, string> Name(
            this ListModule<Domain.User>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Name, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.User, string> Password(
            this ListModule<Domain.User>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Password, fl, ln);
        
        [MethodColor("#0CCC68")]
        public static ViewElement<Domain.User, string> Salt(
            this ListModule<Domain.User>.ColumnComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Column(x => x.Salt, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement AddressLine1(
            this FormModule<Domain.Address>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.AddressLine1, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement AddressLine2(
            this FormModule<Domain.Address>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.AddressLine2, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement PostalCode(
            this FormModule<Domain.Address>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.PostalCode, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Property(
            this FormModule<Domain.Address>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Property, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Town(
            this FormModule<Domain.Address>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Town, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Email(
            this FormModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement FirstName(
            this FormModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement ImpersonationToken(
            this FormModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ImpersonationToken, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static BooleanFormElement IsDeactivated(
            this FormModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsDeactivated, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement LastName(
            this FormModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Password(
            this FormModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Password, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Salt(
            this FormModule<Domain.Administrator>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Salt, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Code(
            this FormModule<Domain.Asset>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Code, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static NumberFormElement Cost(
            this FormModule<Domain.Asset>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Cost, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.Asset>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Owner(
            this FormModule<Domain.Asset>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Owner, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Type(
            this FormModule<Domain.Asset>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Type, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.AssetType>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement Date(
            this FormModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Event(
            this FormModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Event, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement ItemData(
            this FormModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ItemData, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement ItemGroup(
            this FormModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ItemGroup, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement ItemId(
            this FormModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ItemId, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement ItemType(
            this FormModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ItemType, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement UserId(
            this FormModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.UserId, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement UserIp(
            this FormModule<Domain.AuditEvent>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.UserIp, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Country(
            this FormModule<Domain.City>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Country, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.City>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Company(
            this FormModule<Domain.Client>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Company, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Invoices(
            this FormModule<Domain.Client>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Invoices, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement FirstName(
            this FormModule<Domain.Contact>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement LastName(
            this FormModule<Domain.Contact>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.Contact>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement PhoneNumber(
            this FormModule<Domain.Contact>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.PhoneNumber, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Cities(
            this FormModule<Domain.Country>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Cities, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Customers(
            this FormModule<Domain.Country>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Customers, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static BooleanFormElement IsEuropean(
            this FormModule<Domain.Country>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsEuropean, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.Country>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Resellers(
            this FormModule<Domain.Country>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Resellers, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Country(
            this FormModule<Domain.Customer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Country, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.Customer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Reseller(
            this FormModule<Domain.Customer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Reseller, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement FirstName(
            this FormModule<Domain.Developer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement LastName(
            this FormModule<Domain.Developer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement TimeLogs(
            this FormModule<Domain.Developer>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.TimeLogs, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Email(
            this FormModule<Domain.Employee>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement FirstName(
            this FormModule<Domain.Employee>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static BinaryFormElement IDCard(
            this FormModule<Domain.Employee>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IDCard, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement LastName(
            this FormModule<Domain.Employee>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static NumberFormElement Amount(
            this FormModule<Domain.Invoice>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Amount, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Client(
            this FormModule<Domain.Invoice>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Client, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement Date(
            this FormModule<Domain.Invoice>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Description(
            this FormModule<Domain.Invoice>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Description, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static NumberFormElement Attempts(
            this FormModule<Domain.LogonFailure>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Attempts, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement Date(
            this FormModule<Domain.LogonFailure>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Email(
            this FormModule<Domain.LogonFailure>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement IP(
            this FormModule<Domain.LogonFailure>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IP, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement FirstName(
            this FormModule<Domain.Owner>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement LastName(
            this FormModule<Domain.Owner>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement DateCreated(
            this FormModule<Domain.PasswordResetTicket>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.DateCreated, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static BooleanFormElement IsUsed(
            this FormModule<Domain.PasswordResetTicket>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsUsed, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement User(
            this FormModule<Domain.PasswordResetTicket>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.User, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static BooleanFormElement IsFood(
            this FormModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsFood, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static BinaryFormElement Photo(
            this FormModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Photo, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement ProductCategory(
            this FormModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ProductCategory, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement ProductionDate_time(
            this FormModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ProductionDate_time, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement ProductWebsite(
            this FormModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.ProductWebsite, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static BinaryFormElement Thumbnail(
            this FormModule<Domain.Product>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Thumbnail, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.ProductCategory>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Products(
            this FormModule<Domain.ProductCategory>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Products, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.Project>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Description(
            this FormModule<Domain.ProjectTask>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Description, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static BooleanFormElement Done(
            this FormModule<Domain.ProjectTask>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Done, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Project(
            this FormModule<Domain.ProjectTask>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Project, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Title(
            this FormModule<Domain.ProjectTask>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Title, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.Project2>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement TimeLogs(
            this FormModule<Domain.Project2>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.TimeLogs, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Address(
            this FormModule<Domain.Property>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Address, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static NumberFormElement Age(
            this FormModule<Domain.Property>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Age, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.Property>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Owner(
            this FormModule<Domain.Property>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Owner, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static NumberFormElement Price(
            this FormModule<Domain.Property>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Price, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement DateOfBirth(
            this FormModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.DateOfBirth, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Email(
            this FormModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement FirstName(
            this FormModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement LastName(
            this FormModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Password(
            this FormModule<Domain.Register>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Password, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Country(
            this FormModule<Domain.Reseller>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Country, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.Reseller>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static NumberFormElement CacheVersion(
            this FormModule<Domain.Settings>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.CacheVersion, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(
            this FormModule<Domain.Settings>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Name, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static NumberFormElement PasswordResetTicketExpiryMinutes(
            this FormModule<Domain.Settings>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.PasswordResetTicketExpiryMinutes, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement Date(
            this FormModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Date, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Details(
            this FormModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Details, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Developer(
            this FormModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Developer, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement EndTime(
            this FormModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.EndTime, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement Project2(
            this FormModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Project2, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement StartTime(
            this FormModule<Domain.TimeLog>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.StartTime, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Email(
            this FormModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Email, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement FirstName(
            this FormModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.FirstName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static BooleanFormElement IsDeactivated(
            this FormModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.IsDeactivated, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement LastName(
            this FormModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.LastName, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Password(
            this FormModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Password, fl, ln);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Salt(
            this FormModule<Domain.User>.FieldComponents @this, [_F] string fl = null, [_L] int ln = 0)
        => @this.container.Field(x => x.Salt, fl, ln);
    }
}