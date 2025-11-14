using MSharp;

namespace Modules
{
    public class Country2Form : FormModule<Domain.Country2>
    {
        public Country2Form()
        {
            HeaderText("Country details");

            Field(x => x.Name);

            Field(x => x.Code);

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