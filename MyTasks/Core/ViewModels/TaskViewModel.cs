using MyTasks.Core.Models.Domains;
using Task = MyTasks.Core.Models.Domains.Task;

namespace MyTasks.Core.ViewModels
{
    public class TaskViewModel
    {
        public string Heading { get; set; }
        public Task Task { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
