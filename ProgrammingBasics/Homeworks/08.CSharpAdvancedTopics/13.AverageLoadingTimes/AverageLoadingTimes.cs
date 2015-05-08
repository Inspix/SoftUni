using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

internal class AverageLoadingTimes
{
    private static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Dictionary<string, SiteValues> info = new Dictionary<string, SiteValues>();
        Console.WriteLine("Enter your data then type \"Done\" when ready...");
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input[0].ToLower() == "done")
            {
                break;
            }
            if (info.ContainsKey(input[2]))
            {
                info[input[2]].TimesLoaded++;
                info[input[2]].LoadingTimes += Convert.ToDouble(input[3]);
            }
            else
            {
                info.Add(input[2], new SiteValues { TimesLoaded = 1, LoadingTimes = Convert.ToDouble(input[3]) });
            }
        }

        foreach (var item in info)
        {
            Console.WriteLine(item.Key + " -> " + (double)item.Value.LoadingTimes / item.Value.TimesLoaded);
        }
    }
}

public class SiteValues
{
    public int TimesLoaded { get; set; }

    public double LoadingTimes { get; set; }
}