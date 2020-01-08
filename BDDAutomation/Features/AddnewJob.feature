@Smoke
Feature: AddnewJob
@AddnewJob
Scenario Outline:A)Verify whether the user is able to add the job through "Add new Job" option.
                 B)Verify whether the jobs in admin support dashboard are loading properly without showing any internal server error.
        Given user navigates to <url> for support dashboard page
		 When I try to login with credentials <username> and <password>	 
		 When I click on JobApprovalpageLink
		 When User clicks on Jobs All in Job approvals page
		 When User clicks on Add new Job in Job approvals page
         Then User Enter all the required details for new job posting
		 Then User click on Optimize and close the Window

		 #Then User clicks on Save and Approve job button for after editing job
		 
		 Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |

Scenario Outline:C)Verify whether the jobs are appearing or not in Jobs all page without giving approval
                 D)Verify whether the job is searchable or not in approval page, with the help of certain fields (say job title, job-id etc)
         Given user navigates to <url> for support dashboard page
		 When I try to login with credentials <username> and <password>	 
		 When I click on JobApprovalpageLink
		 When User clicks on Jobs All in Job approvals page
		 #Then User Enter all the required details for new job posting
		 #Then User clicks on Save and Approve job button for after editing job
		 When user clicks on Load Jobs button
		 When User performs Search in search box by giving Job Title inside Load Jobs
		 Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |







