Feature: CompleteTask

Mark an existing task as completed

@tag1
Scenario: Mark task as complete
	Given the task list is empty
	And I add a task named "Do Laundry"
	When I mark the task "Do Laundry" as complete
	Then the task "Do Laundry" should be marked as complete
