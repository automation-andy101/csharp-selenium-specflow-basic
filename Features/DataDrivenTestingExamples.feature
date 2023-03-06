Feature: Data Driven Testing Examples

A short summary of the feature

@TestersTalk
Scenario Outline: Search for Testers Talk using data driven scenario outline
	Given I am on the youtube search page
	When I search with <searchText>
	Then I see results for Tester Talk

	Examples: 
	| searchText			    |
	| SpecFlow Talk by bakkappa |
	| Selenium Talk by bakkappa |

