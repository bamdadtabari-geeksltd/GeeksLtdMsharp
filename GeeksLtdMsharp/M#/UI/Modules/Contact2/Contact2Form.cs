using MSharp;

namespace Modules
{
    public class Contact2Form : FormModule<Domain.Contact2>
    {
        public Contact2Form()
        {
            HeaderText("Contact details");

            Field(x => x.Category);

            Field(x => x.Name);

            Field(x => x.Email);

            Field(x => x.Telephone).AfterControl("Mobile, land line, or office");

            var addressBox = Box("Address", BoxTemplate.HeaderBox);

            Field(x => x.AddressLine1).Box(addressBox);

            Field(x => x.AddressLine2).Box(addressBox);

            Field(x => x.Town).Box(addressBox);

            Field(x => x.Postcode).Box(addressBox);

            var notesBox = Box("Notes", BoxTemplate.HeaderBox);

            Field(x => x.Comments).Box(notesBox);

            Field(x => x.DateOfBirth).Control(ControlType.DatePicker);

            AutoSet(x => x.Category);

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