using OpenQA.Selenium;
using RealtAutomation.Framework;
using RealtAutomation.Framework.Exceptions;
using RealtAutomation.WebElements;

namespace RealtAutomation.WebPages
{
    class FlatPage : BasePage
    {
		private ComboBox locationInput = new ComboBox(By.XPath(".//*[@id='selection']//td[contains(.,'Населенный пункт:')]//select"));
		private ComboBox regionComboBox = new ComboBox(By.Name("tx_uedbflat_pi2[DATA][town_subdistrict_id][e][]"));
		private Button searchButton = new Button(By.XPath("//input[@type='submit']"));
		private CheckBox firstFloorCheckBox = new CheckBox(By.Id("storey_ne"));
		private CheckBox lastFloorCheckBox = new CheckBox(By.Id("storey_fne"));
		private Input fromCostValueInput = new Input(By.Name("tx_uedbflat_pi2[DATA][price][ge]"));
		private Input toCostValueInput = new Input(By.Name("tx_uedbflat_pi2[DATA][price][le]"));

		public FlatPage()
        {
			if (!searchButton.IsDisplayed())
				throw new PageNotFoundException("Page: " + GetType().Name + " not found");
		}

        public FlatsResultPage SearchFlatsByLocation(string location)
        {
            locationInput.SendKeys(location);
            searchButton.Click();

            return new FlatsResultPage();
        }

		public FlatsResultPage SearchFlatsByRegion(string region)
		{
			regionComboBox.SendKeys(region);
			searchButton.Click();

			return new FlatsResultPage();
		}

		public FlatsResultPage SearchFlatsByFirstFloor(bool notFirstFloor)
		{
			firstFloorCheckBox.Set(notFirstFloor);
			searchButton.Click();

			return new FlatsResultPage();
		}

		public FlatsResultPage SearchFlatsByLastFloor(bool notLastFloor)
		{
			lastFloorCheckBox.Set(notLastFloor);
			searchButton.Click();

			return new FlatsResultPage();
		}

		public FlatsResultPage SearchFlatsByCost(int from, int to)
		{
			fromCostValueInput.ClearText().SetText(from.ToString());
			toCostValueInput.ClearText().SetText(to.ToString());
			searchButton.Click();

			return new FlatsResultPage();
		}
    }
}
