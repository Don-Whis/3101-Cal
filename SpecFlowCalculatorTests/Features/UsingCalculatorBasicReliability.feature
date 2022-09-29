Feature: UsingCalculatorBasicReliability 
In order to calculate the Basic Musa model's failures/intensities 
As a Software Quality Metric enthusiast 
I want to use my calculator to do this 
@Reliability 
Scenario: Calculating Current Failure Intensity 
    Given I have a calculator 
    When I have entered 100 and 50 and 10 into the calculator and press Current Failure Intensity 
    Then the  result should be 5 
@Reliability 
Scenario: Calculating Average Number of Expected Failure 
    Given I have a calculator 
    When I have entered 100 and 10 and 10 into the calculator and press Average Number of Expected Failure 
    Then the  result should be 63.21