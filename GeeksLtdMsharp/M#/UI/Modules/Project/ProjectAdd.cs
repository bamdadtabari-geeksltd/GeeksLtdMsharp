using MSharp;

namespace Modules
{
    public class ProjectAdd : FormModule<Domain.Project>
    {
        public ProjectAdd()
        {
            HeaderText("Project Details");

            Field(x => x.Name);

            Button("Cancel").OnClick(x => x.CloseModal());

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.CloseModal(Refresh.Full);
                });
        }
    }
}