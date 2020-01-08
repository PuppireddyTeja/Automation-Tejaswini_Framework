Feature: Carrers
	@Carrers
Scenario Outline: Verify user Clicks on Carrer Link and Apply for given Jobs
        Given user navigates to <url> Jobiak URL site
        When user clicks on Carrer Site Link
        When user clicks on Apply Now Button Links

Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 