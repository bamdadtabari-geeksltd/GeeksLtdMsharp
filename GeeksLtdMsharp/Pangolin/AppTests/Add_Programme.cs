//using Pangolin;

//namespace AppTests
//{
//    [TestClass]
//    public class Add_Programme : UITest
//    {
//        [PangolinTestMethod]
//        public override void RunTest()
//        {
//            LoginAs<LogInOnHubAsEducationDirector>();

//            Goto("http://localhost:9011/core/settings/programmes");

//            var list = Module<Curriculum.ProgrammesList>();
//            var form = Module<Curriculum.Programmes.EnterForm>();
//            var view = Module<Modules.Programme.ProgrammeOverviewView>();
//            list.AddButton.Click();
//            form.Name.Set("Project Management");
//            form.DisplayName.Set("Project Management");
//            form.Status.Choose("Approved");
//            form.Prerequisite_Text.Set("Programme 1");
//            form.OnlineFee.Set("9800");
//            form.BlendedFee.Set("11800");
//            form.Credits.Set("1800");
//            form.HECoSCode_Text.Set("ceramics (100003)");
//            form.Level.Choose("FHEQ - L7");
//            //form.SubjectBenchmark.Set("10000");
//            form.Director_Text.Set("Jack Smith Senior");
//            form.DateApproved.Set("02/09/2025");
//            form.SaveButton.Click();

//            // Setting files:
//            // Set("Choose file").To("File.pdf");

//            list.Row("Project Management").Expect();

//            RefreshPage();
//            // Edit
//            list.Row("Project Management").NameButton.Click();
//            view.EditButton.Click();
//            form.Name.Set("Digital Project Management");
//            form.SaveButton.Click();

//            Goto("http://localhost:9011/core/settings/programmes");
//            list.Row("Digital Project Management").Expect();

//            //Goto("http://localhost:9011/admissions/applicant/evidences?Applicant=1ab6896b-068d-4141-85a9-6f59f34c7a72");
//            //ExpectHeader("Evidence");






















//            //WebDriver.ExecuteJavaScript("$(\"#EvidenceDocument_fileInput\").css( \"display\", \"block\" );");
//            //WebDriver.ExecuteJavaScript("$(\"#EvidenceDocument_fileInput\").css( \"clip\", \"\" );");
//        }
//    }
//}
