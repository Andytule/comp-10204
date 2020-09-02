/*
 * Andy Le
 * 000805099
 * Part 1
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class PokemonCard
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public PokemonCard(string name, int healthpoints, string type, string status)
        {
            Name = name;
            HealthPoints = healthpoints;
            Type = type;
            Status = status;
        }

        public override string ToString() => $"Name: {Name} \nHealth Points: {HealthPoints} \nType: {Type} \nStatus: {Status}";
    }
}
