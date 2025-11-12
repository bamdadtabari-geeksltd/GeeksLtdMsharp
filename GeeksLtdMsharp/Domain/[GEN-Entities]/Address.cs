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
    
    /// <summary>Represents an instance of Address entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Address : GuidEntity
    {
        CachedReference<Property> cachedProperty = new CachedReference<Property>();
        
        /// <summary>Gets or sets the value of AddressLine1 on this Address instance.</summary>
        [System.ComponentModel.DisplayName("Address Line 1")]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string AddressLine1 { get; set; }
        
        /// <summary>Gets or sets the value of AddressLine2 on this Address instance.</summary>
        [System.ComponentModel.DisplayName("Address Line 2")]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string AddressLine2 { get; set; }
        
        /// <summary>Gets or sets the value of PostalCode on this Address instance.</summary>
        [System.ComponentModel.DisplayName("Postal Code")]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string PostalCode { get; set; }
        
        /// <summary>Gets or sets the value of Town on this Address instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Town { get; set; }
        
        /// <summary>Gets or sets the ID of the associated Property.</summary>
        public Guid? PropertyId { get; set; }
        
        /// <summary>Gets or sets the value of Property on this Address instance.</summary>
        public Property Property
        {
            get => cachedProperty.Get(PropertyId);
            set => PropertyId = value?.ID;
        }
        
        /// <summary>
        /// Find and returns an instance of Address from the database by its Property.<para/>
        ///                               If no matching Address is found, it returns Null.<para/>
        /// </summary>
        /// <param name="property">The Property of the requested Address.</param>
        /// <returns>
        /// The Address instance with the specified Property or null if there is no Address with that Property in the database.<para/>
        /// </returns>
        public static Task<Address> FindByProperty(Domain.Property property)
        {
            return Database.FirstOrDefault<Address>(a => a.PropertyId == property);
        }
        
        /// <summary>Returns a textual representation of this Address.</summary>
        public override string ToString() => AddressLine1;
        
        /// <summary>Returns a clone of this Address.</summary>
        /// <returns>
        /// A new Address object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Address Clone() => (Address)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Address and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override async Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (AddressLine1.IsEmpty())
                result.Add("Address Line 1 cannot be empty.");
            
            if (AddressLine1?.Length > 200)
                result.Add("The provided Address Line 1 is too long. A maximum of 200 characters is acceptable.");
            
            if (AddressLine2.IsEmpty())
                result.Add("Address Line 2 cannot be empty.");
            
            if (AddressLine2?.Length > 200)
                result.Add("The provided Address Line 2 is too long. A maximum of 200 characters is acceptable.");
            
            if (PostalCode.IsEmpty())
                result.Add("Postal Code cannot be empty.");
            
            if (PostalCode?.Length > 200)
                result.Add("The provided Postal Code is too long. A maximum of 200 characters is acceptable.");
            
            if (PropertyId == null)
                result.Add("Please provide a value for Property.");
            // Ensure uniqueness of Property.
            
            if (await Database.Any<Address>(a => a.PropertyId == PropertyId && a != this))
                result.Add("Property must be unique. There is an existing Address record with the provided Property.");
            
            if (Town.IsEmpty())
                result.Add("Town cannot be empty.");
            
            if (Town?.Length > 200)
                result.Add("The provided Town is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
        }
    }
}