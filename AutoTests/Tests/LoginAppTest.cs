//use case for login to a webpage

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace VSCSeleniumAuto;

public class LoginAppTest
{
    private IWebDriver _driver;

    IWebElement Userormailidtxt => _driver.FindElement(By.Name("email"));
    IWebElement Passwordtxt => _driver.FindElement(By.Id("login-password-field"));
    IWebElement Loginbtn => _driver.FindElement(By.Id("log-in-button"));
    
    [SetUp]
    public void Setup()
    {
        _driver = new ChromeDriver("D:\\Automation\\VSCSeleniumAuto\\Driver\\chromedriver.exe");
    }

    [Test]
    public void LoginApp()
    {
        _driver.Navigate().GoToUrl("https://codepen.io/login");
        _driver.Manage().Window.Maximize();
        Login("Demotest","Demopwd");
    }
    public void Login(string User, string Pwd)
    {
            Userormailidtxt.SendKeys(User);
            Passwordtxt.SendKeys(Pwd);
            Loginbtn.Click();
    }

    [TearDown]

    public void Cleanup()
    {
       // _driver.Quit();
    }
}