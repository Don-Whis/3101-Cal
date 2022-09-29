using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ICT3101_Calculator; 
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public sealed class DefectIntensity
{
    private double _result;
    private Calculator _calculator;
    //context injection, there isn't any [given] step
    public DefectIntensity(Calculator calc)
    {
        this._calculator = calc;
    }

    
    [When(@"I have entered (.*), (.*) and (.*) and press CurrentFailureIntensityLog")]
    public void WhenIHaveEnteredAndAndPressCfiLog(double iniFailInten, double avgExpFailatT, double decay)
    {
        _result = _calculator.CurrentFailureIntensityLog(iniFailInten, avgExpFailatT, decay);
    }


    [Then(@"the failure intensity expected result should be (.*)")]
    public void ThenfailureIntensityResultShouldBe(double p0) {
        Assert.That(_result, Is.EqualTo(p0)); 
    }
    
    [When(@"I have entered (.*), (.*), (.*) and press NumberOfExpectedFailure")]
    public void WhenIHaveEnteredAndPressNumberOfExpectedFailureLog(double iniFailInten, double atT, double decay)
    {
        _result = _calculator.NumberOfExpectedFailure(iniFailInten, atT, decay);
    }


    [Then(@"the failures result should be (.*)")]
    public void ThenNumberOfExpectedFailureResultShouldBeOnTheScreen(double p0) {
        Assert.That(_result, Is.EqualTo(p0)); 
    }
}