Feature: Product
	In order to validate product header 
	As a user 
	I want be able to click on the link


@product
Scenario: verify the product header
	Given navigate to BMI
	When I click on the product header
	Then I see the product header
	