using MSharp;

namespace Modules
{
    public class FansList : ListModule<Domain.Fan>
    {
        public FansList()
        {
            HeaderText("Registered @info.Player.Name Fans");

            Search(x => x.IsRegistrationCompleted)
                .Label("Include incomplete registrations.")
                .Control(ControlType.CheckBox)
                .MemoryFilterCode("if(!info.IsRegistrationCompleted){ result = result.Where(x=>x.IsRegistrationCompleted == true);}");

            SearchButton("Search").OnClick(x => x.Reload());

            Column(x => x.StartDate).LabelText("Fan start date");

            Column(x => x.Name);

            Column(x => x.Email);

            Column(x => x.DateOfBirth);

            Column(x => x.SupportComments).LabelText("Support notes");

            ViewModelProperty("Player", "Player").FromRequestParam("item");

            DataSource("await info.Player.Fans.GetList()");
        }
    }
}