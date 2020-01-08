@Smoke
Feature: ProductionTagging
	Signin to Tagging Page by using Signin credentials in "Try It Now" Page

@TaggingPage
Scenario Outline: 001-Verify whether the jobs are Posted by Single job in signin page
    Given I navigate to <url> TRY IT NOW Tagging Page
	When Click on Signin Credentials
    When I Try to Signin with credentials <username> and <password>
    Then I try to Add job with single job Url and postjob
    When I Click on job description and enter value
    When I click on Date Posted
    When I click on Save
	Then click on company for the Given Job Url
	When click on Location
    When I click on Valid Through based on Date Posted
	Then I Click on Preview Button
	Then I click on OptimiZe Button
    Then I Click on Preview Button
    Then I click on Edit Button
	Then I Click on Preview Button

	 Examples: 
		 | username                    | password  | url                               |
		 | balachandrasekhar@jobiak.ai | bala@123  | https://www.jobiak.ai/try-it-now/ |


    Scenario Outline: 002-Verify with Preview and Optimize Button by Posting "Job" with Job Page URL
    Given I navigate to <url> TRY IT NOW Tagging Page
    Then ScrollDown to Particular Element
	Then I enter Job Page URL
	When I click on Get Started
	When I Click on job description and enter value
    When I click on Date Posted
    When I click on Save
	Then click on company for the Given Job Url
	When click on Location
	When I click on Valid Through based on Date Posted
    Then I Click on Preview Button
	Then I click on OptimiZe Button
    Then I Click on Preview Button
    Then I click on Edit Button
    Then I Click on Preview Button
	Examples: 
	  | url                               |
	  | https://www.jobiak.ai/try-it-now/ |   

    

Scenario Outline: 003-Verify Job published with PDF
    Given I navigate to <url> TRY IT NOW Tagging Page
    Then ScrollDown to Particular Element
	Then upload PDF
	Examples: 
	  | url                               |
	  | https://www.jobiak.ai/try-it-now/ | 


Scenario Outline: 004-Verify Job published with PDF using Different Plans
    Given I navigate to <url> TRY IT NOW Tagging Page
	When Click on Signin Credentials
    When I try to login with credentials <username> and <password>
	Then upload PDF By Plans
	When I Click on job description and enter value
    When I click on Date Posted
    When I click on Save
	Then click on company
	Then click on Salary
	Then I Click on Preview Button
	Then I click on OptimiZe Button
    Then I Click on Preview Button
    Then I click on Edit Button
    Then I Click on Preview Button
	Examples: 
		 | username                   | password  | url                               |
		 |balachandrasekhar@jobiak.ai | bala@123  | https://www.jobiak.ai/try-it-now/ |










