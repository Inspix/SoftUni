using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;

namespace _02.Animals
{
    public class Tomcat : Cat,ISoundProducible
    {
        public Tomcat(string name, int age) : base(name, age, "male")
        {
        }

        public void ProduceSound()
        {
            using (SoundPlayer s = new SoundPlayer())
            {
                s.SoundLocation = "Sounds/cat_growl.wav";
                s.PlaySync();
            }
        }

        public override string ToString()
        {
            return base.ToString() + " : " + this.GetType().ToString().Replace("_02.Animals.", "");
        }
    }
}