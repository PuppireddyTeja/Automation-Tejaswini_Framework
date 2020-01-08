Feature: HowWeWorkPartnershipsAlliances
	@HowWeWorkPartnershipsAlliances
	Scenario Outline: a)Verify Whether user click on "how we work" and click "contact us to get started" to Register to Given plans
	                  Given user navigates to <url> Jobiak URL site
					  When user clicks on How we Work
					  When user clicks on Contact Us Get Started Button in How we Work Link
	Examples: 
	    | url                   |
	    | https://www.jobiak.ai |


 	Scenario Outline: b)Verify Whether user click on "partnerships"  and click "contact us to get started" to Register to Given plans
                      Given user navigates to <url> Jobiak URL site
					  When user clicks on Partnerships
					  When user clicks on Contact Us Get Started Button in Partnerships

    Examples: 
	    | url                   |
	    | https://www.jobiak.ai |

	Scenario Outline: a)Verify Whether user click on "Strategic Alliances" and click "contact us to get started" to Register to Given plans
	                  Given user navigates to <url> Jobiak URL site
					  When user clicks on Strategic Alliances
					  When user clicks Contact Us Get Started Button in StartAllainces
     Examples: 
	    | url                   |
	    | https://www.jobiak.ai |












