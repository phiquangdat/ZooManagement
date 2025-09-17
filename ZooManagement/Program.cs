using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ZooManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>
        {
            new Lion { Name = "Simba", Age = 5, IsAlpha = true },
            new Snake { Name = "Polly", Age = 2, IsVenomous = true },
            new Parrot { Name = "Nagini", Age = 3, Vocabulary = "Hello!" }
        };

            foreach (var animal in zoo)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
                animal.MakeSound();
            }

            Console.Write("Add animal to the zoo, (L for Lion, P for Parrot, S for Snake): ");
            var type = Console.ReadLine()?.ToUpper();

            Console.Write("Enter animal's name:");
            var name = Console.ReadLine() ?? "";

            Console.Write("Enter animal's age:");
            var age = int.TryParse(Console.ReadLine(), out var parsedAge) ? parsedAge : 0;

            Animal newAnimal;
            switch (type)
            {
                case "L":
                    newAnimal = new Lion { Name = name, Age = parsedAge, IsAlpha = false };
                    break;
                case "P":
                    newAnimal = new Parrot { Name = name, Age = parsedAge, Vocabulary = "Newbie!" };
                    break;
                case "S":
                    newAnimal = new Snake { Name = name, Age = parsedAge, IsVenomous = false };
                    break;
                default:
                    newAnimal = null;
                    break;
            }

            if (newAnimal != null)
            {
                zoo.Add(newAnimal);
                Console.WriteLine($"{newAnimal.Name} has been added to the zoo.");
            }
            else
            {
                Console.WriteLine("Invalid animal type.");
            }
        }
    }
}
