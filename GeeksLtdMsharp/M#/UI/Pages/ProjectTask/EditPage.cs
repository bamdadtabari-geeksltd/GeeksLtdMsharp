using MSharp;

namespace ProjectTask
{
    public class EditPage : SubPage<ProjectTaskPage>
    {
        public EditPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.ProjectTaskEdit>();
        }
    }
}