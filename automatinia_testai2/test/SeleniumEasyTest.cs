using automatinia_testai2.Page;
using NUnit.Framework;

namespace automatinia_testai2.test
{
    class SeleniumEasyTest:BasePage
    {
        SeleniumEasyPage sep = new SeleniumEasyPage();
        private string result;
        [SetUp]
        public void OpenBrowser()
        {
            _driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-checkbox-demo.html");
        }
        [TearDown]
        public void CloseBrowser()
        {
            _driver.Quit();
        }

        [Test]
        public void ClickOnThisCheckBoxTest() 
        {
            result  = sep.ClickOnThisCheckBoxCheck();
            Assert.AreEqual("Success - Check box is checked", result);
        }
        [Test]
        public void UncheckAllTest() 
        {
            result = sep.MultipleCheckboxCheck();
            Assert.AreEqual("Uncheck All", result);
        }
        [Test]
        public void UncheckAllButton() 
        {
            sep.MultipleCheckboxCheck();
            bool result = sep.PressUnchek();
            Assert.AreEqual(true, result);
        }

    }
}
