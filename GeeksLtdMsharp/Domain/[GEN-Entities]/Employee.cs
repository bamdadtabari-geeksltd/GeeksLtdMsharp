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
    
    /// <summary>Represents an instance of Employee entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Employee : GuidEntity
    {
        /// <summary>Stores the binary information for IDCard property.</summary>
        private Blob iDCard;
        
        /// <summary>Gets or sets the value of Email on this Employee instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Email { get; set; }
        
        /// <summary>Gets or sets the value of FirstName on this Employee instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string FirstName { get; set; }
        
        /// <summary>
        /// Gets or sets the value of IDCard on this Employee instance.<para/>
        /// Upon a download, the system will call my method IsIDCardVisibleTo(IPrincipal) which must return bool or Task[bool].<para/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.ComponentModel.DisplayName("ID Card")]
        [SecureFile]
        public Blob IDCard
        {
            get
            {
                if (iDCard is null) iDCard = Blob.Empty().Attach(this, "IDCard");
                return iDCard;
            }
            
            set
            {
                if (!(iDCard is null))
                {
                    // Detach the previous file, so it doesn't get updated or deleted with this Employee instance.
                    iDCard.Detach();
                }
                
                if (value is null)
                {
                    value = Blob.Empty();
                }
                
                iDCard = value.Attach(this, "IDCard");
            }
        }
        
        /// <summary>Gets or sets the value of LastName on this Employee instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string LastName { get; set; }
        
        /// <summary>Gets the Warnings property.</summary>
        [Calculated]
        public string Warnings
        {
            get => GetWarnings();
        }
        
        /// <summary>Returns a textual representation of this Employee.</summary>
        public override string ToString() => FirstName.OrEmpty();
        
        /// <summary>Returns a clone of this Employee.</summary>
        /// <returns>
        /// A new Employee object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Employee Clone()
        {
            var result = (Employee) base.Clone();
            
            result.IDCard = IDCard.Clone();
            return result;
        }
        
        /// <summary>
        /// Validates the data for the properties of this Employee and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Email?.Length > 200)
                result.Add("The provided Email is too long. A maximum of 200 characters is acceptable.");
            
            // Ensure Email matches Email address pattern:
            
            if (Email.HasValue() && !System.Text.RegularExpressions.Regex.IsMatch(Email, "\\s*\\w+([-+.'\\w])*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*\\s*"))
                result.Add("The provided Email is not a valid Email address.");
            
            if (FirstName?.Length > 200)
                result.Add("The provided First name is too long. A maximum of 200 characters is acceptable.");
            
            // Ensure the file uploaded for ID Card is safe:
            
            if (IDCard.HasValue() && IDCard.HasUnsafeExtension())result.Add("The file uploaded for ID Card is unsafe because of the file extension: {0}".FormatWith(IDCard.FileExtension));
            
            if (LastName?.Length > 200)
                result.Add("The provided Last name is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
    }
}