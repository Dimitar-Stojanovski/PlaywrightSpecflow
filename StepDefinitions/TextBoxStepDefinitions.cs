using Microsoft.Playwright;
using PlaywrightSpecflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace PlaywrightSpecflow.StepDefinitions
{
    [Binding]
    public class TextBoxStepDefinitions
    {
        public IPage Page { get; }
        public TextBoxPage TextBoxPage { get; }

        public TextBoxStepDefinitions(IPage page)
        {
            Page = page;
            TextBoxPage = new TextBoxPage(Page);

        }
        [Given(@"I navigate to textbox url ""([^""]*)""")]
        public async Task GivenINavigateToTextboxUrl(string p0)
        {
           await Page.GotoAsync(p0);
        }

        [Given(@"I enter full name ""([^""]*)""")]
        public async Task GivenIEnterFullName(string p0)
        {
            await TextBoxPage.EnterFullName(p0);
        }

        [Given(@"I enter email ""([^""]*)""")]
        public async Task GivenIEnterEmail(string p0)
        {
            await TextBoxPage.EnterEmail(p0);
        }

        [Given(@"I enter current address ""([^""]*)""")]
        public async Task GivenIEnterCurrentAddress(string p0)
        {
            await TextBoxPage.EnterCurrentAddress(p0);
        }

        [Given(@"I enter permanent address ""([^""]*)""")]
        public async Task GivenIEnterPermanentAddress(string p0)
        {
            await TextBoxPage.EnterPermanentAddress(p0);
        }

        [When(@"I press submit button")]
        public async void WhenIPressSubmitButton()
        {
           await TextBoxPage.ClickSubmitButton();
        }

        [Then(@"I validate the result")]
        public async Task ThenIValidateTheResult()
        {
            await TextBoxPage.VerifyTheFourParagraphs();
        }


    }
}
