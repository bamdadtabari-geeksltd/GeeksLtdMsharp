using MSharp;

namespace Player
{
    public class ViewPage : SubPage<TennisPlayerPage>
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.FansList>();
        }
    }
}