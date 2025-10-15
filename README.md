# Practical Test

## Objective

Develop a **minimal full-stack feature** that demonstrates backend design principles (Model–Service–Controller architecture) and basic frontend integration.
The focus is on building a **clean, maintainable backend** with proper layering, dependency injection, and validation, while exposing a RESTful API consumed by a simple React client.

> **Note:** The project already has a boilerplate setup with React and .NET 6. You can use it as a starting point.

---

## Backend: .NET 6

### Backend Requirements

1. **Implement a Task Management API** using the following endpoints:

   * `GET /api/tasks` – Retrieve all tasks
   * `GET /api/tasks/{id}` – Retrieve a specific task by ID
   * `POST /api/tasks` – Create a new task
   * `PUT /api/tasks/{id}` – Update an existing task
   * `DELETE /api/tasks/{id}` – Remove a task

2. **Model Definition**

   ```csharp
   public class TaskItem
   {
       public Guid Id { get; set; }
       public string Title { get; set; }
       public bool IsCompleted { get; set; }
   }
   ```

3. **Architecture**

   * Follow the **Model–Service–Controller (MSC)** pattern:

     * **Model**: Represents the task entity.
     * **Service**: Manages in-memory storage and encapsulates business logic.
     * **Controller**: Handles HTTP requests and responses.
   * Use **dependency injection** with a *Scoped* service for in-memory data handling.

4. **Validation**

   * Ensure `Title` is required and non-empty.
   * Return appropriate HTTP status codes (e.g., 400 for validation errors, 404 for missing tasks, 200/201 for success).

5. **Bonus (optional)**

   * Add filtering (e.g., `GET /api/tasks?isCompleted=true`).
   * Implement basic logging and error handling middleware.

---

## Frontend: React 18

### Frontend Requirements

1. **TaskList Component**

   * Fetch and display tasks from the backend API.
   * Display each task with a checkbox (for completion) and a title.

2. **Bonus Features**

   * Add a form/button to create new tasks.
   * Add a delete button to remove a task.
   * Allow toggling of the completion status directly from the UI.

---
