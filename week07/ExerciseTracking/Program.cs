using System;
namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
            Console.WriteLine();

            Running run1 = new Running ("03 Nov 2022", 30, 3);
            Cycling cycle1 = new Cycling ("04 Nov 2022", 45, 15);
            Swimming swim1 = new Swimming ("05 Nov 2022", 60, 20);

            List<Activity>activities=new List<Activity>();
            activities.Add(run1);
            activities.Add(cycle1);
            activities.Add(swim1);

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
