using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightSpecflow.Pages
{
    public class BasePage
    {
        public IPage Page { get; protected set; }
        public BasePage(IPage page)
        {
            Page = page;
        }

        protected async Task Populate(ILocator locator, string value)
            => await locator.FillAsync(value);

        protected async Task ClickOn(ILocator locator,LocatorClickOptions? options=null)
            => await locator.ClickAsync();

       protected async Task ClickCheckBoxOrRadio(ILocator locator)
            => await locator.CheckAsync();

        protected async Task SelectDropDown(ILocator locator, string values, LocatorSelectOptionOptions? options = null)
            => await locator.SelectOptionAsync(values);
        protected async Task HooverOn(ILocator locator)
            => await locator.HoverAsync();


    }
}
