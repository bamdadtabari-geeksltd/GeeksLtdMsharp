using MSharp;
using MSharp;

namespace Candidate
{
    public class EnterPage : SubPage<CandidatePage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);
            Add<Modules.CandidateForm>();
        }
    }
}