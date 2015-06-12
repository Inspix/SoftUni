using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;

namespace _02.Animals
{
    public class Kitten : Cat,ISoundProducible
    {
        
        public Kitten(string name, int age) : base(name, age, "female")
        {
        }

        public void ProduceSound()
        {
            using (SoundPlayer s = new SoundPlayer())
            {
                s.SoundLocation = "Sounds/cat_meow_x.wav";
                s.PlaySync();
            }
        }

        public override string ToString()
        {
            return base.ToString() + " : " + this.GetType().ToString().Replace("_02.Animals.", "");
        }
    }
}