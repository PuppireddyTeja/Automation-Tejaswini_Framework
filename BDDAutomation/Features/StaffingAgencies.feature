Feature: StaffingAgencies
	@StaffingAgencies
	Scenario Outline: Verify user clicks on "contact us to get started" in "Staffing Agencies"
	         Given user navigates to <url> Jobiak URL site
             When user clicks on StaffingAgencies
			 When user clicks on StaffingAgenciesContactUsGetStarted
	Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 


	Scenario Outline: Verify user clicks on "Post Job URL" or "upload pdf" in "Staffing Agencies"
	         Given user navigates to <url> Jobiak URL site
			 When user clicks on StaffingAgencies
             When user clicks on PostJobUrl
			 When user clicks on Uploadpdf
			 When I Click on job description and enter value
             When I click on Date Posted
	         When I click on Save
             Then click on company in Tagging Page
             Then click on Salary
	         Then I Click on Preview Button
	         Then I click on OptimiZe Button
             Then I Click on Preview Button
             Then I click on Edit Button
             Then I Click on Preview Button
     Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 


    Scenario Outline: Verify user try through "ATS"  and click on "contact us to get started" in "Staffing Agencies"
	         Given user navigates to <url> Jobiak URL site
			 When user clicks on StaffingAgencies
             When user clicks on ATS contactusgetStarted Button
	Examples: 
	    | url                   |
	    | https://www.jobiak.ai |
		

    Scenario Outline: Verify user Interested in learning more about Jobiak and click on "contact us to get started" in "Staffing Agencies"
	         Given user navigates to <url> Jobiak URL site
			 When user clicks on StaffingAgencies
             When user clicks on contactusgetStarted Button to Register with Jobiak
	Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 





