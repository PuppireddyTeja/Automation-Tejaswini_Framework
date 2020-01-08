@Smoke
Feature: SupportDashboardReportLinks
@SupportDashboardReportLinks
Scenario Outline:A)Verify Whether user clicks on Report Links and able to see Report

 Given user navigates to <url> for support dashboard page
 When I try to login with credentials <username> and <password>	
 When user clicks on Customer Search
 Then user clicks on Company and Select Required Fields
 When user clicks on All Report Links
 When user clicks on View and Applies Links

  Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |


Scenario Outline:B)Verify Whether user clicks on Access Permissions and able to Update
 Given user navigates to <url> for support dashboard page
 When I try to login with credentials <username> and <password>
 When user clicks on Access permissions and Enter All Fields

  Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |

Scenario Outline:C)Verify Whether User able to edit and save in Access Users Page
  Given user navigates to <url> for support dashboard page
  When I try to login with credentials <username> and <password>
  When user clicks on Edit in Given Access Users Page
   Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |



Scenario Outline:D)Verify Whether user clicks on Job Queue Dashboard,Google PostedJobs Views and Dashboard Stats
Given user navigates to <url> for support dashboard page
 When I try to login with credentials <username> and <password>
 When user clicks on Job Queue Dashboard,Google PostedJobs and Views

 Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |


Scenario Outline:E)Verify Whether user clicks on Dashboard Stats
Given user navigates to <url> for support dashboard page
 When I try to login with credentials <username> and <password>
 When user clicks on Dashboard Stats and ETL Management
 Examples: 
		 | username        | password  | url                             |
		 | mohan@jobiak.ai | mohan@123 | https://support.jobiak.ai/login |




