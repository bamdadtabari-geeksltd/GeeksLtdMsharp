using MSharp;

namespace Modules
{
    public class CityForm : FormModule<Domain.City>
    {
        public CityForm()
        {
            HeaderText("City details");

            Field(x => x.Name);

            AutoSet(x => x.Country);

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