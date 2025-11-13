using MSharp;

namespace TimeLog
{
    class EnterPage : SubPage<TimeLogPage>
    {
        public EnterPage()
        {
            Add<Modules.TimeLogForm>();
        }
    }
}