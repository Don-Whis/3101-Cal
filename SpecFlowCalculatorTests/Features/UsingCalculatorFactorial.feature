Feature: UsingCalculatorFactorial
		In order to conquer factorial
		As a factorial enthusiast
		I want to understand a variety of factorial operations

@Factorial
Scenario: Positive factorial
	Given I have a calculator
	When I have entered 5 into the calculator and press factorial 
	Then the factorial result should be 120
	
@Factorial
Scenario: Zero factorial
	Given I have a calculator
	When I have entered 0 into the calculator and press factorial 
	Then the factorial result should be 1