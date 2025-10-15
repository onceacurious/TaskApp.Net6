using Microsoft.AspNetCore.Mvc;
using TaskApp.Net6.Models;
using TaskApp.Net6.Services;

namespace TaskApp.Net6.Controllers;

[ApiController]
[Route("api/tasks")]
public class TaskController:ControllerBase
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_taskService.GetAll());

    [HttpPost]
    public IActionResult Create([FromBody] TaskItem task) => Ok(_taskService.Create(task));
}