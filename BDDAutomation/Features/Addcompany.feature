@Smoke
Feature: Addcompany
Add and Edit company in Support Dashboard
@Addcompany
Scenario Outline:A)Verify whether the user is able to add the new company using "add new company" option.
                 B)Verify whether the user is able to edit the company in companies list.
           Given user navigates to <url> for support dashboard page
		   When I try to login with credentials <username> and <password>	 
		   When I click on JobApprovalpageLink
		   When User clicks on Companies and Add new company
		   When User click And selectEmployer From Dropdown and Enter Companyname
		   Then User click on search Box And Edit
		   #Then click on save

		 Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |








