Feature: Data Table Data Driven Testing Examples

A short summary of the feature

@TestersTalk
Scenario: Search for Testers Talk using data driven scenario outline
	Given I am on the youtube search page
	When Enter search keyword in YouTube
	| searchKey				   |
	| specflow by testers talk |
	| selenium by testers talk |



