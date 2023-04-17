using System;
using System.IO;

namespace adv_csharp_animals
{
    public class AnimalService
    {
        public Talkable CreateAnimal()
        {
            var animal = new Animal();
            var name = GetResponse("What type of animal would you like to create?");
            var speech = GetResponse("What does this animal normally say?");
            var uniqueAbility = GetResponse("What is unique about this animal?");
            if (uniqueAbility != null && name != null && speech != null)
            {
                animal.Name = name;
                animal.Speech = speech;
                animal.UniqueAbility = uniqueAbility;
            }

            return animal;
        }
        private void IsInvalidResponse(string response)
        {
            if (response == "")
            {
                Console.WriteLine("Please enter a valid response.");
            }
        }

        private string GetResponse(string prompt)
        {
            string response = "";
            while (response == "")
            {
                Console.WriteLine(prompt);
                try
                {
                    response = Console.ReadLine();
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Error getting response: " + e);
                    response = null;
                }

                IsInvalidResponse(response);
            }

            return response;
        }
    }
}