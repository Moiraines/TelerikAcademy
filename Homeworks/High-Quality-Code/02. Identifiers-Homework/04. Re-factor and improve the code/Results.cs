namespace Mines
{
    public class Results
    {
        private string name;
        private int scores;

        public Results() 
        { 
        }

        public Results(string name, int scores)
        {
            this.Name = name;
            this.Scores = scores;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Scores
        {
            get { return this.scores; }
            private set { this.scores = value; }
        }
    }
}
