using Pangolin;

namespace AppTests
{
    public class LogInOnHub(params string[] roles) : UITest
    {
        public override void RunTest()
        {
            Logout();
            Goto(Session.HubBaseUrl);
            if (roles.Any())
                Set("RoleNames").To(string.Join(",", roles));
            ClickButton("Simulate Log In");
        }
    }

    public class LogInOnHubAsEducationDirector() : LogInOnHub("EducationDirector");
}