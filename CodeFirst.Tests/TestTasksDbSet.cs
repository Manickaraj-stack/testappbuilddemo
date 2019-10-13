using System;
using System.Linq;
using CodeFirst.Models;

namespace CodeFirst.Tests
{
    class TestTasksDbSet : TestDbSet<Task>
    {
        public override Task Find(params object[] keyValues)
        {
            return this.SingleOrDefault(task => task.Task_Id == (int)keyValues.Single());
        }
    }
}