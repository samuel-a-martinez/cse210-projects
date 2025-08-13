using System;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create one of each activity type
        activities.Add(new Running(new DateTime(2025, 8, 12), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2025, 8, 13), 60, 25.0));
        activities.Add(new Swimming(new DateTime(2025, 8, 14), 20, 40));

        // Iterate through the list and display the summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}