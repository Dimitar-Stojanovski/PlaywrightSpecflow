Feature: TextBox




Scenario: Populate Text box and validate results
	Given I navigate to textbox url "https://demoqa.com/text-box"
	And  I enter full name "john doe"
	And I enter email "mail@mail.com"
	And I enter current address "address 1"
	And I enter permanent address "address 2"
	When I press submit button
	Then I validate the result

Scenario Outline: Populate text box using data driven
   Given I navigate to textbox url "https://demoqa.com/text-box"
   And I enter full name <fullName>
   And I enter email <email>
   And I enter current address <address>
   And I enter permanent address <perAddress>
   When I press submit button
   Then I validate the result

  Examples: 
  | fullName       | email         | address  | perAddress |
  | Hans Musterman | hans@mail.com | address3 | address4   |

    
	
