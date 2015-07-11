namespace Minesweeper.Game
{
    using System;

    public class Highscore
    {

        private string name;
        private int points;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("The name cannot be empty or null");
                }
                this.name = value;
            }
        }

        public int Points
        {
            get { return this.points; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The player cannot have negative number of points", nameof(Points));
                }
                this.points = value;
            }
        }


        public Highscore()
        {
        }

        public Highscore(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public override string ToString()
        {
            return string.Format("{0} --> {1} cells", Name, Points);
        }
    }
}
