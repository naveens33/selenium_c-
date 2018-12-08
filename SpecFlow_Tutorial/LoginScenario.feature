Feature: LoginScenario
	Login with valid and invalid credentials 

#@mytag
#Scenario: Login with valid credential
#	Given Navigate to login page
#	When Enter username, password and click signin 
#	Then Verify user logged in successfully 

#Scenario Outline: Login with invalid credential
#	Given Navigate to login page
#	When Enter <username>, <password> and click signin 
#	Then Verify usern logged in is unsuccessful
#	Examples: 
#	| username   | password |
#	| username | Test@123 |
#	| testuser_2 | Test@153 |

@mytag
Scenario: Login with invalid credential
 Given Navigate to login page
 When enter credentials and click signin
 | username | password  |
 | user     | Test@123  |
 Then Verify usern logged in is unsuccessful