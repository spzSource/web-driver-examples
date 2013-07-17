using System.Collections.Generic;
using ATFramework.Framework;
using NUnit.Framework;
using TimeAndDateAutomation.WebPages;

namespace TimeAndDateAutomation.AutoTests
{
	class MenuTest : BaseTest
	{
		[Test]
		[TestCaseSource("GetData")]
		public void TestMainMenuItem(string menuChain, string navString)
		{
			HomePage homePage = new HomePage();
			homePage.ClickToMenuItem(menuChain, navString);
		}

		private IEnumerable<string[]> GetData()
		{
			return new[]
			{
				new string[] { "Apps & API > iPad Apps", "Home > Apps > iPad Apps" },
				new string[] { "Apps & API > iPad Apps", "Home > Apps > iPad Apps" },
				new string[] { "Apps & API > iPad Apps", "Home > Apps > iPad Apps" },
				new string[] { "Apps & API > iPad Apps", "Home > Apps > iPad Apps" }
			};
		}
	}
}
