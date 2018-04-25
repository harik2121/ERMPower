Feature: RegisterOnline
	As a online user, I want to logon to nopCommerce web page


Scenario: Logon to nopCommerce web page
	Given I go to the nopCommerce web page
	When I navigate on login page
	Then I provide user login details
	When I click on login button
	Then Verify user login was sucessful





