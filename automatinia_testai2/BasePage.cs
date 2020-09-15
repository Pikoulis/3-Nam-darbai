using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automatinia_testai2
{
    class BasePage
    {
        public static IWebDriver _driver;
        
        static BasePage () 
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            _driver = new ChromeDriver(options);
        }
       
    }
}
