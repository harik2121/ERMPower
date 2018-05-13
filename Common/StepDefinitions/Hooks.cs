using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System.IO;
using System;
using System.Text;
using TechTalk.SpecFlow.Tracing;
using OpenQA.Selenium;

namespace CrossBrowserTests

{
    [Binding]
    public class Hooks :  Steps.BaseStepDefinitions
        
    {

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            var artifactDirectory = ArtifactDirectory;
            if (Directory.Exists(artifactDirectory))
            {
                Directory.Delete(artifactDirectory, true);
            }

            Directory.CreateDirectory(artifactDirectory);

        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            var profile = new ChromeOptions();
            profile.AddArgument("-start-maximized");
            Driver = new ChromeDriver(profile);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                TakeScreenshot();
            }

            if (Driver != null)
            {
                Driver.Dispose();
                Driver = null;
            }
        }

        private static string ArtifactDirectory
        {
            get
            {
                var artifactDirectory = Path.Combine(Directory.GetCurrentDirectory(), "testresults");
                return artifactDirectory;
            }
        }

        private static void TakeScreenshot()
        {

            try
            {
                var fileNameBase = string.Format("error_{0}_{1}_{2}",
                    FeatureContext.Current.FeatureInfo.Title.ToIdentifier(),
                    ScenarioContext.Current.ScenarioInfo.Title.ToIdentifier(),
                    DateTime.Now.ToString("yyyyMMdd_HHmmss"));

                var artifactDirectory = ArtifactDirectory;

                var pageSource = Driver.PageSource;
                var sourceFilePath = Path.Combine(artifactDirectory, fileNameBase + "_source.html");
                File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);
                Console.WriteLine("Page source: {0}", new Uri(sourceFilePath));


                //  var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                // var screenshotFilePath = Path.Combine(artifactDirectory, fileNameBase + "_screenshot.png");
                //  screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);

                // ITakesScreenshot screenshotDriver = Driver as ITakesScreenshot;
                // Screenshot screenshot = screenshotDriver.GetScreenshot();
                var screenshot = Driver.GetScreenshot();
                var screenshotFilePath = Path.Combine(artifactDirectory, fileNameBase + "_screenshot.png");
                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);

                Console.WriteLine("Screenshot: {0}", new Uri(screenshotFilePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }
        }


    }
}
