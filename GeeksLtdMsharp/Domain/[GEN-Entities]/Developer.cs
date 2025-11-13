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
    
    /// <summary>Represents an instance of Developer entity type.</summary>
    [SkipAutoSort]
    [EscapeGCop("Auto generated code.")]
    public partial class Developer : GuidEntity
    {
        internal List<TimeLog> cachedTimeLogs;
        
        /// <summary>Initializes a new instance of the Developer class.</summary>
        public Developer() => Deleting += (ev) => ev.Do(Cascade_Deleting);
        
        /// <summary>Gets or sets the value of FirstName on this Developer instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string FirstName { get; set; }
        
        /// <summary>Gets the FullName property.</summary>
        [Calculated]
        public string FullName
        {
            get => FirstName + ' ' + LastName;
        }
        
        /// <summary>Gets or sets the value of LastName on this Developer instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string LastName { get; set; }
        
        /// <summary>Gets the LatestWork property.</summary>
        [Calculated]
        public string LatestWork
        {
            get => TimeLogs.Max(x => x.Date).Get(x => x?.ToShortDateString()).GetAwaiter().GetResult();
        }
        
        /// <summary>Gets the TotalWork property.</summary>
        [Calculated]
        public decimal TotalWork
        {
            get => TimeLogs.GetList().Sum(c => c.Hours).GetAwaiter().GetResult();
        }
        
        /// <summary>Gets the Time logs of this Developer.</summary>
        [Calculated]
        [XmlIgnore, Newtonsoft.Json.JsonIgnore]
        [InverseOf("Developer")]
        public IDatabaseQuery<TimeLog> TimeLogs
        {
            get => Database.Of<TimeLog>().Where(t => t.DeveloperId == ID);
        }
        
        /// <summary>Returns a textual representation of this Developer.</summary>
        public override string ToString() => FullName;
        
        /// <summary>Returns a clone of this Developer.</summary>
        /// <returns>
        /// A new Developer object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Developer Clone() => (Developer)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Developer and throws a ValidationException if an error is detected.<para/>
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
        
        /// <summary>Handles the Deleting event of this Developer.</summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The CancelEventArgs instance containing the event data.</param>
        async Task Cascade_Deleting()
        {
            // Cascade delete the dependant Time logs:
            await Database.DeleteAll<TimeLog>(t => t.DeveloperId == ID);
        }
    }
}