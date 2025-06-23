Feature: Delete Task

Delete a task from the task list

@tag1
Scenario: Delete an existing task
	Given the task list is empty
	And I add a task named "Walk the dog"
	When I delete the task named "Walk the dog"
	Then the task list should not contain "Walk the dog"
