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
    
    /// <summary>Represents an instance of Property entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Property : GuidEntity
    {
        /// <summary>Initializes a new instance of the Property class.</summary>
        public Property() => Deleting += (ev) => ev.Do(Cascade_Deleting);
        
        /// <summary>Gets or sets the value of Age on this Property instance.</summary>
        public int? Age { get; set; }
        
        /// <summary>Gets or sets the value of Name on this Property instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Name { get; set; }
        
        /// <summary>Gets or sets the value of Owner on this Property instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Owner { get; set; }
        
        /// <summary>Gets or sets the value of Price on this Property instance.</summary>
        public decimal Price { get; set; }
        
        /// <summary>Gets the Address of this Property.</summary>
        [Calculated]
        [XmlIgnore, Newtonsoft.Json.JsonIgnore]
        public Task<Address> Address
        {
            get => Domain.Address.FindByProperty(this);
        }
        
        /// <summary>Returns a textual representation of this Property.</summary>
        public override string ToString() => Name;
        
        /// <summary>Returns a clone of this Property.</summary>
        /// <returns>
        /// A new Property object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Property Clone() => (Property)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Property and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Age < 0)
                result.Add("The value of Age must be 0 or more.");
            
            if (Name.IsEmpty())
                result.Add("Name cannot be empty.");
            
            if (Name?.Length > 200)
                result.Add("The provided Name is too long. A maximum of 200 characters is acceptable.");
            
            if (Owner.IsEmpty())
                result.Add("Owner cannot be empty.");
            
            if (Owner?.Length > 200)
                result.Add("The provided Owner is too long. A maximum of 200 characters is acceptable.");
            
            if (Price < 0m)
                result.Add("The value of Price must be 0 or more.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
        
        /// <summary>Handles the Deleting event of this Property.</summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The CancelEventArgs instance containing the event data.</param>
        async Task Cascade_Deleting()
        {
            // Cascade delete the dependant Addresses:
            await Database.DeleteAll<Address>(a => a.PropertyId == ID);
        }
    }
}