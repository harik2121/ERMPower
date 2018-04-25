Feature: RegisterOnline
	As a online user, I want to register on nopCommerce web page


Scenario: Register online on nopCommerce web page
	Given I go to the nopCommerce web page
	When I click on register button
	Then I provide user details in given fields
	When I click on register button
	Then Verify user registration was sucessful





