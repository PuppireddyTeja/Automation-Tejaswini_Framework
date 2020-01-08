Feature: FreePlan
	@FreePlan
	Scenario Outline:Verify whether user sign by Free plan
	        Given user navigates to <url> Jobiak URL site
            When I Try to Signin with credentials <username> and <password>
			When user clicks on DAshboard Link
            When user clicks on Settings for Free plan and update All details
			When user clicks on Cancel Subscription

            When user clicks on Transactions
	  Examples: 
		 | username       | password | url                         |
		 | bala@pluto.com | teja@123 | https://app.jobiak.ai/login |

Scenario Outline:verify whether user click on "Add Job" and post Jobs by Free plan with "Single Job"
	         Given user navigates to <url> Jobiak URL site
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
             
			 Examples: 
		 | username       | password | url                         |
		 | bala@pluto.com | teja@123 | https://app.jobiak.ai/login |
             
 Scenario Outline:verify whether user click on "Add Job" and post Jobs by Free plan with "Multiple Job"
            Given user navigates to <url> Jobiak URL site
            When I Try to Signin with credentials <username> and <password>
	        Then I click on Addjob
	        Then Enter multiple Job and click on Postjobs
	        Then I click on popup
	        When I click on symbols
	        Then I click on preview
			

			Examples: 
		 | username       | password | url                         |
		 | bala@pluto.com | teja@123 | https://app.jobiak.ai/login |

Scenario Outline: Verify user Create Job And "Proceed"
            Given user navigates to <url> Jobiak URL site
            When I Try to Signin with credentials <username> and <password>
            When user clicks on Add New Job
			When user Enter All the Job details
            Then user clicks on previewbutton
Examples: 
		 | username       | password | url                         |
		 | bala@pluto.com | teja@123 | https://app.jobiak.ai/login |

Scenario Outline: verify user upload "Job PDF" by Free plan
           Given user navigates to <url> Jobiak URL site
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
		 | username       | password | url                         |
		 | bala@pluto.com | teja@123 | https://app.jobiak.ai/login |




