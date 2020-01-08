Feature: WhoWeWorkWithLink
	@WhoWeWorkWithLink
Scenario Outline: a)verify whether user clicks on "who we work with",Select Enterprise and click on plan1
         Given user navigates to <url> Jobiak URL site
		 When user click on Enterprise Link
		 Then Scroll Down to Particular Height
         When user selects on Enterprise Plan 1
		 When user click on contact us to get started
		 Then user Enter contact page Fields
		 Examples: 
	    | url                   |
	    | https://www.jobiak.ai |

Scenario Outline: b)verify whether user clicks on "who we work with",Select Enterprise and click on plan2
         Given user navigates to <url> Jobiak URL site
		 When user click on Enterprise Link
		 Then Scroll Down to Particular Height

         When user selects  Enterprise and click Plan 2
		 When user click on contact us to get started
		 Then user Enter contact page Fields
		 Examples: 
	    | url                   |
	    | https://www.jobiak.ai |

Scenario Outline: verify whether user clicks on "who we work with",Select Enterprise and click on plan3
         Given user navigates to <url> Jobiak URL site
		 When user click on Enterprise Link
		 Then Scroll Down to Particular Height
         When user selects on Enterprise and click on plan 3
		 When user click on contact us to get started
		 Then user Enter contact page Fields
		 Examples: 
	    | url                   |
	    | https://www.jobiak.ai |

Scenario Outline: verify whether user clicks on "who we work with",Select Enterprise and click on plan4
         Given user navigates to <url> Jobiak URL site
		 When user click on Enterprise Link 
		 Then Scroll Down to Particular Height
         When user selects and clicks on Enterprise Plan 4
		 When user click on contact us to get started
		 Then user Enter contact page Fields
		 Examples: 
	    | url                   |
	    | https://www.jobiak.ai |

Scenario Outline: verify whether user clicks on "who we work with",Select Enterprise and click on plan5
         Given user navigates to <url> Jobiak URL site
		 When user click on Enterprise Link
		 Then Scroll Down to Particular Height
         When user selects Enterprise Plan 5 and click on Contact US Button
		 
		 Examples: 
	    | url                   |
	    | https://www.jobiak.ai |



 


	