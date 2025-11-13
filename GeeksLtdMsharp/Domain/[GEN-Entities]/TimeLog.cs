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
    
    /// <summary>Represents an instance of Time log entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class TimeLog : GuidEntity
    {
        CachedReference<Developer> cachedDeveloper = new CachedReference<Developer>();
        Guid? previousDeveloperId;
        
        CachedReference<Project2> cachedProject2 = new CachedReference<Project2>();
        Guid? previousProject2Id;
        
        /// <summary>Initializes a new instance of the TimeLog class.</summary>
        public TimeLog() => Loaded += (ev) => { previousDeveloperId = DeveloperId; previousProject2Id = Project2Id; };
        
        /// <summary>Gets or sets the value of Date on this Time log instance.</summary>
        [DateOnly]
        public DateTime Date { get; set; }
        
        /// <summary>Gets or sets the value of Details on this Time log instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Details { get; set; }
        
        /// <summary>Gets or sets the value of EndTime on this Time log instance.</summary>
        public TimeSpan EndTime { get; set; }
        
        /// <summary>Gets the Hours property.</summary>
        [Calculated]
        public decimal Hours
        {
            get => (decimal)EndTime.Subtract(StartTime).TotalHours.Round(2);
        }
        
        /// <summary>Gets or sets the value of StartTime on this Time log instance.</summary>
        public TimeSpan StartTime { get; set; }
        
        /// <summary>Gets or sets the ID of the associated Developer.</summary>
        public Guid? DeveloperId { get; set; }
        
        /// <summary>Gets or sets the value of Developer on this Time log instance.</summary>
        public Developer Developer
        {
            get => cachedDeveloper.Get(DeveloperId);
            set => DeveloperId = value?.ID;
        }
        
        /// <summary>Gets or sets the ID of the associated Project2.</summary>
        public Guid? Project2Id { get; set; }
        
        /// <summary>Gets or sets the value of Project2 on this Time log instance.</summary>
        public Project2 Project2
        {
            get => cachedProject2.Get(Project2Id);
            set => Project2Id = value?.ID;
        }
        
        /// <summary>Returns a textual representation of this Time log.</summary>
        public override string ToString() => $"Time log ({ID})";
        
        /// <summary>Returns a clone of this Time log.</summary>
        /// <returns>
        /// A new Time log object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new TimeLog Clone() => (TimeLog)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Time log and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Details?.Length > 200)
                result.Add("The provided Details is too long. A maximum of 200 characters is acceptable.");
            
            if (DeveloperId == null)
                result.Add("Please provide a value for Developer.");
            
            if (EndTime >= 24.Hours())
                
            result.Add("The provided End time should be smaller than 24 hours.");
            
            if (Project2Id == null)
                result.Add("Please provide a value for Project2.");
            
            if (StartTime >= 24.Hours())
                
            result.Add("The provided Start time should be smaller than 24 hours.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
        
        public override void InvalidateCachedReferences()
        {
            base.InvalidateCachedReferences();
            
            new [] { DeveloperId, previousDeveloperId }.ExceptNull().Distinct()
                .Select(id => Database.Cache().Get<Developer>(id)).ExceptNull().Do(x => x.cachedTimeLogs = null);
            
            new [] { Project2Id, previousProject2Id }.ExceptNull().Distinct()
                .Select(id => Database.Cache().Get<Project2>(id)).ExceptNull().Do(x => x.cachedTimeLogs = null);
        }
    }
}