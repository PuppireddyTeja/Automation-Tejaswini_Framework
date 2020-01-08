@Smoke
Feature: JobiakBottomLinks
@JobiakBottomLinks
Scenario Outline: Verify user clicks on Jobiak Bottom Links
        Given user navigates to <url> Jobiak URL site
		When user clicks on Bottom Jobiak Links

Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 