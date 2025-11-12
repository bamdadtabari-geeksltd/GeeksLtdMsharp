using MSharp;

namespace Modules
{
    public class ProjectTaskView : ViewModule<Domain.ProjectTask>
    {
        public ProjectTaskView()
        {
            HeaderText("Tasks");

            Field(x => x.Project);

            Field(x => x.Title);

            Field(x => x.Description);

            Field(x => x.Done).LabelText("Is done?");

            Button("Back").Icon(FA.ChevronLeft)
                .OnClick(x => x.ReturnToPreviousPage());

        }
    }
}