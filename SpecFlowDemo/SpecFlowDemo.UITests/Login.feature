Feature: Log in to app

Background:
    Given a started app

Scenario: Olivia logs in to app
    Given the login page is displayed
    When Olivia enters the username Olivia
    And she enters the password IHeartOwls
    And she presses the Logon button
    Then the main page is displayed

Scenario: Olivia uses the wrong password
    Given the login page is displayed
    When Olivia enters the username Olivia
    And she enters the password IHateTrees
    And she presses the Logon button
    Then an invalid username or password message is displayed
