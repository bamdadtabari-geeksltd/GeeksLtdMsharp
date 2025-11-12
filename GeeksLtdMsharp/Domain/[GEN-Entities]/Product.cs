namespace Domain
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using Olive;
    using Olive.Drawing;
    using Olive.Entities;
    using Olive.Entities.Data;
    
    /// <summary>Represents an instance of Product entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Product : GuidEntity
    {
        /// <summary>Stores the binary information for Photo property.</summary>
        private Blob photo;
        
        CachedReference<ProductCategory> cachedProductCategory = new CachedReference<ProductCategory>();
        Guid? previousProductCategoryId;
        
        /// <summary>Stores the binary information for Thumbnail property.</summary>
        private Blob thumbnail;
        
        /// <summary>Initializes a new instance of the Product class.</summary>
        public Product() => Loaded += (ev) => previousProductCategoryId = ProductCategoryId;
        
        /// <summary>Gets or sets a value indicating whether this Product instance Is Food.</summary>
        [System.ComponentModel.DisplayName("Is Food")]
        public bool IsFood { get; set; }
        
        /// <summary>Gets or sets the value of Name on this Product instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Name { get; set; }
        
        /// <summary>Gets or sets the value of Photo on this Product instance.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public Blob Photo
        {
            get
            {
                if (photo is null) photo = Blob.Empty().Attach(this, "Photo");
                return photo;
            }
            
            set
            {
                if (!(photo is null))
                {
                    // Detach the previous file, so it doesn't get updated or deleted with this Product instance.
                    photo.Detach();
                }
                
                if (value is null)
                {
                    value = Blob.Empty();
                }
                else
                {
                    value.OptimizeImage(10000, 10000, 75);
                }
                
                photo = value.Attach(this, "Photo");
            }
        }
        
        /// <summary>Gets or sets the value of ProductionDate_time on this Product instance.</summary>
        [System.ComponentModel.DisplayName("Production date/time")]
        public DateTime ProductionDate_time { get; set; }
        
        /// <summary>Gets or sets the value of ProductWebsite on this Product instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string ProductWebsite { get; set; }
        
        /// <summary>Gets or sets the value of Thumbnail on this Product instance.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public Blob Thumbnail
        {
            get
            {
                if (thumbnail is null) thumbnail = Blob.Empty().Attach(this, "Thumbnail");
                return thumbnail;
            }
            
            set
            {
                if (!(thumbnail is null))
                {
                    // Detach the previous file, so it doesn't get updated or deleted with this Product instance.
                    thumbnail.Detach();
                }
                
                if (value is null)
                {
                    value = Blob.Empty();
                }
                else
                {
                    value.OptimizeImage(100, 50, 70);
                }
                
                thumbnail = value.Attach(this, "Thumbnail");
            }
        }
        
        /// <summary>Gets or sets the ID of the associated Product Category.</summary>
        public Guid? ProductCategoryId { get; set; }
        
        /// <summary>Gets or sets the value of Product Category on this Product instance.</summary>
        [System.ComponentModel.DisplayName("Product Category")]
        public ProductCategory ProductCategory
        {
            get => cachedProductCategory.Get(ProductCategoryId);
            set => ProductCategoryId = value?.ID;
        }
        
        /// <summary>Returns a textual representation of this Product.</summary>
        public override string ToString() => Name;
        
        /// <summary>Returns a clone of this Product.</summary>
        /// <returns>
        /// A new Product object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Product Clone()
        {
            var result = (Product) base.Clone();
            
            result.Photo = Photo.Clone();
            result.Thumbnail = Thumbnail.Clone();
            return result;
        }
        
        /// <summary>
        /// Validates the data for the properties of this Product and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Name.IsEmpty())
                result.Add("Please Set Product Name");
            
            if (Name?.Length > 200)
                result.Add("The provided Name is too long. A maximum of 200 characters is acceptable.");
            
            if (Photo.IsEmpty())
            {
                result.Add("It is necessary to upload Photo.");
            }
            
            if (!new[] { "png", "jpeg", "jpg" }.Contains(Photo.FileExtension.ToLower().TrimStart('.')))
            {
                result.Add("Only files of the following types are accepted: png, jpeg and jpg");
            }
            
            if (ProductCategoryId == null)
                result.Add("Please provide a value for Product Category.");
            
            if (ProductWebsite.IsEmpty())
                result.Add("Product website cannot be empty.");
            
            if (ProductWebsite?.Length > 200)
                result.Add("The provided Product website is too long. A maximum of 200 characters is acceptable.");
            
            // Ensure ProductWebsite matches Internet URL pattern:
            
            if (ProductWebsite.HasValue() && !System.Text.RegularExpressions.Regex.IsMatch(ProductWebsite, "^(ht|f)tp(s?)\\:\\/\\/[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*(:(0-9)*)*(\\/?)([a-zA-Z0-9\\u00a1-\\uffff\\-\\.\\?\\,\\'\\/\\\\\\\\(\\)\\;+&%\\$#=_]*)?$"))
                result.Add("Please enter the product's website.");
            
            // Ensure the file uploaded for Thumbnail is safe:
            
            if (Thumbnail.HasValue() && Thumbnail.HasUnsafeExtension())result.Add("The file uploaded for Thumbnail is unsafe because of the file extension: {0}".FormatWith(Thumbnail.FileExtension));
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
        
        public override void InvalidateCachedReferences()
        {
            base.InvalidateCachedReferences();
            
            new [] { ProductCategoryId, previousProductCategoryId }.ExceptNull().Distinct()
                .Select(id => Database.Cache().Get<ProductCategory>(id)).ExceptNull().Do(x => x.cachedProducts = null);
        }
    }
}