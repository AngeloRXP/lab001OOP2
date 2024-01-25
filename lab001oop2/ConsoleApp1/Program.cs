using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab001OOP2
{
    class Program
    {
        //3. Create a Main class
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            person2.Relationship = Relation.ShowRelationShip(Relation.RelationshipType.Sister);
            person1.Relationship = Relation.ShowRelationShip(Relation.RelationshipType.Brother);

            person2.DisplayPersonInfo();
            Console.WriteLine(person3.ToString());
            person1.ChangeFavoriteColour();
            person1.DisplayPersonInfo();
            person4.GetAgeInTenYears();

            Console.WriteLine($"Relationship between {person2.FirstName} and {person4.FirstName} is: {person2.Relationship}");
            Console.WriteLine($"Relationship between {person1.FirstName} and {person3.FirstName} is: {person1.Relationship}");

            List<Person> peopleList = new List<Person> { person1, person2, person3, person4 };
            
            double averageAge = peopleList.Average(persona => persona.Age);
            Console.WriteLine($"Average age is: {averageAge}");

            var youngestPerson = peopleList.OrderBy(personal => personal.Age).First();
            var oldestPerson = peopleList.OrderByDescending(persona => persona.Age).First();
            Console.WriteLine($"The youngest person is: {youngestPerson.FirstName}");
            Console.WriteLine($"The oldest person is: {oldestPerson.FirstName}");

            var peopleWithM = peopleList.Where(persona => persona.FirstName.StartsWith('M')).ToList();

            foreach (var person in peopleWithM)
            {
                Console.WriteLine(person.ToString());
            }

            var personWithBlueColor = peopleList.Find(persona => persona.FavoriteColour == ("Blue"));
            Console.WriteLine($"{personWithBlueColor?.ToString()}");
        }
    }
}
