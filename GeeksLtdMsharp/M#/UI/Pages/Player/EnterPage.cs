using MSharp;

namespace Player
{
    public class EnterPage : SubPage<TennisPlayerPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);
            Add<Modules.PlayerForm>();
        }
    }
}