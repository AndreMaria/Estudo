Feature: Running Cucumber with Protractor
    As a user of Protractor
    I should be able to use Cucumber
    In order to run my E2E tests

    Scenario: Protractor and Cucumber Test
        Given I go to "/"
        When I add "válido" in the type field and add "Login" in the name field
        When I click the add button
        Then I should see my new task in the list

