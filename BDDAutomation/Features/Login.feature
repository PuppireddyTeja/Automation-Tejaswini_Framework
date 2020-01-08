@Smoke
Feature: Login
Login to home page of portal with different logins

@Login
Scenario Outline: 001-Login to Portal with Admin user
    Given I enter to Portal Login page
	When I try to login with credentials <username> and <password> 
	Then I click on Logout
Examples:
	| username        | password  |
	| mohan@jobiak.ai | mohan@123 |
Scenario: 002-Login with generic data
    Given I enter to Portal Login page
    And  I enter username
	And I enter password
	And I click on login button
    Then I click on Logout

Scenario: 003-Verify all the URLs in the main page
    Given I enter to Portal Login page
    And  I enter username
	And I enter password
	And I click on login button
	When I click on All the pages are avaibale in the page
	Then I click on Logout


