using System;
using System.Collections.Generic;
using System.IO;

namespace adv_csharp_animals
{
    internal class Program
    {
        private static readonly AnimalService AnimalService = new AnimalService();
        
        public static void Main(string[] args)
        {
            HandleZoo();
            HandleIO();
        }

        private static void PrintOut(Talkable talkable)
        {
            Console.WriteLine($"{talkable.Name} says={talkable.Talk()}");
        }

        private static void HandleZoo()
        {
            var zoo = new List<Talkable>();
            
            zoo.Add( new Dog()
            {
                Name = "Bean",
                Friendly = true
            });
            zoo.Add( new Cat()
            {
                Name = "Charlie",
                MiceKilled = 9
            });
            zoo.Add( new Teacher()
            {
                Name = "Stacy Read",
                Age = 44
            });
            
            var animal = AnimalService.CreateAnimal();

            if (animal != null)
            {
               zoo.Add(animal);
            }

            foreach (var t in zoo)
            {
                PrintOut(t);
            }
        }
        private static void HandleIO()
        {
            InputFile inFile = new InputFile("animals.txt");
            inFile.ReadEntireFile();
            OutputFile outFile = new OutputFile("animals.txt");
            outFile.WriteNewLine("Test | Test");


            inFile.IterateLines();
            // Doing something like this seems not very smart to me. I would rather just create specific methods for what I want to do.
            // Handling StreamReader and StreamWriter to be opened and closed with a method seems to be a bad way to do things and can lead to I/O errors.
            /*InputFile inData = new InputFile("animals.txt");

            String line;
            while ((line = inData.ReadFileLine()) != null)
            {
                Console.WriteLine(line);
            }*/
        }
    }
}