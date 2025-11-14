using MSharp;

namespace Modules
{
    public class CompanyForm : FormModule<Domain.Company>
    {
        public CompanyForm()
        {
            HeaderText("Company details");

            Field(x => x.Name);

            Field(x => x.RegistrationDate).Control(ControlType.DatePicker);

            Field(x => x.MarketShare);

            Field(x => x.NumberOfEmployees);

            Field(x => x.Country2).DisplayExpression("item.Code + \" (\" + item.Name + \")\"");

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