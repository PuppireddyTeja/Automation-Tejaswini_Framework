@Smoke
Feature: SupportUserManagement
@SupportUserManagement
Scenario Outline:Verify whether the user is able to assign the job to the respective employer, using support user management functionality.
		 Given user navigates to <url> for support dashboard page
		 When I try to login with credentials <username> and <password>
		 When I click on supportUserManagementLink
		 When User select Not Assigned From Assigned User DropDown To View All NotAssigned Jobs
		 Then User pick Random Client Id From Available NotAssinged Jobs And Click on Edit
		 Then User Select not Assigned from AssignUser Dropdown and click on save Button
		 Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |


