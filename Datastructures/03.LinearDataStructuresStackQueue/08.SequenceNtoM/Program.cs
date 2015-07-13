using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _08.SequenceNtoM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculations.SequencePrint(Calculations.CalculateSequence(10,30)));
        }
    }

    public static class Calculations
    {
        public static Item CalculateSequence(int startNum, int endNum)
        {
            Queue<Item> items = new Queue<Item>();
            items.Enqueue(new Item(startNum,null));
            while (items.Count > 0)
            {
                Item currentItem = items.Dequeue();
                if (currentItem.Value < endNum)
                {
                    items.Enqueue(new Item(currentItem.Value+1,currentItem));
                    items.Enqueue(new Item(currentItem.Value+2,currentItem));
                    items.Enqueue(new Item(currentItem.Value*2,currentItem));
                }
                if (currentItem.Value == endNum)
                {
                    return currentItem;
                }
            }
            return null;
        }

        public static string SequencePrint(Item result)
        {
            if (result == null)
            {
                return "(no solution)";
            }
            List<int> steps = new List<int>();
            while (result != null)
            {
                steps.Add(result.Value);
                result = result.Previous;
                
            }
            steps.Reverse();
            return string.Join(" -> ", steps);
        }
    }
}
