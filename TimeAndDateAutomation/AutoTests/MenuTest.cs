using ATFramework.Framework;
using NUnit.Framework;
using TimeAndDateAutomation.WebPages;

namespace TimeAndDateAutomation.AutoTests
{
	class MenuTest : BaseTest
	{
		[Test]
		[TestCaseSource("GetData")]
		public void TestMainMenuItem(string menuChain)
		{
			HomePage homePage = new HomePage();
			IpadAppsPage page = homePage.LoadPage<IpadAppsPage>(menuChain);
		}

		private string[] GetData()
		{
			return new string[] 
			{
				"Apps & API > iPad Apps"
			};
		}
	}
}
