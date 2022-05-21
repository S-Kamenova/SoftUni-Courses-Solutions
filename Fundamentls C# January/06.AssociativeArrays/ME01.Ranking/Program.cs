using System;
using System.Linq;
using System.Collections.Generic;

namespace ME01.Ranking
{
    class Program
    {
        public class Ranking
        {
            public Ranking(string contest, string username, int points)
            {
                this.Contest = contest;
                this.Username = username;
                this.Points = points;

            }
            public string Contest { get; set; }
            public string Username { get; set; }
            public int Points { get; set; }
        }
            
        static void Main(string[] args)
        {
            string firstcomand = Console.ReadLine();

            Dictionary<string, string> one = new Dictionary<string, string>();
            Dictionary<string, Ranking> rank = new Dictionary<string, Ranking>();


            
            while (firstcomand!="end of contests")
            {
                string[] token = firstcomand.Split(":");
                string contest = token[0];
                string passContest = token[1];

                one.Add(contest, passContest);
                firstcomand = Console.ReadLine();
            }
            string secondComand = Console.ReadLine();

            while (secondComand!="end of submissions")
            {
                string[] token = secondComand.Split("=>");
                string contest = token[0];
                string password = token[1];
                string username = token[2];
                int points = int.Parse(token[3]);

                if (one.ContainsKey(contest))
                {
                    if (one[contest]==password)
                    {
                        rank.Add(contest, new Ranking(contest, username, points));
                    }
                }
                if (rank.ContainsKey(contest)) 
                {
                    if (rank[contest].Username==username)
                    {
                        if (rank[contest].Points<points)
                        {
                            rank[contest].Points = points;
                        }
                    }
                }

                secondComand = Console.ReadLine();
            }

            Console.WriteLine("Best candidate is {user} with total {total points} points.");

            foreach (var item in rank.OrderBy(x=>x.Value.Username))
            {
                Console.WriteLine(item.Value.Username);

                foreach (var r in rank.OrderByDescending(y=>y.Value.Points))
                {
                    Console.WriteLine($"# {r.Key} -> {r.Value.Points}");
                }
            }

        }
    }
}
