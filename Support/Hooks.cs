using BoDi;
using Microsoft.Playwright;
using PlaywrightSpecflow.Drivers;
using TechTalk.SpecFlow;

namespace PlaywrightSpecflow.Support
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer objectContainer;
        public IPage Page { get; set; }

        public InitilizeDriver InitilizeDriver  { get; set; }

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }



        [BeforeScenario]
        public async Task FirstBeforeScenario()
        {
           InitilizeDriver = new InitilizeDriver();
           Page = await InitilizeDriver.ConfigureBrowser("chrome");
           objectContainer.RegisterInstanceAs<IPage>(Page);
           await Page.GotoAsync("https://demoqa.com/"); 
        }

       
    }
}