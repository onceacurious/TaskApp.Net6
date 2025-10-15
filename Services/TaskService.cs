using Microsoft.Extensions.Caching.Memory;
using TaskApp.Net6.Models;

namespace TaskApp.Net6.Services;

public class TaskService:ITaskService
{

    private readonly IMemoryCache _memoryCache;
    private const string CacheKey = "Tasks";

    public TaskService(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    public List<TaskItem>? GetAll()
    {
        if (!_memoryCache.TryGetValue(CacheKey, out List<TaskItem>? tasks))
        {
            tasks = new List<TaskItem>();
            _memoryCache.Set(CacheKey, tasks);
        }
        return tasks;
    }

    public TaskItem Create(TaskItem task)
    {
        if (!_memoryCache.TryGetValue(CacheKey, out List<TaskItem>? tasks))
        {
            tasks = new List<TaskItem>();
            _memoryCache.Set(CacheKey, tasks);
        }

        task.Id = Guid.NewGuid();
        tasks?.Add(task);
        _memoryCache.Set(CacheKey, task);
        return task;
    }

}