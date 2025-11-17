//using Olive;
//using Pangolin;

//namespace AppTests
//{
//    [TestClass]
//    public class Add_Promotion : UITest
//    {
//        [PangolinTestMethod]
//        public override void RunTest()
//        {
//            LoginAs<LogInOnHubAsEducationDirector>();

//            Goto("http://localhost:9011/core/settings/academic-modules/promotion/" + "Module 1".AsGuidRef());

//            var form = Module<Curriculum.Modules.PromotionForm>();
//            WaitToSeeXPath(form.SaveButton);

//            form.Photo.Set("Uploadable.Files\\File.pdf");
//            form.Tagline.Set("Tagline");
//            form.ISBN.Set("ISBN");
//            form.VideoUrl.Set("VideoUrl");
//            form.Introduction.SetHtml("Int<p>rodu</p>ction");
//            form.Description.SetHtml("<strong>Description</strong>");

//            form.Photo.WaitToUpload();

//            form.SaveButton.Click();

//            //RefreshPage();
//        }
//    }
//}