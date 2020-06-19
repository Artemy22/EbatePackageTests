Feature: EBD-214-Edit-Package
	Edit an existing package

@mytag
Scenario: Create packages
	Given Open Chrome browser
	And Navigate to Pricing Management > Packages. 
	And Click the Add button
	And Select a company type Customer
	And Select an Account Type Invoice
	And Select the company
	And Complete the remaining fields
	And Click the Save button
	Then Check if a package has been created