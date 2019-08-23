using System;
using System.Collections.Generic;

namespace HomeWork_3
{
    // Tasks 1 and 2
    public class PersonManager
    {
        private readonly List<Person> people = new List<Person>()
        {
            new Person(){ Name="John", Age=21, PhoneNumbers=new List<string>() { "0971111111", "0972222222", "0973333333" } },
            new Person(){ Name="Jack", Age=18, PhoneNumbers=new List<string>() { "0974444444", "0975555555", "0976666666" } },
            new Person(){ Name="Bob", Age=45, PhoneNumbers=new List<string>() { "0977777777", "0978888888", "0979999999" } },
            new Person(){ Name="Mike", Age=42, PhoneNumbers=new List<string>() { "0974526735", "0973576368", "0974386320" } },
            new Person(){ Name="Harvi", Age=100, PhoneNumbers=new List<string>() { "0976583953", "0975426535", "0973333567" } },
            new Person(){ Name="Abraham", Age=35, PhoneNumbers=new List<string>() { "0971176983", "0972242639", "0973433877" } },
            new Person(){ Name="Nill", Age=19, PhoneNumbers=new List<string>() { "0971167411", "0972867222", "0973796333" } }
        };

        // Task 1
        public void DisplayAgeAndName()
        {
            foreach (var p in people)
            {
                Console.WriteLine($"Name: {p.Name}  Age: {p.Age}");
            }
        }

        // Task 2
        public void UseAddRangeMethodAndDisplay()
        {
            Person[] twoPeopleMore = new Person[2];
            twoPeopleMore[0] = new Person() { Name = "Alex", Age = 25, PhoneNumbers = new List<string>() { "0971435911", "0972254322", "0973335433" } };
            twoPeopleMore[1] = new Person() { Name = "Andrew", Age = 33, PhoneNumbers = new List<string>() { "0971563511", "0975635222", "0973337685" } };

            people.AddRange(twoPeopleMore);

            foreach (var p in people)
            {
                foreach (var number in p.PhoneNumbers)
                {
                    Console.Write(number + ' ');
                }
                Console.WriteLine();
            }
        }
    }
}
