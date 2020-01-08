Feature: Pricing
	    @Pricing
Scenario Outline: Verify user clicks on "Pricing" and select "Enterprise" Plan1,plan2,plan3,plan4,plan5 and click on "Contact Us To Get Started"
         Given user navigates to <url> Jobiak URL site
		 When user clicks on Pricing
         When user selects on Enterprise Plan 1
         When user clicks on Contact Us Get Started
         Then Navigate Back to Given Page
         When user selects  Enterprise and click Plan 2
         When user clicks on Contact Us Get Started
		 Then Navigate Back to Given Page
         When user selects on Enterprise and click on plan 3
         When user clicks on Contact Us Get Started
		 Then Navigate Back to Given Page
         When user selects and clicks on Enterprise Plan 4
         When user clicks on Contact Us Get Started
		 Then Navigate Back to Given Page
         When user selects Enterprise Plan 5 and click on Contact US Button
		 When user clicks on Contact Us Get Started
		 Then user Enter contact page Fields

		 Examples: 
	    | url                   |
	    | https://www.jobiak.ai |

Scenario Outline: Verify user clicks on "Pricing" and select "SMB" Basic,pro,Feature plans and click on "TRY IT NOW"
         Given user navigates to <url> Jobiak URL site
		 When user clicks on Pricing
         When user selects and clicks on Small medium Business
		 When User click on SMBS Basic plan
         When user click on Basic TRY IT NOW
		 Then Navigate Back to Given Page
         When User click on SMBS Pro plan      
         When user selects PRO plan and click on TRY IT NOW
		 Then Navigate Back to Given Page
         When User click on SMBS Feature plan 
         When user Selects Feature plan and click on TRY IT NOW
		 Then Navigate Back to Given Page
		 When User click on SMBS Basic plan
         When user clicks on Basicplan and click on START POSTING
		 Then Navigate Back to Given Page
         When User click on SMBS Pro plan
         When user clicks on PRO plan and click on START POSTING
		 Then Navigate Back to Given Page
         When User click on SMBS Feature plan
         When user clicks on Feature plan and click on START POSTING

Examples: 
	    | url                   |
	    | https://www.jobiak.ai |

Scenario Outline: Verify user clicks on "Partnerships" and click on "Contact Us To Get Started"
         Given user navigates to <url> Jobiak URL site
		 When user clicks on Pricing
         When User click on Partnerships
		 When User click on Partnerships Link and click on contact us Get Started


Examples: 
	    | url                   |
	    | https://www.jobiak.ai |

Scenario Outline: Verify user clicks on "About" and click on "Start Posting"
         Given user navigates to <url> Jobiak URL site
		 When User click on About Link
		 When User click on About Link and Start Posting

Examples: 
	    | url                   |
	    | https://www.jobiak.ai |
