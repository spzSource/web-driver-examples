using System;
using OpenQA.Selenium;
using RealtAutomation.Framework;
using RealtAutomation.Framework.Common;
using RealtAutomation.Framework.Exceptions;
using RealtAutomation.WebElements;

namespace RealtAutomation.WebPages
{
    class FlatsResultPage : BasePage
    {
		private Label flatsInfo = new Label(By.XPath(".//*[@id='uedb-page-browser'][last()]/p"));
		private Link chooseFlatsLink = new Link(By.XPath(".//*[@class='search']/a"));

        public FlatsResultPage()
        {
			if (!flatsInfo.IsDisplayed())
				throw new PageNotFoundException("Page: " + GetType().Name + " not found");
        }

        public int GetFlatsCount()
        {
            int flatsCount = 0;
			string regexResult = CommonFunctions.DoRegexSingle(@"\s+(\d+)\s+", flatsInfo.Text, groupNumber: 1);
			flatsCount = string.IsNullOrEmpty(regexResult) ? 0 : Int32.Parse(regexResult);
            
            return flatsCount;
        }

		public FlatPage GoToFlatsPage()
		{
			chooseFlatsLink.Click();
			return new FlatPage();
		}
    }
}
