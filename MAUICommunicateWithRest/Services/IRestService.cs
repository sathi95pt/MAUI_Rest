using MAUICommunicateWithRest.Models;

namespace MAUICommunicateWithRest.Services
{
    public interface IRestService
    {
        Task<List<TodoItem>> RefreshDataAsync();

        Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

        Task DeleteTodoItemAsync(string id);
    }
}
