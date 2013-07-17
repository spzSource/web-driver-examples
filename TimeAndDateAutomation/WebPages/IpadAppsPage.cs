using ATFramework.Framework;
using ATFramework.WebElements;
using ATFramework.WebElements.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TimeAndDateAutomation.WebPages
{
	class IpadAppsPage : BasePage
	{
		[Bind(How = How.Id, Name = "NavigationChain")]
		private Label navigationChain;

		public IpadAppsPage()
		{
			PageFactory.InitElements(this);
			Assert.True(navigationChain.isPresent());
		}
	}
}
