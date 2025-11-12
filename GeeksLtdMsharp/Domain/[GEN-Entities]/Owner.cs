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
    
    /// <summary>Represents an instance of Owner entity type.</summary>
    [SkipAutoSort]
    [EscapeGCop("Auto generated code.")]
    public partial class Owner : GuidEntity
    {
        /// <summary>Initializes a new instance of the Owner class.</summary>
        public Owner() => Deleting += (ev) => ev.Do(Cascade_Deleting);
        
        /// <summary>Gets or sets the value of FirstName on this Owner instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string FirstName { get; set; }
        
        /// <summary>Gets or sets the value of LastName on this Owner instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string LastName { get; set; }
        
        /// <summary>Returns a textual representation of this Owner.</summary>
        public override string ToString() => FirstName + ' ' + LastName;
        
        /// <summary>Returns a clone of this Owner.</summary>
        /// <returns>
        /// A new Owner object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Owner Clone() => (Owner)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Owner and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (FirstName?.Length > 200)
                result.Add("The provided First name is too long. A maximum of 200 characters is acceptable.");
            
            if (LastName?.Length > 200)
                result.Add("The provided Last name is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
        
        /// <summary>Throws a validation exception if any record depends on this Owner which cannot be cascade-deleted.</summary>
        public virtual async Task ValidateCanBeDeleted()
        {
            var dependantAssets = await Database.Count<Asset>(a => a.OwnerId == ID);
            
            if (dependantAssets > 0)
            {
                throw new ValidationException("This Owner cannot be deleted because of {0} dependent Asset record(s).", dependantAssets);
            }
        }
        
        /// <summary>Handles the Deleting event of this Owner.</summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The CancelEventArgs instance containing the event data.</param>
        async Task Cascade_Deleting()
        {
            await ValidateCanBeDeleted();
        }
    }
}