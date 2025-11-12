namespace Domain
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using Olive;
    using Olive.Entities;
    using Olive.Entities.Data;
    
    /// <summary>Represents an instance of Product category entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class ProductCategory : GuidEntity
    {
        internal List<Product> cachedProducts;
        
        /// <summary>Initializes a new instance of the ProductCategory class.</summary>
        public ProductCategory() => Deleting += (ev) => ev.Do(Cascade_Deleting);
        
        /// <summary>Gets or sets the value of Name on this Product category instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Name { get; set; }
        
        /// <summary>Gets the Products of this Product category.</summary>
        [Calculated]
        [XmlIgnore, Newtonsoft.Json.JsonIgnore]
        [InverseOf("ProductCategory")]
        public IDatabaseQuery<Product> Products
        {
            get => Database.Of<Product>().Where(p => p.ProductCategoryId == ID);
        }
        
        /// <summary>Returns a textual representation of this Product category.</summary>
        public override string ToString() => Name.OrEmpty();
        
        /// <summary>Returns a clone of this Product category.</summary>
        /// <returns>
        /// A new Product category object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new ProductCategory Clone() => (ProductCategory)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Product category and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Name?.Length > 200)
                result.Add("The provided Name is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Throws a validation exception if any record depends on this Product category which cannot be cascade-deleted.<para/>
        /// </summary>
        public virtual async Task ValidateCanBeDeleted()
        {
            if (await Products.Any())
            {
                throw new ValidationException("This Product category cannot be deleted because of {0} dependent Products.",
                await Products.Count());
            }
        }
        
        /// <summary>Handles the Deleting event of this Product category.</summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The CancelEventArgs instance containing the event data.</param>
        async Task Cascade_Deleting()
        {
            await ValidateCanBeDeleted();
        }
    }
}