Feature: TextBox

A short summary of the feature


Scenario: Populate Text box and validate results
	Given I navigate to textbox url "https://demoqa.com/text-box"
	And  I enter full name "john doe"
	And I enter email "mail@mail.com"
	And I enter current address "address 1"
	And I enter permanent address "address 2"
	When I press submit button
	Then I validate the result
	
