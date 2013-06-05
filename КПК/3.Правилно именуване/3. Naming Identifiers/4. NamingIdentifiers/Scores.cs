using System;
using System.Linq;

namespace Mines
{
    public class Scores
    {
           private string name;
		   private	int score;

			public string Name
			{
				get { return name; }
				set { name = value; }
			}

			public int Score
			{
				get { return score; }
				set { score = value; }
			}

			public Scores() { }

            public Scores(string name, int score)
			{
				this.name = name;
				this.score = score;
			}
    }
}
