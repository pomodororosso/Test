Feature: RestaurantFinder
	As a user running the application
	I can view a list of restaurants in a user submitted outcode
	So that I know which restaurants are currently available

Background:
	Given I go to the restaurant finder page

# could add a scenario outline instead of 2 distinct tests but IMO it would lose a little clarity.

Scenario: Find Restaurants by valid outcode returns results
	Given I enter "SE19" into the search field
	When I press find
	Then the results should be displayed

Scenario: Find Restaurants by invalid outcode does not return results
	Given I enter "BB8-StarWars" into the search field
	When I press find
	Then the results should not be displayed