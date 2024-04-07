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
        public TextBoxPage textBoxPage;

        public TextBoxStepDefinitions(IPage page)
        {
            Page = page;
            textBoxPage = new TextBoxPage(Page);

        }

        [Given(@"I navigate to textbox url ""([^""]*)""")]
        public async Task GivenINavigateToTextboxUrl(string url)
        {
            await Page.GotoAsync(url);
        }



        [Given(@"I enter email ""([^""]*)""")]
        public async Task GivenIEnterEmail(string email)
        {
            await textBoxPage.EnterEmail(email);
        }

        [Given(@"I enter current address ""([^""]*)""")]
        public async Task GivenIEnterCurrentAddress(string currentAddress)
        {
            await textBoxPage.EnterCurrentAddress(currentAddress);
        }

        [Given(@"I enter permanent address ""([^""]*)""")]
        public async Task GivenIEnterPermanentAddress(string permanentAddress)
        {
            await textBoxPage.EnterPermanentAddress(permanentAddress);
        }

        [When(@"I press submit button")]
        public async void WhenIPressSubmitButton()
        {
           await textBoxPage.ClickSubmitButton();
        }

        [Then(@"I validate the result")]
        public async Task ThenIValidateTheResult()
        {
            await textBoxPage.VerifyTheFourParagraphs();
        }

        [Given(@"I enter full name '([^']*)'")]
        public async Task GivenIEnterFullName(string fullName)
        {
            await textBoxPage.EnterFullName(fullName);        
        }

        

        [Given(@"I enter email as '([^']*)'")]
        public async Task GivenIEnterEmailAs(string email)
        {
            await textBoxPage.EnterEmail(email);
        }

        [Given(@"I enter current address as '([^']*)'")]
        public async Task GivenIEnterCurrentAddressAs(string address)
        {
            await textBoxPage.EnterCurrentAddress(address);
        }

        [Given(@"I enter permanent address as '([^']*)'")]
        public async Task GivenIEnterPermanentAddressAs(string address)
        {
            await textBoxPage.EnterPermanentAddress(address);
        }

        [Given(@"I enter fullnameInput as '([^']*)'")]
        public async Task GivenIEnterFullnameInputAs(string fullName)
        {
            await textBoxPage.EnterFullName(fullName);
        }


        





    }
}
