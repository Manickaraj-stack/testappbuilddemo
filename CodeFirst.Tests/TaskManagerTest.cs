using System.Web.Http.Results;
using CodeFirst.Controllers;
using CodeFirst.Models;
using NBench;
using NUnit.Framework;

namespace CodeFirst.Tests
{
    [TestFixture]
    public class TaskManagerTest
    {
        private Counter _counter;

        [PerfSetup]
        public void Setup(BenchmarkContext context)
        {
            _counter = context.GetCounter("TestCounter");
        }

        [Test]
        [PerfBenchmark(Description = "Test to ensure that a minimal throughput test can be rapidly executed.",
        NumberOfIterations = 1, RunMode = RunMode.Throughput,
        RunTimeMilliseconds = 1000, TestMode = TestMode.Test)]
        [CounterMeasurement("TestCounter")]
        public void GetTasks()
        {
            var context = new TestTaskManagerContext();
            context.Tasks.Add(
                new Task
                {
                    Task_Id = 1,
                    TaskName = "Analysis",
                    ParentTaskParent_Id = 10,
                    Start_Date = "15/10/2019",
                    End_Date = "18/10/2019",
                    Priority = 1,
                    ParentTask = new ParentTask { Parent_Id = 10, Parent_Task = "cache story" }
                });
            context.Tasks.Add(
                new Task
                {
                    Task_Id = 2,
                    TaskName = "Implementation",
                    ParentTaskParent_Id = 10,
                    Start_Date = "19/10/2019",
                    End_Date = "23/10/2019",
                    Priority = 2,
                    ParentTask = new ParentTask { Parent_Id = 10, Parent_Task = "cache story" }
                });
            context.Tasks.Add(
                new Task
                {
                    Task_Id = 3,
                    TaskName = "Testing",
                    ParentTaskParent_Id = 10,
                    Start_Date = "24/10/2019",
                    End_Date = "25/10/2019",
                    Priority = 3,
                    ParentTask = new ParentTask { Parent_Id = 10, Parent_Task = "cache story" }
                });
            context.Tasks.Add(
                new Task
                {
                    Task_Id = 4,
                    TaskName = "Performance testing",
                    ParentTaskParent_Id = 10,
                    Start_Date = "25/10/2019",
                    End_Date = "26/10/2019",
                    Priority = 4,
                    ParentTask = new ParentTask { Parent_Id = 10, Parent_Task = "cache story" }
                });

            var controller = new TasksController(context);
            var result = controller.GetTasks() as TestTasksDbSet;

            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Local.Count);
        }

        [Test]
        [PerfBenchmark(Description = "Test to ensure that a minimal throughput test can be rapidly executed.",
        NumberOfIterations = 1, RunMode = RunMode.Throughput,
        RunTimeMilliseconds = 1000, TestMode = TestMode.Test)]
        [CounterMeasurement("TestCounter")]
        public void AddTask()
        {
            var controller = new TasksController(new TestTaskManagerContext());
            var item = new Task
            {
                Task_Id = 5,
                TaskName = "demo",
                ParentTaskParent_Id = 10,
                Start_Date = "15/10/2019",
                End_Date = "18/10/2019",
                Priority = 1
            };

            var result =
                controller.PostTask(item) as CreatedAtRouteNegotiatedContentResult<Task>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.RouteName, "DefaultApi");
            Assert.AreEqual(result.RouteValues["id"], result.Content.Task_Id);
            Assert.AreEqual(result.Content.TaskName, item.TaskName);
        }

        [PerfCleanup]
        public void Cleanup()
        {
            // does nothing
        }
    }
}
