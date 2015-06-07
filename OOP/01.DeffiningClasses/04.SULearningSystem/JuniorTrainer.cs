using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.SULearningSystem
{
    public class JuniorTrainer : Trainer
    {
        public JuniorTrainer()
        {
            
        }
        public JuniorTrainer(string name, string lname, int age)
        {
            base.FirstName = name;
            base.LastName = lname;
            base.Age = age;
        }
    }
}
