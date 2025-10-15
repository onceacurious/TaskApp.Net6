using TaskApp.Net6.Models;

namespace TaskApp.Net6.Services;

public interface ITaskService
{
    List<TaskItem>? GetAll();
    TaskItem Create(TaskItem task);
}