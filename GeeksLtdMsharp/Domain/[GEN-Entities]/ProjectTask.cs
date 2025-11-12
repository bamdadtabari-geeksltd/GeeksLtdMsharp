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
    
    /// <summary>Represents an instance of Project Task entity type.</summary>
    [System.ComponentModel.DisplayName("Project Task")]
    [EscapeGCop("Auto generated code.")]
    public partial class ProjectTask : GuidEntity
    {
        CachedReference<Project> cachedProject = new CachedReference<Project>();
        
        /// <summary>Initializes a new instance of the ProjectTask class.</summary>
        public ProjectTask() => this.Done = false;
        
        /// <summary>Gets or sets the value of Description on this Project Task instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string Description { get; set; }
        
        /// <summary>Gets or sets a value indicating whether this Project Task instance is Done.</summary>
        public bool Done { get; set; }
        
        /// <summary>Gets or sets the value of Title on this Project Task instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Title { get; set; }
        
        /// <summary>Gets or sets the ID of the associated Project.</summary>
        public Guid? ProjectId { get; set; }
        
        /// <summary>Gets or sets the value of Project on this Project Task instance.</summary>
        public Project Project
        {
            get => cachedProject.GetOrDefault(ProjectId);
            set => ProjectId = value?.ID;
        }
        
        /// <summary>
        /// Find and returns an instance of Project Task from the database by its Project and Title.<para/>
        /// If no matching Project Task is found, it returns Null.<para/>
        /// </summary>
        /// <param name="project">The Project of the requested Project Task.</param>
        /// <param name="title">The Title of the requested Project Task.</param>
        /// <returns>The matching Project Task instance or otherwise null.</returns>
        public static Task<ProjectTask> FindByProjectAndTitle(Domain.Project project, string title)
        {
            return Database.FirstOrDefault<ProjectTask>(p => p.ProjectId == project && p.Title == title);
        }
        
        /// <summary>Returns a textual representation of this Project Task.</summary>
        public override string ToString() => Title.OrEmpty();
        
        /// <summary>Returns a clone of this Project Task.</summary>
        /// <returns>
        /// A new Project Task object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new ProjectTask Clone() => (ProjectTask)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Project Task and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override async Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Description?.Length > 500)
                result.Add("The provided Description is too long. A maximum of 500 characters is acceptable.");
            
            if (Title?.Length > 200)
                result.Add("The provided Title is too long. A maximum of 200 characters is acceptable.");
            
            // Ensure uniqueness of Project and Title
            
            if (ProjectId != null && Title.HasValue())
            {
                // Find an existing ProjectTask with the same Project and Title
                
                if (await Database.Any<ProjectTask>(p => p != this && p.ProjectId == ProjectId && p.Title == Title))
                {
                    throw new ValidationException("There is an existing Project Task with the same Project and Title in the database already.");
                }
            }
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
        }
    }
}