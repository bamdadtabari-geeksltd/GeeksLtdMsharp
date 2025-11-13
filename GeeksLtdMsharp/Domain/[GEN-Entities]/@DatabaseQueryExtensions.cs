namespace Domain
{
    using System.Linq.Expressions;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Olive;
    using Olive.Entities;
    using Olive.Entities.Data;
    
    /// <summary>Provides the ability to inject filter business logic into database queries.</summary>
    public static partial class DatabaseQueryExtensions
    {
        static IDatabase Database => Context.Current.Database();
        
        /// <summary>Filters the Client records to the ones having any associated Invoices with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Client> HavingAnyInvoices(
            this IDatabaseQuery<Domain.Client> query, Expression<Func<Domain.Invoice, bool>> criteria = null)
        {
            return query.WhereIn(Database.Of<Domain.Invoice>().Where(criteria), x => x.Client);
        }
        
        /// <summary>Filters the Client records to the ones having no associated Invoices with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Client> HavingNoInvoices(
            this IDatabaseQuery<Domain.Client> query, Expression<Func<Domain.Invoice, bool>> criteria = null)
        {
            return query.WhereNotIn(Database.Of<Domain.Invoice>().Where(criteria), x => x.Client);
        }
        
        /// <summary>Filters the Country records to the ones having any associated Cities with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Country> HavingAnyCities(
            this IDatabaseQuery<Domain.Country> query, Expression<Func<Domain.City, bool>> criteria = null)
        {
            return query.WhereIn(Database.Of<Domain.City>().Where(criteria), x => x.Country);
        }
        
        /// <summary>Filters the Country records to the ones having no associated Cities with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Country> HavingNoCities(
            this IDatabaseQuery<Domain.Country> query, Expression<Func<Domain.City, bool>> criteria = null)
        {
            return query.WhereNotIn(Database.Of<Domain.City>().Where(criteria), x => x.Country);
        }
        
        /// <summary>Filters the Country records to the ones having any associated Customers with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Country> HavingAnyCustomers(
            this IDatabaseQuery<Domain.Country> query, Expression<Func<Domain.Customer, bool>> criteria = null)
        {
            return query.WhereIn(Database.Of<Domain.Customer>().Where(criteria), x => x.Country);
        }
        
        /// <summary>Filters the Country records to the ones having no associated Customers with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Country> HavingNoCustomers(
            this IDatabaseQuery<Domain.Country> query, Expression<Func<Domain.Customer, bool>> criteria = null)
        {
            return query.WhereNotIn(Database.Of<Domain.Customer>().Where(criteria), x => x.Country);
        }
        
        /// <summary>Filters the Country records to the ones having any associated Resellers with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Country> HavingAnyResellers(
            this IDatabaseQuery<Domain.Country> query, Expression<Func<Domain.Reseller, bool>> criteria = null)
        {
            return query.WhereIn(Database.Of<Domain.Reseller>().Where(criteria), x => x.Country);
        }
        
        /// <summary>Filters the Country records to the ones having no associated Resellers with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Country> HavingNoResellers(
            this IDatabaseQuery<Domain.Country> query, Expression<Func<Domain.Reseller, bool>> criteria = null)
        {
            return query.WhereNotIn(Database.Of<Domain.Reseller>().Where(criteria), x => x.Country);
        }
        
        /// <summary>
        /// Filters the Developer records to the ones having any associated TimeLogs with the specified criteria.<para/>
        /// </summary>
        public static IDatabaseQuery<Domain.Developer> HavingAnyTimeLogs(
            this IDatabaseQuery<Domain.Developer> query, Expression<Func<Domain.TimeLog, bool>> criteria = null)
        {
            return query.WhereIn(Database.Of<Domain.TimeLog>().Where(criteria), x => x.Developer);
        }
        
        /// <summary>Filters the Developer records to the ones having no associated TimeLogs with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Developer> HavingNoTimeLogs(
            this IDatabaseQuery<Domain.Developer> query, Expression<Func<Domain.TimeLog, bool>> criteria = null)
        {
            return query.WhereNotIn(Database.Of<Domain.TimeLog>().Where(criteria), x => x.Developer);
        }
        
        /// <summary>
        /// Filters the ProductCategory records to the ones having any associated Products with the specified criteria.<para/>
        /// </summary>
        public static IDatabaseQuery<Domain.ProductCategory> HavingAnyProducts(
            this IDatabaseQuery<Domain.ProductCategory> query, Expression<Func<Domain.Product, bool>> criteria = null)
        {
            return query.WhereIn(Database.Of<Domain.Product>().Where(criteria), x => x.ProductCategory);
        }
        
        /// <summary>
        /// Filters the ProductCategory records to the ones having no associated Products with the specified criteria.<para/>
        /// </summary>
        public static IDatabaseQuery<Domain.ProductCategory> HavingNoProducts(
            this IDatabaseQuery<Domain.ProductCategory> query, Expression<Func<Domain.Product, bool>> criteria = null)
        {
            return query.WhereNotIn(Database.Of<Domain.Product>().Where(criteria), x => x.ProductCategory);
        }
        
        /// <summary>Filters the Project2 records to the ones having any associated TimeLogs with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Project2> HavingAnyTimeLogs(
            this IDatabaseQuery<Domain.Project2> query, Expression<Func<Domain.TimeLog, bool>> criteria = null)
        {
            return query.WhereIn(Database.Of<Domain.TimeLog>().Where(criteria), x => x.Project2);
        }
        
        /// <summary>Filters the Project2 records to the ones having no associated TimeLogs with the specified criteria.</summary>
        public static IDatabaseQuery<Domain.Project2> HavingNoTimeLogs(
            this IDatabaseQuery<Domain.Project2> query, Expression<Func<Domain.TimeLog, bool>> criteria = null)
        {
            return query.WhereNotIn(Database.Of<Domain.TimeLog>().Where(criteria), x => x.Project2);
        }
    }
}