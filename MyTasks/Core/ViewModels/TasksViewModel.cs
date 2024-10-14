using MyTasks.Core.Models;
using MyTasks.Core.Models.Domains;
using Task = MyTasks.Core.Models.Domains.Task;

namespace MyTasks.Core.ViewModels
{
    public class TasksViewModel
    {
        public IEnumerable<Task> Tasks { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public FilterTasks FilterTasks { get; set; }
    }
}
