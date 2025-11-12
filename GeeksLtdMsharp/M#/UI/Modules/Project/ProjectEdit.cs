using MSharp;

namespace Modules
{
    public class ProjectEdit : FormModule<Domain.Project>
    {
        public ProjectEdit()
        {
            HeaderText("Project Details");

            Field(x => x.Name);

            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.ReturnToPreviousPage();
                });
        }
    }
}