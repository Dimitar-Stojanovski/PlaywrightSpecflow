Feature: TextBox

Background: Writing some notes
Given I navigate to textbox url "https://demoqa.com/text-box"


Scenario: Populate Text box and validate results
	
	And I enter full name 'john doe'
	And I enter email "mail@mail.com"
	And I enter current address "address 1"
	And I enter permanent address "address 2"
	When I press submit button
	Then I validate the result

Scenario Outline: Populate text box using data driven
  
   And I enter fullnameInput as '<name>'
   And I enter email as '<emailAddress>'
   And I enter current address as '<address>'
   And I enter permanent address as '<perAddress>'
   When I press submit button
   Then I validate the result

  Examples: 
  | name       | emailAddress  | address  | perAddress |
  | Hans Musterman | hans@mail.com | address3 | address4   |
  | John Doe       | mail@mail.com | address2 | address5   |

    
	
