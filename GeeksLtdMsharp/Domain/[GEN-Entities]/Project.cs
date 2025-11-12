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
    
    /// <summary>Represents an instance of Project entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Project : GuidEntity
    {
        /// <summary>Initializes a new instance of the Project class.</summary>
        public Project() => Deleting += (ev) => ev.Do(Cascade_Deleting);
        
        /// <summary>Gets or sets the value of Name on this Project instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Name { get; set; }
        
        /// <summary>
        /// Find and returns an instance of Project from the database by its Name.<para/>
        /// If no matching Project is found, it returns Null.<para/>
        /// </summary>
        /// <param name="name">The Name of the requested Project.</param>
        /// <returns>The matching Project instance or otherwise null.</returns>
        public static Task<Project> FindByName(string name)
        {
            return Database.FirstOrDefault<Project>(p => p.Name == name);
        }
        
        /// <summary>Returns a textual representation of this Project.</summary>
        public override string ToString() => Name.OrEmpty();
        
        /// <summary>Returns a clone of this Project.</summary>
        /// <returns>
        /// A new Project object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Project Clone() => (Project)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Project and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override async Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Name?.Length > 200)
                result.Add("The provided Name is too long. A maximum of 200 characters is acceptable.");
            
            // Ensure uniqueness of Name
            
            if (Name.HasValue())
            {
                // Find an existing Project with the same Name
                
                if (await Database.Any<Project>(p => p != this && p.Name == Name))
                {
                    throw new ValidationException("There is an existing Project with the same Name in the database already.");
                }
            }
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
        }
        
        /// <summary>Throws a validation exception if any record depends on this Project which cannot be cascade-deleted.</summary>
        public virtual async Task ValidateCanBeDeleted()
        {
            var dependantProjectTasks = await Database.Count<ProjectTask>(p => p.ProjectId == ID);
            
            if (dependantProjectTasks > 0)
            {
                throw new ValidationException("This Project cannot be deleted because of {0} dependent Project Task record(s).", dependantProjectTasks);
            }
        }
        
        /// <summary>Handles the Deleting event of this Project.</summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The CancelEventArgs instance containing the event data.</param>
        async Task Cascade_Deleting()
        {
            await ValidateCanBeDeleted();
        }
    }
}