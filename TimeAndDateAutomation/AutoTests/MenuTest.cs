using ATFramework.Framework;
using NUnit.Framework;
using TimeAndDateAutomation.WebPages;

namespace TimeAndDateAutomation.AutoTests
{
	class MenuTest : BaseTest
	{
		[Test]
		[TestCaseSource("")]
		public void TestMainMenuItem(string item)
		{
			HomePage homePage = new HomePage();
			BasePage page = homePage.LoadPage<HomePage>(item);
		}
	}
}
