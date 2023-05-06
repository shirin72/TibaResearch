using FluentAssertions;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        private readonly ScenarioContext _senarioContext;
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext senarioContext)
        {
            _senarioContext = senarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int first)
        {
            _calculator.FirstNumber = first;
        }


        [Given(@"I also have entered (.*) into the calculator")]
        public void GivenIAlsoHaveEnteredIntoTheCalculator(int second)
        {
            _calculator.SecondNumber = second;
        }

        [When(@"I press add button")]
        public void WhenIPressAddButton()
        {
            _result = _calculator.Divide();
        }

        [Then(@"the result must be (.*) on the screen")]
        public void ThenTheResultMustBeOnTheScreen(int result)
        {
            _result.Should().Be(result);
        }




    }
}