using MSharp;

namespace Modules
{
    public class CountryForm : FormModule<Domain.Country>
    {
        public CountryForm()
        {
            HeaderText("Country details");

            Field(x => x.Name);

            Field(x => x.IsEuropean).Control(ControlType.HorizontalRadioButtons);

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