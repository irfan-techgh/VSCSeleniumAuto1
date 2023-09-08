//use case to search for a product

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace VSCSeleniumAuto
{ 
    public class SearchProductTest
    {
        private IWebDriver _driver;

        IWebElement _searchtextbox => _driver.FindElement(By.Id("twotabsearchtextbox"));
        IWebElement _searchbtn => _driver.FindElement(By.Id("nav-search-submit-button"));
       
        [SetUp]

        public void InitScript()
        {
             _driver = new ChromeDriver(@"D:\\Automation\\VSCSeleniumAuto\\Driver\\chromedriver.exe");
        }

        // write test to search for a product

        [Test]
        public void SearchBook()
        {
            _driver.Navigate().GoToUrl("https://www.amazon.in/");
            _driver.Manage().Window.Maximize();
            search("Mission Moon");
            Assert.True(_driver.Title.Contains("Mission Moon"));
        }

        public void search(string searchtext)   
        {
            _searchtextbox.SendKeys(searchtext);
            _searchbtn.Click();
        }
        
        [TearDown]
        public void Cleanup()
        {
           // _driver.Quit();
        }
    }
}