Feature: UsingCalculatorDefectDensity
In order to calculate DefectDensity and FailureIntensity
As someone who struggles with math
I want to be able to use my calculator to do this


@defectDensity
Scenario: Calculating DefectDensity
	Given I have a calculator
	When I have entered 20 and 40 into the calculator and press Current Defect Density
	Then the defect density result should be 0.5
	
@defectDensity
Scenario: Calculating SSI
	Given I have a calculator
	When I have entered 50 and 20 and 4 and 1 into the calculator and press SSI
	Then the SSI result should be 65