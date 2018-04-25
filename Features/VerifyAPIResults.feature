Feature: VerifyAPIResults
	Verify API call results

@mytag
Scenario: Verify API Results
	Given I communicate to public API url
	When I have fetch API details
	Then I verify API returned values
