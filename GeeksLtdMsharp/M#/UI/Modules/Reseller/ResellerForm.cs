using MSharp;

namespace Modules
{
    public class ResellerForm : FormModule<Domain.Reseller>
    {
        public ResellerForm()
        {
            HeaderText("Reseller details");

            Field(x => x.Name);

            Field(x => x.Country).Control(ControlType.AutoComplete)
                .DataSource("await Database.GetList<Country>().Where(x => x.IsEuropean)");

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