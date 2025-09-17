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
            string filePath = "products.json";
            List<Animal> zoo = new List<Animal>
        {
            new Lion("Simba", 5, true),
            new Snake("Polly", 2, true),
            new Parrot("Nagini", 3, "Hello!")
        };

            foreach (var animal in zoo)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
                animal.MakeSound();
            }

            Console.Write("Add animal to the zoo, (L for Lion, P for Parrot, S for Snake): ");
            var type = Console.ReadLine()?.ToUpper();
            do
            {
                if (type == "L" || type == "P" || type == "S") break;
                Console.Write("Invalid input. Please enter L, P, or S: ");
                type = Console.ReadLine()?.ToUpper();
            } while (true);

            Console.Write("Enter animal's name: ");
            var name = Console.ReadLine() ?? "";

            Console.Write("Enter animal's age: ");
            var age = int.TryParse(Console.ReadLine(), out var parsedAge) ? parsedAge : 0;

            Animal newAnimal;
            switch (type)
            {
                case "L":
                    newAnimal = new Lion(name, parsedAge, false);
                    break;
                case "P":
                    newAnimal = new Parrot(name, parsedAge, "Newbie!");
                    break;
                case "S":
                    newAnimal = new Snake(name, parsedAge, true);
                    break;
                default:
                    newAnimal = null;
                    break;
            }

            if (newAnimal != null)
            {
                zoo.Add(newAnimal);
                Console.WriteLine($"{newAnimal.GetType().Name} {newAnimal.Name} has been added to the zoo.");
            }
            else
            {
                Console.WriteLine("Invalid animal type.");
            }
            WriteJsonToFileAsync(filePath, zoo);
        }
         static void WriteJsonToFileAsync(string filePath, List<Animal> newAnimal)
    {
        string json = JsonSerializer.Serialize(newAnimal, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllTextAsync(filePath, json);
    } 
    }
}
