using Modules;
using MSharp;

namespace Project
{
    public class EditPage : SubPage<ProjectPage>
    {
        public EditPage()
        {
            Layout(Layouts.AdminDefault);

            Add<ProjectEdit>();
        }
    }
}