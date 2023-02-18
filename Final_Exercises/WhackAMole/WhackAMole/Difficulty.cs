namespace WhackAMole
{
    internal class Difficulty
    {
        private string difficulty;
        public Difficulty(string dif)
        {
            difficulty = dif;
        }

        public string GetDifficulty()
        {
            return (difficulty);
        }
    }
}

