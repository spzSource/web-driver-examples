using ATFramework.Framework;
using ATFramework.WebElements;
using ATFramework.WebElements.Utils;
using NUnit.Framework;
using System.Linq;
using System.Configuration;
using ATFramework.Framework.Common;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TimeAndDateAutomation.WebPages
{
	class HomePage : BasePage
	{
		[Bind(How = How.CssSelector, Name = "AppsAndApiLink")] 
		private Link linkAppsAndApi;

		[Bind(How = How.Id, Name = "NavigationChain")]
		private Link navigationChain;

		public HomePage()
		{
			PageFactory.InitElements(this);
			Assert.True(linkAppsAndApi.isPresent());
		}

		/// <summary>
		/// Menu1 > SubMenu1
		/// </summary>
		public TestablePage ClickToMenuItem(string chainMenu, string navigationLabel)
		{
			List<string> menuItems = CommonFunctions.Split(chainMenu).ToList();
			List<Link> links = new List<Link>();
			menuItems.ForEach(e => links.Add(new Link(By.LinkText(e))));

			Link lastLink = links.Last();
			links.Remove(lastLink);

			Actions action = new Actions(Driver);
			links.ForEach(link => action.MoveToElement(link.WebElement).Perform());
			lastLink.Click();

			return new TestablePage(navigationLabel);
		}
	}
}
