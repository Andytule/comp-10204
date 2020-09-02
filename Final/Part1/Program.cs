/*
 * Andy Le
 * 000805099
 * Part 1
 * I, Andy Le, 000805099 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PokemonCard> pokeDeck = new List<PokemonCard>
            {
                new PokemonCard("Cubchoo", 70, "Water", "Basic"),
                new PokemonCard("Mareanie", 70, "Psychic", "Basic"),
                new PokemonCard("Rillaboom", 170, "Grass", "Stage 2"),
                new PokemonCard("Ponyta", 60, "Fire", "Basic"),
                new PokemonCard("Charmeleon", 100, "Fire", "Stage 1"),
                new PokemonCard("Charizard", 120, "Fire", "Stage 2")
            };

            Stack<PokemonCard> pokeHand = new Stack<PokemonCard>();
            Random num = new Random();
            for (int i = 0; i < 4; i++)
            {
                pokeHand.Push(pokeDeck[num.Next(0, 6)]);
            }

            foreach (var card in pokeHand)
            {
                Console.WriteLine(card.ToString());
                Console.WriteLine();
            }

            var fireCards = pokeDeck.Where(card => card.Type == "Fire")
                .OrderBy(card => card.Name);
   
            foreach (var card in fireCards)
            {
                Console.WriteLine(card.ToString());
                Console.WriteLine();
            }

            var basicHealth = pokeDeck.Where(card => card.Status == "Basic")
                .Select(card => card.HealthPoints)
                .Aggregate(0, (x, y) => x + y);

            Console.WriteLine(basicHealth);

            var stageTwo = pokeDeck.Where(card => card.Status == "Stage 2")
                .Select(card => new { card.Name, card.Type });

            foreach (var card in stageTwo)
            {
                Console.WriteLine($"Name: {card.Name} % Type: {card.Type}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
