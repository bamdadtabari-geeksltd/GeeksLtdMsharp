using MSharp;

namespace Modules
{
    public class TimeLogForm : FormModule<Domain.TimeLog>
    {
        public TimeLogForm()
        {
            HeaderText("Time log details");

            Field(x => x.Project2).Control(ControlType.DropdownList);

            Field(x => x.Developer).Control(ControlType.DropdownList);

            Field(x => x.Date).Control(ControlType.DatePicker);

            Field(x => x.StartTime);

            Field(x => x.EndTime);

            Field(x => x.Details);

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