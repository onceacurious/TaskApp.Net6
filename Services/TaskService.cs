using Microsoft.Extensions.Caching.Memory;
using TaskApp.Net6.Models;

namespace TaskApp.Net6.Services;

public class TaskService:ITaskService
{

    private readonly IMemoryCache _memoryCache;
    private const string CacheKey = "Tasks";

    private readonly MemoryCacheEntryOptions _cacheOptions = new()
    {
        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10), // auto-expire after 10 min
        SlidingExpiration = TimeSpan.FromMinutes(5) // reset the timer if accessed again within 5 min
    };

    public TaskService(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    public TaskItem Create(TaskItem task)
    {
        if (!_memoryCache.TryGetValue(CacheKey, out List<TaskItem>? tasks))
        {
            tasks = new List<TaskItem>();
        }

        task.Id = Guid.NewGuid();
        tasks?.Add(task);

        // Store in cache
        _memoryCache.Set(CacheKey, tasks, _cacheOptions);

        return task;
    }

}