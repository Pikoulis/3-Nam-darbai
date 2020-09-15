using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace automatinia_testai2.Page
{
    class SeleniumEasyPage : BasePage
    {
        private IWebElement CheckboxDemoButtonText => _driver.FindElement(By.Id("txtAge"));
        private IWebElement ClickOnThisCheckBox => _driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement MultipleCheckboxDemoButton => _driver.FindElement(By.Id("check1"));
        private IList<IWebElement> MultipleCheckbox => _driver.FindElements(By.ClassName("cb1-element"));

        public string ClickOnThisCheckBoxCheck()
        {
            ClickOnThisCheckBox.Click();
            return CheckboxDemoButtonText.Text;
        }

        public string MultipleCheckboxCheck()
        {

            for (int i = 0; i < MultipleCheckbox.Count; i++)
            {
                MultipleCheckbox[i].Click();
            }

            return MultipleCheckboxDemoButton.GetAttribute("value");
        }

        public bool PressUnchek()
        {
            bool result = false;
            MultipleCheckboxDemoButton.Click();
            for (int i = 0; i < MultipleCheckbox.Count; i++)
            {
                result = MultipleCheckbox[i].Selected;
                switch(result)
                {
                    case true:
                        return result = false;
                    default:
                        result = true;
                        break;
                }
            }
            return result;
        }
    }
}/*

2) Pažymime visas “Multiple Checkbox Demo” sekcijos varneles, patikriname kad mygtukas persivadino į “Uncheck All”.
3) Paspaudžiame mygtuką “Uncheck All” , patikriname kad visos “Multiple Checkbox Demo” sekcijos varneles atžymėtos.

*/