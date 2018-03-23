#features/test.feature
Feature: Running Cucumber with Protractor
    As a user of Protractor
    I should be able to use Cucumber
    In order to run my E2E tests

    Scenario: Protractor and Cucumber Test
        Given I go to "/"
        When I add "xpath express" in the type field and add "Title" in the name field
        When I click the add button
        Then I should see my new task in the list
