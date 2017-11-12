Feature: RPNCalc

@mytag
Scenario: Scenario1
	Given User enters "1,2,3,+,-"
	Then the result should be -4 on the screen

Scenario: Scenario2
	Given User enters "6,2,*,3,/"
	Then the result should be 4 on the screen

Scenario: Scenario3
	Given User enters "2,3,^,4,5,+,+"
	Then the result should be 17 on the screen

Scenario: Scenario4
	Given User enters "100,%,2,*"
	Then the result should be 2 on the screen

Scenario: Scenario7
	Given User enters "5,1,2,+,4,*,+,3,-"
	Then the result should be 14 on the screen

