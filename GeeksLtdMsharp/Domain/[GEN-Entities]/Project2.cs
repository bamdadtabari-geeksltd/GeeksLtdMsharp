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
    
    /// <summary>Represents an instance of Project2 entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Project2 : GuidEntity
    {
        internal List<TimeLog> cachedTimeLogs;
        
        /// <summary>Initializes a new instance of the Project2 class.</summary>
        public Project2() => Deleting += (ev) => ev.Do(Cascade_Deleting);
        
        /// <summary>Gets or sets the value of Name on this Project2 instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Name { get; set; }
        
        /// <summary>Gets the TotalWorkHours property.</summary>
        [Calculated]
        public decimal TotalWorkHours
        {
            get => TimeLogs.GetList().Sum(x => x.Hours).GetAwaiter().GetResult();
        }
        
        /// <summary>Gets the TimeLogs of this Project2.</summary>
        [Calculated]
        [XmlIgnore, Newtonsoft.Json.JsonIgnore]
        [System.ComponentModel.DisplayName("TimeLogs")]
        [InverseOf("Project2")]
        public IDatabaseQuery<TimeLog> TimeLogs
        {
            get => Database.Of<TimeLog>().Where(t => t.Project2Id == ID);
        }
        
        /// <summary>Returns a textual representation of this Project2.</summary>
        public override string ToString() => Name.OrEmpty();
        
        /// <summary>Returns a clone of this Project2.</summary>
        /// <returns>
        /// A new Project2 object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Project2 Clone() => (Project2)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Project2 and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Name?.Length > 200)
                result.Add("The provided Name is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Throws a validation exception if any record depends on this Project2 which cannot be cascade-deleted.<para/>
        /// </summary>
        public virtual async Task ValidateCanBeDeleted()
        {
            if (await TimeLogs.Any())
            {
                throw new ValidationException("This Project2 cannot be deleted because of {0} dependent TimeLogs.",
                await TimeLogs.Count());
            }
        }
        
        /// <summary>Handles the Deleting event of this Project2.</summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The CancelEventArgs instance containing the event data.</param>
        async Task Cascade_Deleting()
        {
            await ValidateCanBeDeleted();
        }
    }
}