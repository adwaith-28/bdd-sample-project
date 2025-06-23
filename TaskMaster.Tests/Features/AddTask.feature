Feature: Task Management

A short summary of the feature

@tag1
Scenario: Add a new task
	Given the task list is empty
	When I add a task named "Buy Milk"
	Then the task list should contain "Buy Milk"
