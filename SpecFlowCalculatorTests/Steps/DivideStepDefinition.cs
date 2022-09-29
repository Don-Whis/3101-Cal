using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ICT3101_Calculator; 
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingDivideStepDefinitions
    {
        private double _result;
        private Calculator _calculator;
        //context injection, there isn't any [given] step
        public UsingDivideStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(String p0)
        {
            double p1;
            if (p0 == "positive_infinity")
            {
                p1 = double.PositiveInfinity;
            }
            else
            {
                p1 = double.Parse(p0);
            }
            
            Assert.That(_result, Is.EqualTo(p1));
        }
    }
}