using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ActivityTracker
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<User> names = new List<User>();
        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine().Split(new char[]{'/',' '},StringSplitOptions.RemoveEmptyEntries);
            string name = commands[3];
            int month = int.Parse(commands[1]);
            double distance = double.Parse(commands[4]);

            int x = names.FindIndex(s => s.Name == name);
            if (x == -1)
            {
                names.Add(new User(name, month,distance));
            }
            else
            {
                if (names[x].Distance.ContainsKey(month))
                {
                    names[x].Distance[month] += distance;
                }
                else
                {
                    names[x].Distance.Add(month, distance);
                }
            }
        }
        Dictionary<int, List<string>> results = new Dictionary<int, List<string>>();

        foreach (User user in names.OrderBy(s => s.Name))
        {
            foreach (KeyValuePair<int,double> pair in user.Distance)
            {
                if (results.ContainsKey(pair.Key))
                {
                    results[pair.Key].Add(string.Format("{0}({1})", user.Name, pair.Value));
                }
                else
                {
                    results.Add(pair.Key, new List<string> { string.Format("{0}({1})", user.Name, pair.Value) });
                }
            }
        }
        foreach (var item in results.OrderBy(s => s.Key))
        {
            Console.WriteLine(item.Key + ": " + string.Join(", ", item.Value));
        }
    }
}
class User
{
    public string Name { get; set; }
    public Dictionary<int,double> Distance { get; set; }

    public User(string name, int month, double distance)
    {
        Name = name;
        Distance = new Dictionary<int, double>();
        Distance.Add(month, distance);
    }

    public void AddDistance(int month,double distance)
    {
        if (Distance.ContainsKey(month))
        {
            Distance[month] += distance;
        }
        else
        {
            Distance.Add(month, distance);
        }
    }
}