using ATFramework.Framework;
using ATFramework.WebElements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TimeAndDateAutomation.WebPages
{
	class TestablePage : BasePage
	{
		public TestablePage(string navigationString)
		{
			Label navigationChain = new Label(By.Id("bct"));
			Assert.True(navigationString.Equals(navigationChain.Text));
		}
	}
}
