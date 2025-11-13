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
    
    /// <summary>Represents an instance of Client entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Client : GuidEntity
    {
        internal List<Invoice> cachedInvoices;
        
        /// <summary>Initializes a new instance of the Client class.</summary>
        public Client() => Deleting += (ev) => ev.Do(Cascade_Deleting);
        
        /// <summary>Gets or sets the value of Company on this Client instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Company { get; set; }
        
        /// <summary>Gets the Invoices of this Client.</summary>
        [Calculated]
        [XmlIgnore, Newtonsoft.Json.JsonIgnore]
        [InverseOf("Client")]
        public IDatabaseQuery<Invoice> Invoices
        {
            get => Database.Of<Invoice>().Where(i => i.ClientId == ID);
        }
        
        /// <summary>Returns a textual representation of this Client.</summary>
        public override string ToString() => Company;
        
        /// <summary>Returns a clone of this Client.</summary>
        /// <returns>
        /// A new Client object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Client Clone() => (Client)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Client and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Company.IsEmpty())
                result.Add("Company cannot be empty.");
            
            if (Company?.Length > 200)
                result.Add("The provided Company is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
        
        /// <summary>Throws a validation exception if any record depends on this Client which cannot be cascade-deleted.</summary>
        public virtual async Task ValidateCanBeDeleted()
        {
            if (await Invoices.Any())
            {
                throw new ValidationException("This Client cannot be deleted because of {0} dependent Invoices.",
                await Invoices.Count());
            }
        }
        
        /// <summary>Handles the Deleting event of this Client.</summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The CancelEventArgs instance containing the event data.</param>
        async Task Cascade_Deleting()
        {
            await ValidateCanBeDeleted();
        }
    }
}