Feature: Page Object Model

Search for Testers Talk on Youtube
@TestersTalk
Scenario: Page Object Model
	Given I am on the YouTube home page
	When I search for Testers Talk in the search bar
	And click on the Tester Talk channel in the search results
	Then I am taken to the Testers Talk YouTube channel

