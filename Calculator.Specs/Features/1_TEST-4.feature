@REQ_TEST-4
Feature: Sum and subtraction of two numbers
	#AS A user I can calculate the sum and subtraction of two numbers

	#AS A user I can calculate the sum of two numbers
	@TEST_TEST-5
	Scenario: Test Sum of two numbers
		Given I have entered 1 into the calculator
		And I have also entered 2 into the calculator
		When I press add
		Then the result should be 3 on the screen
	#Tests AS A user I can calculate the sum and subtraction of two numbers
	@TEST_TEST-11
	Scenario: Test Subtraction of two numbers
		Given I have entered 4 into the calculator
		And I have also entered 2 into the calculator
		When I press subtract
		Then the result should be 2 on the screen