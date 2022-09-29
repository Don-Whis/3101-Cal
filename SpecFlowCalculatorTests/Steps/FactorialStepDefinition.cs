using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ICT3101_Calculator; 
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions{

    [Binding]
    public class UsingCalculatorFactorialStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private double _result;
        private Calculator _calculator;
        //context injection, there isn't any [given] step
       
        public UsingCalculatorFactorialStepDefinition(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(double p0)
        {
            _result = _calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}