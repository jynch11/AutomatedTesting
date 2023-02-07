using System;
using TechTalk.SpecFlow;

namespace Calculator.Specs.StepDefinitions
{
    [Binding]
    public class SumOfTwoNumbersStepDefinitions
    {
        private int _result;
        private readonly Calc _calculator = new Calc();


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _calculator.FirstNumber = p0;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            _calculator.SecondNumber = p0;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            _result.Should().Be(result);
        }
    }
}
