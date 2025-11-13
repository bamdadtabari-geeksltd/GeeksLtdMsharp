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
    
    /// <summary>Represents an instance of Invoice entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Invoice : GuidEntity
    {
        CachedReference<Client> cachedClient = new CachedReference<Client>();
        Guid? previousClientId;
        
        /// <summary>Initializes a new instance of the Invoice class.</summary>
        public Invoice() => Loaded += (ev) => previousClientId = ClientId;
        
        /// <summary>Gets or sets the value of Amount on this Invoice instance.</summary>
        public decimal? Amount { get; set; }
        
        /// <summary>Gets or sets the value of Date on this Invoice instance.</summary>
        [DateOnly]
        public DateTime? Date { get; set; }
        
        /// <summary>Gets or sets the value of Description on this Invoice instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(2500)]
        public string Description { get; set; }
        
        /// <summary>Gets or sets the ID of the associated Client.</summary>
        public Guid? ClientId { get; set; }
        
        /// <summary>Gets or sets the value of Client on this Invoice instance.</summary>
        public Client Client
        {
            get => cachedClient.Get(ClientId);
            set => ClientId = value?.ID;
        }
        
        /// <summary>Returns a textual representation of this Invoice.</summary>
        public override string ToString() => Description.OrEmpty();
        
        /// <summary>Returns a clone of this Invoice.</summary>
        /// <returns>
        /// A new Invoice object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Invoice Clone() => (Invoice)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Invoice and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Amount < -79228162514264337593543950335m)
                result.Add("The value of Amount must be -79228162514264337593543950335 or more.");
            
            if (ClientId == null)
                result.Add("Please provide a value for Client.");
            
            if (Description?.Length > 2500)
                result.Add("The provided Description is too long. A maximum of 2500 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
        
        public override void InvalidateCachedReferences()
        {
            base.InvalidateCachedReferences();
            
            new [] { ClientId, previousClientId }.ExceptNull().Distinct()
                .Select(id => Database.Cache().Get<Client>(id)).ExceptNull().Do(x => x.cachedInvoices = null);
        }
    }
}