using Microsoft.AspNetCore.Identity;
using System.Collections.ObjectModel;

namespace MyTasks.Core.Models.Domains
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Tasks = new Collection<Task>();
        }

        public ICollection<Task> Tasks { get; set; }
    }
}
