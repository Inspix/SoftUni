using System.Collections.Generic;

namespace CalculateSequence
{
    public static class Calculations
    {
        public static List<int> QueueSequence(int startNum)
        {
            List<int> result = new List<int>();
            Queue<int> steps = new Queue<int>();
            result.Add(startNum);
            steps.Enqueue(startNum);
            int currentStep = 0;
            while (result.Count < 50)
            {

                if (result.Count % 3 == 1)
                {
                    currentStep = steps.Dequeue();
                }
                int calculation = 0;
                switch (result.Count % 3)
                {
                    case 0:
                        calculation = currentStep + 2;
                        break;
                    case 1:
                        calculation = currentStep + 1;
                        break;
                    case 2:
                        calculation = (currentStep * 2) + 1;
                        break;
                }
                steps.Enqueue(calculation);
                result.Add(calculation);
            }


            return result;
        }
    }
}
