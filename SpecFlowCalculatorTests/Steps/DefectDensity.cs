using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ICT3101_Calculator; 
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public sealed class DefectDensity
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private double _result;
    private Calculator _calculator;
    //context injection, there isn't any [given] step
    public DefectDensity(Calculator calc)
    {
        this._calculator = calc;
    }

    
    [When(@"I have entered (.*) and (.*) and (.*) and (.*) into the calculator and press SSI")] 
    public void WhenIHaveEnteredSsiIntoTheCalculator(double p0, double p1,double p2,double p3)
    {
        _result = _calculator.SSI(p0, p1, p2 , p3); 
    }
    [Then(@"the SSI result should be (.*)")]
    public void ThenSsiResultShouldBe(double p0) {
        Assert.That(_result, Is.EqualTo(p0)); 
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press Current Defect Density")] 
    public void WhenIHaveEnteredAvalabilityIntoTheCalculator(double p0, double p1)
    {
        _result = _calculator.DefectDensity(p0, p1); 
    }

    [Then(@"the defect density result should be (.*)")]
    public void ThenAvailabilityResultShouldBeOnTheScreen(double p0) {
        Assert.That(_result, Is.EqualTo(p0)); 
    }
}