Feature: Spell Checking
	In order to avoid silly mistakes
	As a keyboard n00b
	I want to check the spelling of any text I enter

Scenario: Checking Spelling of content
	Given I have entered "Hello"
	When I press the Spell Check button
	Then the result should show there were no errors
