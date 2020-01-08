@Smoke
Feature: EnterprisePlan
	@EnterprisePlan
		Scenario Outline:Verify whether user signup by Method 1 in Enterprise plan
		 Given user navigates to <url> for support dashboard page
		 When I try to login with credentials <username> and <password>	
		 When User Click On CustomerOnboarding And CreateAccount
		 When Signin with <email> Email
		 Then User Enter All BasicInformation Fields
		 Then User Enter Company Informartion
		 Then Click on methods <methodName> and save
		  Examples: 
		 | username        | password  | url                             | methodName | email             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login | Method 1   | rinki14@jobiak.ai |

		 Scenario Outline:Verify whether user signup by Method 2 in Enterprise plan
		 Given user navigates to <url> for support dashboard page
		 When I try to login with credentials <username> and <password>	
		 When User Click On CustomerOnboarding And CreateAccount
		 When Signin with <email> Email
         Then User Enter All BasicInformation Fields
		 Then User Enter Company Informartion
		 Then Click on methods <methodName> and save
		  Examples: 
		 | username        | password  | url                             | methodName | email             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login | Method 2   | rinki17@jobiak.ai |

		 Scenario Outline:Verify whether user signup by Method 3 in Enterprise plan
		 Given user navigates to <url> for support dashboard page
		 When I try to login with credentials <username> and <password>	
		 When User Click On CustomerOnboarding And CreateAccount
		 When Signin with <email> Email
         Then User Enter All BasicInformation Fields
		 Then User Enter Company Informartion
		 Then Click on methods <methodName> and save
		  Examples: 
		 | username        | password  | url                             | methodName | email             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login | Method 3   | rinki16@jobiak.ai |

Scenario Outline:verify whether user click on "Add Job" and post Jobs by Enterprise plan with "Single Job"
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
             Then I click on Edit Button
	         Then I Click on Preview Button
			 Examples: 
		 | username            | password  | url                         |
		 | tejaswini@jobiak.ai | Teju@123  | https://app.jobiak.ai/login |
             
 Scenario Outline:verify whether user click on "Add Job" and post Jobs by Enterprise plan with "Multiple Job"
            Given user navigates to <url> Jobiak URL site
            When I Try to Signin with credentials <username> and <password>
		    Then User click on ChangeSource and select Carrer Job Url
	        Then Enter multiple Job and click on Postjobs
	        Then I click on popup
	        When I click on symbols
	        Then I click on preview
			Examples: 
		 | username            | password  | url                         |
		 | tejaswini@jobiak.ai | Teju@123 | https://app.jobiak.ai/login |

Scenario Outline: Verify user Create Job And "Proceed"
            Given user navigates to <url> Jobiak URL site
            When I Try to Signin with credentials <username> and <password>
			Then User click on ChangeSource and select Carrer Job Url
            When user clicks on Add New Job and click on proceed
			When user Enter All the Job details
	        Then user clicks on previewbutton

			Examples: 
		 | username            | password | url                         |
		 | tejaswini@jobiak.ai | Teju@123 | https://app.jobiak.ai/login |

Scenario Outline: Verify user click on "ATS" option and post the Job
		      Given user navigates to <url> Jobiak URL site
              When I Try to Signin with credentials <username> and <password>
              Then User click on ATS and JobDiva
			  Then User enter API keys
			  Then User click on continue

			  Examples: 
		 | username            | password  | url                         |
		 | tejaswini@jobiak.ai | Teju@123  | https://app.jobiak.ai/login |




