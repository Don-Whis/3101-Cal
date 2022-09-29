using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ICT3101_Calculator; 
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public sealed class AvailabilityStepDefinition
{


    private double _result;
    private Calculator _calculator;
    //context injection, there isn't any [given] step
    //test
    public AvailabilityStepDefinition(Calculator calc)
    {
        this._calculator = calc;
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")] 
    public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
    {
        _result = _calculator.MBTF(p0, p1); 
    }
    [Then(@"the MTBF result should be (.*)")]
    public void ThenMTBFResultShouldBeOnTheScreen(double p0) {
        Assert.That(_result, Is.EqualTo(p0)); 
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press Availability")] 
    public void WhenIHaveEnteredAvalabilityIntoTheCalculator(double p0, double p1)
    {
        _result = _calculator.Availability(p0, p1); 
    }

    [Then(@"the availability result should be (.*)")]
    public void ThenAvailabilityResultShouldBeOnTheScreen(double p0) {
        Assert.That(_result, Is.EqualTo(p0)); 
    }
}