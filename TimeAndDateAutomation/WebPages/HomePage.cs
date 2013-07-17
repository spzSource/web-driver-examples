﻿using ATFramework.Framework;
using ATFramework.WebElements;
using ATFramework.WebElements.Utils;
using NUnit.Framework;

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
	}
}
