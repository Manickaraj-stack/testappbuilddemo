using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = CodeFirst.Models.Task;

namespace CodeFirst.Tests
{
    class TestTaskManagerContext : TaskManagerContext
    {
        public TestTaskManagerContext()
        {
            this.Tasks = new TestTasksDbSet();
        }

        //public DbSet<Task> Tasks { get; set; }

        public override int SaveChanges()
        {
            return 0;
        }
        public void Dispose() { }
    }
}
