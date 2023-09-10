// use case to take a snap

// using selenium and chromedriver as headless browser
// go to https://www.freeimages.com/photo/eiffel-tower-4-1230689
// windown size 800x800
// sleep for 3 seconds
// save screenshot as image.png

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace VSCSeleniumAuto
{
    public class TakeASnapTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
             _driver = new ChromeDriver(@"D:\\Automation\\VSCSeleniumAuto\\Driver\\chromedriver.exe");
        }

        [Test]
        public void Screenshot()
        {
          _driver.Navigate().GoToUrl("https://www.freeimages.com/photo/eiffel-tower-4-1230689");
          _driver.Manage().Window.Maximize();
          Thread.Sleep(3);
          Screenshot ss = ((ITakesScreenshot)_driver).GetScreenshot();
          ss.SaveAsFile("D:\\Automation\\Image.png", ScreenshotImageFormat.Png);
        }

        [TearDown]
        public void Cleanup()
        {
            //_driver.Quit();
        }
      }
}