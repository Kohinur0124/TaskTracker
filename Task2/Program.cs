namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskTracker<TaskUnit> a = new TaskTracker<TaskUnit>(new List<TaskUnit>
            {
                new TaskUnit("111111","AAAAAA",DateTimeOffset.Now.AddDays(1)),
                new TaskUnit("222222","BBBBBB",DateTimeOffset.Now.AddDays(4)),
                new TaskUnit("333333","CCCCCC",DateTimeOffset.Now.AddDays(-1)),
                new TaskUnit("444444","DDDDDD",DateTimeOffset.Now.AddDays(3)),
                new TaskUnit("555555","EEEEEE",DateTimeOffset.Now.AddDays(-2)),
                new TaskUnit("666666","FFFFFF",DateTimeOffset.Now.AddDays(2)),
            }
            );

            var lastest = a.LastestTasks();
            lastest.ForEach(Console.WriteLine);
            //lastest.Foreach(Console.WriteLine);
        }
    }
}