using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightSpecflow.Drivers
{
    internal class Example
    {
        public IPage Page { get; set; }
        public InitilizeDriver InitilizeDriver { get; set; }

        [Test]
        public async Task test1()
        {
            InitilizeDriver = new InitilizeDriver();
            Page = await InitilizeDriver.ConfigureBrowser("firefox");
            await Page.GotoAsync("https://google.com");
            Thread.Sleep(5000);
        }
    }
}
