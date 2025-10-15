using TaskApp.Net6.Models;

namespace TaskApp.Net6.Services;

public interface ITaskService
{
    TaskItem Create(TaskItem task);
}