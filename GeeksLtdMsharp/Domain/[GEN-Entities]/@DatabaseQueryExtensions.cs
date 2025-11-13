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
    }
}