using MSharp;
using Domain;

namespace Login
{
    public class DispatchPage : SubPage<LoginPage>
    {
        public DispatchPage()
        {
            OnStart(x =>
            {
                x.If(AppRole.Admin).Go<AdminPage>().RunServerSide();
                x.Else().Go<_401Page>();
                x.GentleMessage("get out !!!!");
            });
        }
    }
}