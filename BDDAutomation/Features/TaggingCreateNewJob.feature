@Smoke
Feature: TaggingNewJob
@TaggingNewJob-Try-it-now
Scenario Outline: verify user is able to create Job Details in Tagging Page in "try-it-now" Page
    Given I navigate to <url> TRY IT NOW Tagging Page
	When user clicks on Create job
	When user Enter All the Job details
	Then user clicks on previewbutton
	Examples: 
	  | url                               |
	  | https://www.jobiak.ai/try-it-now/ |   




	