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
    
    /// <summary>Represents an instance of Asset entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Asset : GuidEntity
    {
        CachedReference<Owner> cachedOwner = new CachedReference<Owner>();
        
        CachedReference<AssetType> cachedType = new CachedReference<AssetType>();
        
        /// <summary>Gets or sets the value of Code on this Asset instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Code { get; set; }
        
        /// <summary>Gets or sets the value of Cost on this Asset instance.</summary>
        public decimal? Cost { get; set; }
        
        /// <summary>Gets or sets the value of Name on this Asset instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Name { get; set; }
        
        /// <summary>Gets or sets the ID of the associated Owner.</summary>
        public Guid? OwnerId { get; set; }
        
        /// <summary>Gets or sets the value of Owner on this Asset instance.</summary>
        public Owner Owner
        {
            get => cachedOwner.GetOrDefault(OwnerId);
            set => OwnerId = value?.ID;
        }
        
        /// <summary>Gets or sets the ID of the associated Type.</summary>
        public Guid? TypeId { get; set; }
        
        /// <summary>Gets or sets the value of Type on this Asset instance.</summary>
        public AssetType Type
        {
            get => cachedType.GetOrDefault(TypeId);
            set => TypeId = value?.ID;
        }
        
        /// <summary>Returns a textual representation of this Asset.</summary>
        public override string ToString() => Name.OrEmpty();
        
        /// <summary>Returns a clone of this Asset.</summary>
        /// <returns>
        /// A new Asset object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Asset Clone() => (Asset)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Asset and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Code?.Length > 200)
                result.Add("The provided Code is too long. A maximum of 200 characters is acceptable.");
            
            if (Cost < 0m)
                result.Add("The value of Cost must be 0 or more.");
            
            if (Name?.Length > 200)
                result.Add("The provided Name is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
    }
}