using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;

namespace _02.Animals
{
    public class Dog : Animal,ISoundProducible
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public void ProduceSound()
        {
            using (SoundPlayer s = new SoundPlayer())
            {
                s.SoundLocation = "Sounds/dog_bark_x.wav";
                s.PlaySync();
            }
        }

        public override string ToString()
        {
            return base.ToString() + " : " + this.GetType().ToString().Replace("_02.Animals.", "");
        }
    }
}