@Smoke
Feature: JobiakMainLinks
@JobiakmainLinks
Scenario Outline: Verify user Clicks on all Jobiak Links
        Given user navigates to <url> Jobiak URL site
		When User Click and validate Navigation to Enterprise page
		Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 
