Feature: SMBSPlan
	    @SMBSPlan

Scenario Outline: a)Verify whether user clicks "Who We Work With" and select "SMBS" and click on "Learn More" button
          
		  Given user navigates to <url> Jobiak URL site
          When user clicks on Who we work with
		  When user clicks on SMBS
		  When user clicks on Learn More Button
Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 

Scenario Outline: b)Verify whether user select "SMBS" and click on "Learn More" button if User dont have URL or PDF
	     Given user navigates to <url> Jobiak URL site
         When user clicks on Who we work with
		 When user clicks on SMBS
		 When user clicks on Learn More Button where user dont have URL or PDF
Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 

Scenario Outline: c)Verify user clicks on "Post Job URL" or "upload pdf" in "SMBS"
	     Given user navigates to <url> Jobiak URL site
	     When user clicks on Who we work with
		 When user clicks on SMBS
         When user clicks on PostJobUrl
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
           When user clicks on Close
           When user clicks on Uploadpdf
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
	    | url                   |
	    | https://www.jobiak.ai | 

Scenario Outline: d)verify user click on "Basic plan" in pricing then click on "TRY IT NOW"
	     Given user navigates to <url> Jobiak URL site
         When user clicks on Who we work with
		 When user clicks on SMBS
		 When Scroll Down to given Height for All plans
         When user clicks on SMB Basicplan
         When user click on Basic TRY IT NOW

Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 

Scenario Outline: e)verify user click on "Basic plan" in pricing then click on "start Posting" 
	     Given user navigates to <url> Jobiak URL site
         When user clicks on Who we work with
		 When user clicks on SMBS
		 When Scroll Down to given Height for All plans
         When user clicks on SMB Basicplan
		 When user clicks on Basicplan and click on START POSTING
Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 

Scenario Outline: f)verify user click on "Pro plan" in pricing then click on "TRY IT NOW"
	     Given user navigates to <url> Jobiak URL site
         When user clicks on Who we work with
		 When user clicks on SMBS
		 When Scroll Down to given Height for All plans
         When user selects and clicks on PRO plan
         When user selects PRO plan and click on TRY IT NOW


Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 

Scenario Outline: g)verify user click on "Pro plan" in pricing then click on "start Posting" 
	     Given user navigates to <url> Jobiak URL site
         When user clicks on Who we work with
		 When user clicks on SMBS
		 When Scroll Down to given Height for All plans
         When user selects and clicks on PRO plan
         When user clicks on PRO plan and click on START POSTING
Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 

Scenario Outline: h)verify user click on "Feature plan" in pricing then click on "TRY IT NOW"
	     Given user navigates to <url> Jobiak URL site
         When user clicks on Who we work with
		 When user clicks on SMBS
		 When Scroll Down to given Height for All plans
         When user clicks on Feature plan
		 When user Selects Feature plan and click on TRY IT NOW


Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 

Scenario Outline: i)verify user click on "Feature plan" in pricing then click on "start Posting" 
 	     Given user navigates to <url> Jobiak URL site
         When user clicks on Who we work with
		 When user clicks on SMBS
		 When Scroll Down to given Height for All plans
         When user clicks on Feature plan
         When user clicks on Feature plan and click on START POSTING
Examples: 
	    | url                   |
	    | https://www.jobiak.ai | 



