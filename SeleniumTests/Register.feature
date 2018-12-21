Feature: Register
	In order to be able to login
	I want to register 

@Register
Scenario Outline: User Register
	Given the user accesses the site
	When I insert the username <UserName> and password <Password>
	And I click on register button
	Then my account must be created and username must be shown <UserName> on the screen
	Examples: 
	| UserName | Password |
	| caio     | 123456   |
	| bruno    | 654321   |