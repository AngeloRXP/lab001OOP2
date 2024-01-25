using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{// 1.	Create a class called Person that has the following six attributes:
    public class Person
    {
        //Member variables
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;
        public string Name;

        public int Age
        {
            get { return age; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string FavoriteColour
        {
            get { return favoriteColour; }
        }

        public string Relationship { get; set; }

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
            this.Name = firstName + " " + lastName;
        }
        //Ensure that the Person class has the following methods
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{personId}: {Name}'s favorite colour is {favoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            this.favoriteColour = "white";
        }

        public void GetAgeInTenYears()
        {
            int newAge = this.age + 10;
            Console.WriteLine($"{Name}'s age in 10 years is: {newAge}");
        }

        public override string ToString()
        {
            string relationshipInfo = string.IsNullOrEmpty(Relationship) ? string.Empty : $"Relationship: {Relationship}\n";
            return $"personId: {this.personId}\n" +
                $"firtName: {this.firstName}\n" +
                $"lastName: {this.lastName}\n" +
                $"favoriteColor: {this.favoriteColour}\n" +
                $"age: {this.age}\n" +
                $"isWorking: {this.isWorking}\n" +
                $"{relationshipInfo}";
        }
    }
}
