Feature: Youtube Search Feature

Search for Testers Talk on YouTube

@TestersTalk
Scenario: Search for Testers Talk
	Given I am on the youtube search page
	When I search for Tester Talk
	Then I see results for Tester Talk
