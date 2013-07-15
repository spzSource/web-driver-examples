using OpenQA.Selenium;
using RealtAutomation.Framework;
using RealtAutomation.WebElements;
using RealtAutomation.Framework.Exceptions;
using NUnit.Framework;

namespace RealtAutomation.WebPages
{
	class FilterFlatsPage : BasePage
	{
		private Link chooseFlatsLink = new Link(By.XPath(".//*[@class='search']/a"));
 
		public FilterFlatsPage()
		{
			Assert.True(chooseFlatsLink.isPresent());
		}

		public FlatPage FlatsLinkClick()
		{
			chooseFlatsLink.Click();
			return new FlatPage();
		}
	}
}
