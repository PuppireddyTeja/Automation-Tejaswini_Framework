@Smoke
Feature: Employer
Edit Employer in Job Approval Page
@Employer
Scenario Outline:Verify whether the user is able to edit the employer in employer list
         Given user navigates to <url> for support dashboard page
		 When I try to login with credentials <username> and <password>	 
		 When I click on JobApprovalpageLink
		 When User clicks on Employer tab in Job approvals page
		 Then Employer Tab page elements should be displayed
		 When User clicks on Employer record edit icon based on employer name
		 Then Employer details edit page should be opened
		 Then User clicks on Rating count
         #Then click on Save button inside Employer Details should save the form
		   Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |






	