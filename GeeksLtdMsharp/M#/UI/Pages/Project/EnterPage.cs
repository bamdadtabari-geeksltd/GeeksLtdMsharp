using Modules;
using MSharp;

namespace Project
{
    public class EnterPage : SubPage<ProjectPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<ProjectAdd>();
        }
    }
}