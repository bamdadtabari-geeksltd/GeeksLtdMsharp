using MSharp;

namespace Modules
{
    public class CandidateForm : FormModule<Domain.Candidate>
    {
        public CandidateForm()
        {
            HeaderText("Candidate details");

            Field(x => x.FirstName);

            Field(x => x.LastName);

            Field(x => x.Email);

            Field(x => x.Telephone);

            Field(x => x.ConveringLetter);

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