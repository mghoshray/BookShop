Feature: BookShopFeatures

@mytag
Scenario Outline: Calculate the price of shopping basket
	Given I have entered <harrypottercopies> copy of a Harry Potter book and <othercopies> into the shopping basket
	When I check the shoping basket for <discount>
	Then the total price of the basket would be <totalprice> pounds


Examples:
| harrypottercopies | othercopies | discount | totalprice |
| 1                 | 0           | 0        | 7          |
| 2                 | 0           | 5        | 13.30      |
| 3                 | 0           | 10       | 18.90      |
| 4                 | 0           | 20       | 22.40      |
| 7                 | 0           | 25       | 36.75      |
| 2                 | 1           | 5        | 20.30      |
| 14                | 0           | 25       | 85.75      |
| 0                 | 3           | 0        | 21         |