Feature: FailureIntensity
	Simple calculator for adding two numbers

@ClientRequirement
Scenario: Logarithmic Model Current Failure Intensity
Given I have a calculator
When I have entered 10, 50 and 0.02 and press CurrentFailureIntensityLog
Then the failure intensity expected result should be 3.68

@ClientRequirement 
Scenario: Logarithmic Model Avg Number of expected failures
Given I have a calculator
When I have entered 10, 10, 0.02 and press NumberOfExpectedFailure
Then the failures result should be 55
