Feature: Data Driven Testing

A short summary of the feature

@TestersTalk
Scenario: Search for Testers Talk using data driven testing
	Given I am on the youtube search page
	When I search for 'Tester Talk by bakkappa'
	Then I see results for Tester Talk
