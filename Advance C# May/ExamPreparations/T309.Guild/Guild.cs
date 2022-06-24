using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    class Guild
    {
        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public List<Player> roster { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => roster.Count;

        public void AddPlayer(Player player)
        {
            if (Capacity >= Count + 1)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            return roster.Remove(roster.FirstOrDefault(x => x.Name == name));
        }

        public void PromotePlayer(string name)
        {
            var player = roster.FirstOrDefault(x => x.Name == name);
            if (player != null && player.Rank != "Member")
            {
                player.Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            var player = roster.FirstOrDefault(x => x.Name == name);
            if (player != null && player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)  
        {
            Player[] removePlayers = roster.FindAll(x => x.Class == @class).ToArray();
            roster.RemoveAll(x => x.Class == @class);
            return removePlayers;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Players in the guild: {Name}");
            for (int i = 0; i < roster.Count; i++)
            {
                result.AppendLine(roster[i].ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}
