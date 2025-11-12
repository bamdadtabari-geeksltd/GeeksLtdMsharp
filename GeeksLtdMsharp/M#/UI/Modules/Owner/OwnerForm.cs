using MSharp;

namespace Modules
{
    public class OwnerForm : FormModule<Domain.Owner>
    {
        public OwnerForm()
        {
            HeaderText("Owner details");

            Field(x => x.FirstName);
            Field(x => x.LastName);

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