using NUnit.Framework; 
using System; 
using TechTalk.SpecFlow; 
using ICT3101_Calculator; 
using NUnit.Framework;

 
namespace SpecFlowCalculatorTests.StepDefinitions
{ 
    [Binding] 
    public class UsingCalculatorBasicReliabilityStepDefinitions 
    { 
        private double _result; 
        //Context Injection for SpecFLow: 
        private Calculator _calculator; 
        public UsingCalculatorBasicReliabilityStepDefinitions(Calculator calc) 
        { 
            this._calculator = calc; 
        } 
        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press Current Failure Intensity")] 
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressCurrentFailureIntensity(double p0, double p1, double p2) 
        { 
            _result = _calculator.CurrentFailureIntensity(p0, p1, p2); 
        } 
 
        [Then(@"the  result should be (.*)")] 
        public void ThenTheResultShouldBe(double p0) 
        { 
            Assert.That(_result, Is.EqualTo(p0)); 
        } 
 
        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press Average Number of Expected Failure")] 
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressAverageNumberOfExpectedFailure(double p0, double p1, double p2) 
        { 
            _result = _calculator.failureAtTime(p0, p1, p2); 
        } 
    } 
}