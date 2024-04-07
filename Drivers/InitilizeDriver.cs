using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightSpecflow.Drivers
{
    public class InitilizeDriver
    {
        public IPage? Page { get; set; }

        public async Task<IPage> ConfigureBrowser(string browserType)
        {
            return browserType switch
            {
                "chrome" => await LaunchChromium(),
                "firefox" => await LauncFirefox(),
                _ => throw new Exception("Invalid broser provided")
            };
        }





        private async Task<IPage> LaunchChromium()
        {
            var options = BrowserOptions;
            options.Channel = "chromium";
            var playWright = await Playwright.CreateAsync();
            var browser = await playWright.Chromium.LaunchAsync(options);
            Page = await browser.NewPageAsync();
            return Page;
        }

        private async Task<IPage> LauncFirefox()
        {
            var options = BrowserOptions;
            options.Channel = "firefox";
            var playWright = await Playwright.CreateAsync();
            var browser = await playWright.Firefox.LaunchAsync(options);
            Page = await browser.NewPageAsync();
            return Page;
        }

        private BrowserTypeLaunchOptions BrowserOptions =>
            new()
            {
                Headless = true,
                Timeout = 1000 * 10
            };

    }
}
