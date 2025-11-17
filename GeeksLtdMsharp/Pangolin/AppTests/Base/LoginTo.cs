using Modules.User;
using Pangolin;

namespace AppTests.Base
{
    public class LoginTo(LoginToEnum loginToEnum = LoginToEnum.Localhost,string email = Config.Email, string password = Config.Password) : UITest
    {
        public override void RunTest()
        {
            Logout();
            switch (loginToEnum)
            {
                case LoginToEnum.Localhost:
                    try
                    {
                        Goto(Session.AppBaseUrl + "/login");
                        LoginActionChain();

                    }
                    catch (Exception e)
                    {
                        Goto(Config.Localhost);
                        LoginActionChain();
                    }

                    break;
                case LoginToEnum.Hosted:
                    Goto("" + "/login");
                    LoginActionChain();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(loginToEnum), loginToEnum, null);
            }
        }

        public void LoginActionChain()
        {
            //LoginAs<>();

            var loginForm = Module<LoginForm>();
            loginForm.Header.Expect();
            loginForm.Email.Set(email);
            loginForm.Password.Set(password);
            loginForm.LoginButton.Click();
        }
    }
}
