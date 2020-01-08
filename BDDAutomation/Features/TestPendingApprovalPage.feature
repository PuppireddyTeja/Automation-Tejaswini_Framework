@Smoke
Feature: TestPendingApprovalPage
@TestPendingApprovalPage
Scenario Outline:A)Verify whether the user is able to edit and approve the job in approval page.
                 B)Verify whether the user is able to access the "Reset editing status" for the respective job
         Given user navigates to <url> for support dashboard page
		 When I try to login with credentials <username> and <password>	
		 When I click on JobApprovalpageLink
		 Then User clicks on Load Pending Approval Jobs button from Jobs Approval page
	     Then Click on Reset editing Status
		 When User clicks on random edit icon for a job title
		 Then User Enter all the required details for Edit job posting
		 Then User click on Optimize and close the Window

		 #Then User clicks on Save and Approve job button for after editing job
		 Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |
       



















