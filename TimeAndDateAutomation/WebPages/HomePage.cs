using ATFramework.Framework;
using ATFramework.WebElements;
using ATFramework.WebElements.Utils;
using NUnit.Framework;

namespace TimeAndDateAutomation.WebPages
{
	class HomePage : BasePage
	{
		[Bind(How = How.LinkText, Name = "AppsAndApiLink")] 
		private Link linkAppsAndApi;

		public HomePage()
		{
			PageFactory.InitElements(this);
			Assert.True(linkAppsAndApi.isPresent());
		}
	}
}
