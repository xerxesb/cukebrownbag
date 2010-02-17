Feature: Spell Checking
	In order to avoid silly mistakes
	As a keyboard n00b
	I want to check the spelling of any text I enter

Scenario: Checking Spelling of content
	Given I have entered "Hello"
	And the content is valid
	When I perform a spell check
	Then the result should show there were no errors
