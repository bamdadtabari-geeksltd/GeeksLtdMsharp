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
    
    /// <summary>Represents an instance of Asset Type entity type.</summary>
    [System.ComponentModel.DisplayName("Asset Type")]
    [EscapeGCop("Auto generated code.")]
    public partial class AssetType : GuidEntity
    {
        /// <summary>Initializes a new instance of the AssetType class.</summary>
        public AssetType() => Deleting += (ev) => ev.Do(Cascade_Deleting);
        
        /// <summary>Gets or sets the value of Name on this Asset Type instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Name { get; set; }
        
        /// <summary>Returns a textual representation of this Asset Type.</summary>
        public override string ToString() => Name;
        
        /// <summary>Returns a clone of this Asset Type.</summary>
        /// <returns>
        /// A new Asset Type object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new AssetType Clone() => (AssetType)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Asset Type and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Name.IsEmpty())
                result.Add("Name cannot be empty.");
            
            if (Name?.Length > 200)
                result.Add("The provided Name is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Throws a validation exception if any record depends on this Asset Type which cannot be cascade-deleted.<para/>
        /// </summary>
        public virtual async Task ValidateCanBeDeleted()
        {
            var dependantAssets = await Database.Count<Asset>(a => a.TypeId == ID);
            
            if (dependantAssets > 0)
            {
                throw new ValidationException("This Asset Type cannot be deleted because of {0} dependent Asset record(s).", dependantAssets);
            }
        }
        
        /// <summary>Handles the Deleting event of this Asset Type.</summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The CancelEventArgs instance containing the event data.</param>
        async Task Cascade_Deleting()
        {
            await ValidateCanBeDeleted();
        }
    }
}