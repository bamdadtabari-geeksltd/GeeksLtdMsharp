namespace Website
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Olive;
    using Olive.Entities;
    using Olive.Entities.Data;
    using Domain;
    
    /// <summary>Executes the scheduled tasks in independent threads automatically.</summary>
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class TaskManager : BackgroundJobsPlan
    {
        /// <summary>Registers the scheduled activities.</summary>
        public override void Initialize()
        {
            Register(new BackgroundJob("Clean old temp uploads", () => CleanOldTempUploads(), Hangfire.Cron.MinuteInterval(10)));
            Register(new BackgroundJob("Remind admin for pending candidate", () => RemindAdminForPendingCandidate(), Hangfire.Cron.HourInterval(2)));
        }
        
        /// <summary>Clean old temp uploads</summary>
        public static async Task CleanOldTempUploads()
        {
            try
            {
                await new Olive.Mvc.DiskFileRequestService().DeleteTempFiles(olderThan: 1.Hours());
            }
            catch (Exception ex)
            {
                Log.For<TaskManager>().Error(ex);
                throw;
            }
        }
        
        /// <summary>Remind admin for pending candidate</summary>
        public static async Task RemindAdminForPendingCandidate()
        {
            try
            {
                await Candidate.RemindAdminForPendingCandidates();
            }
            catch (Exception ex)
            {
                Log.For<TaskManager>().Error(ex);
                throw;
            }
        }
    }
}