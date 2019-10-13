namespace CodeFirst.Migrations
{
    using CodeFirst.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.Models.TaskManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.Models.TaskManagerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.ParentTasks.AddOrUpdate(x => x.Parent_Id,
                    new ParentTask() { Parent_Id = 1, Parent_Task = "Complete FSD" });

            context.Tasks.AddOrUpdate(x => x.Task_Id,
                    new Task() { Task_Id = 10, ParentTaskParent_Id = 1, TaskName = "Complete assignments", Start_Date = "8/2/2019", End_Date = "10/25/2019", Priority = 1 },
                    new Task() { Task_Id = 11, ParentTaskParent_Id = 1, TaskName = "Complete capsule", Start_Date = "8/2/2019", End_Date = "10/25/2019", Priority = 2 },
                    new Task() { Task_Id = 12, ParentTaskParent_Id = 1, TaskName = "Complete sba", Start_Date = "8/2/2019", End_Date = "10/25/2019", Priority = 3 }
                    );
        }
    }
}
