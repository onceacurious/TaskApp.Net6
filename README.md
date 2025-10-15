#  Practical Test

Objective: Implement a simple feature that integrates both frontend and backend.
The candidate should demonstrate the ability to use the full stack with Model-Controller-Service.

## Backend: .NET 6
**Requirements:**
1. Implement a RESTful API endpoint to manage tasks (Task: ID, Title, IsCompleted):
    - GET /api/tasks
    - POST /api/tasks
    - PUT /api/tasks/{id}
    - DELETE /api/tasks/{id}
    - GET /api/tasks/{id}
2. Store tasks in in-memory using a Scoped service.
3. Add basic validation (e.g. title cannot be empty).

## Frontend: React 18
**Requirements:**
1. Create a TaskList component that displays the list of tasks.
    - Fetch the tasks from the RESTful API endpoint.
    - Display a task with a checkbox and a title.
2. **Bonus**:
    - Add a button to add a new task.
    - Add a button to delete a task.
    - Allow a user to mark a task as completed.