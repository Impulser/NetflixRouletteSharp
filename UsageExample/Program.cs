// ****************************************
// Assembly : NetflixRouletteSharpUsageExample
// File     : Program.cs
// Author   : Alex Camilleri
// ****************************************
// Created  : 25/04/2014
// ****************************************

using System;

using NetflixRouletteSharp;

namespace NetflixRouletteSharpUsageExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("[Title Only] Response: {0}", NetflixRoulette.CreateRequest("Attack on titan"));

            Console.WriteLine("[Title and Year] Response: {0}", NetflixRoulette.CreateRequest("The Boondocks", 2005));

            Console.WriteLine("[Request Object - Title Only] Response: {0}", NetflixRoulette.CreateRequest(new RouletteRequest
            {
                Title = "Breaking Bad"
            }));

            Console.WriteLine("[Request Object - Title and Year] Response: {0}", NetflixRoulette.CreateRequest(new RouletteRequest
            {
                Title = "Cloudy with a Chance of Meatballs",
                Year = 2009
            }));

            Console.ReadLine();
        }
    }
}
