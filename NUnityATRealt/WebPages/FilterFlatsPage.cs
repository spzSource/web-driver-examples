using OpenQA.Selenium;
using RealtAutomation.Framework;
using RealtAutomation.WebElements;
using RealtAutomation.Framework.Exceptions;

namespace RealtAutomation.WebPages
{
	class FilterFlatsPage : BasePage
	{
		private Link chooseFlatsLink = new Link(By.XPath(".//*[@class='search']/a"));
 
		public FilterFlatsPage()
		{
			if (!chooseFlatsLink.IsDisplayed())
				throw new PageNotFoundException("Page: " + GetType().Name + " not found");
		}

		public FlatPage FlatsLinkClick()
		{
			chooseFlatsLink.Click();
			return new FlatPage();
		}
	}
}
