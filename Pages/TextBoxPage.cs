using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightSpecflow.Pages
{
    public class TextBoxPage:BasePage
    {
        
        private ILocator _fullNameInput;

        private ILocator _emailInput;

        private ILocator _currentAddressInput;

        private ILocator _permanentAddress;

        private ILocator _submitBtn;

        private ILocator _paragraphs;
        public TextBoxPage(IPage page):base(page)
        {
             Page = page;
            _fullNameInput = page.Locator("#userName");
            _emailInput = page.GetByPlaceholder("name@example.com");
            _currentAddressInput = page.GetByRole(AriaRole.Textbox, new() { Name = "Current Address" });
            _permanentAddress = page.Locator("#permanentAddress");
            _submitBtn = page.GetByRole(AriaRole.Button, new() { Name = "Submit" });
            _paragraphs = page.Locator("//div[@id='output']/div/p");

        }

        public async Task EnterFullName(string name)
            => await Populate(_fullNameInput, name);

        public async Task EnterEmail(string mail)
            => await Populate(_emailInput, mail);

        public async Task EnterCurrentAddress(string address)
            => await Populate(_currentAddressInput, address);

        public async Task EnterPermanentAddress(string address)
            => await Populate(_permanentAddress, address);

        public async Task ClickSubmitButton()
            => await ClickOn(_submitBtn);
            
        public async Task VerifyTheFourParagraphs()
            => await Assertions.Expect(_paragraphs).ToHaveCountAsync(4);

        
    }
}
