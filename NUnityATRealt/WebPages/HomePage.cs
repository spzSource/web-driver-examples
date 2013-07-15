using OpenQA.Selenium;
using RealtAutomation.Framework;
using RealtAutomation.WebElements;
using RealtAutomation.Framework.Exceptions;

namespace RealtAutomation.WebPages
{
	class HomePage : BasePage
	{
		private Link flatLink = new Link(By.LinkText("Квартиры, комнаты"));

		public HomePage()
		{
			if (!flatLink.IsDisplayed())
				throw new PageNotFoundException("Page: " + GetType().Name + " not found");
		}

		public FilterFlatsPage DoFlatLinkClick()
		{
			flatLink.Click();
			return new FilterFlatsPage();
		}
	}
}
