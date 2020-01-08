@Smoke
Feature: MultipleJoburl
@MultipleJoburl
Scenario Outline:A)Verify whether the jobs are loading properly in summary page as per the respective plan.
         B)Verify whether the user login to app.jobiak and  support dashboard with different palns
		 c)Verify whether the jobs are Posted by Multiple jobs

	 Given I navigate to <url> TRY IT NOW Tagging Page
	 When Click on Signin Credentials
     When I Try to Signin with credentials <username> and <password>
	 Then I click on Addjob
	 Then Enter multiple Job and click on Postjobs
	 Then I click on popup
	 When I click on symbols
	 Then I click on preview
	  Examples: 
		 | username                    | password  | url                               |
		 | balachandrasekhar@jobiak.ai | bala@123  | https://www.jobiak.ai/try-it-now/ |

	   

