using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Swimming swimming = new Swimming(new DateTime(2025, 06, 14), 62, 84);
        activities.Add(swimming);
        Running running = new Running(new DateTime(2025, 04, 02), 31, 4);
        activities.Add(running);
        Bicycle bicycle = new Bicycle(new DateTime(2025, 04, 03), 64, 21);
        activities.Add(bicycle);

        foreach (Activity activity in activities)
        {
            activity.Summary();
        }
    }
}