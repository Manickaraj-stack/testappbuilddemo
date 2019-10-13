using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public interface ITaskManagerContext
    {
        DbSet<Task> Tasks { get; }

        DbSet<ParentTask> ParentTasks { get; }

        int SaveChanges();
    }
}