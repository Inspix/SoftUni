using System;
using System.Collections.Generic;

class ActivityTracker
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedDictionary<int, SortedDictionary<string, double>> activity = new SortedDictionary<int, SortedDictionary<string, double>>();
        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine().Split(new char[]{'/',' '},StringSplitOptions.RemoveEmptyEntries);
            string name = commands[3];
            int month = int.Parse(commands[1]);
            double distance = double.Parse(commands[4]);

            if (activity.ContainsKey(month))
            {
                if (activity[month].ContainsKey(name))
                {
                    activity[month][name] += distance;
                }
                else
                {
                    activity[month].Add(name,distance);
                }
            }
            else
            {
                activity.Add(month, new SortedDictionary<string, double>());
                activity[month].Add(name, distance);
            }
        }

        foreach (var month in activity)
        {
            Console.Write(month.Key + ":");
            int count = activity.Values.Count-1;
            foreach (var user in month.Value)
            {
                if (count == 0)
                {
                    Console.Write("{0}({1})",user.Key,user.Value);
                }
                else
                {
                    Console.Write("{0}({1}), ", user.Key, user.Value);
                }
                count--;
            }
            Console.WriteLine();
        }
    }
}