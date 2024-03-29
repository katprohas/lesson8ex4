using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }
    public static void Main()
    {
        IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
     };

        // a) Retrieve people with birthdates after 1900
        var birthdates = from s in stemPeople
                         where s.BirthYear > 1900
                         select s;
        Console.WriteLine("People with birth years after 1900: ");
        foreach (var b in birthdates)
        {
            Console.Write($"{b.Name}: ");
            Console.WriteLine(b.BirthYear);
        }

        // b) Retrieve people who have two lowercase L's in their name
        Console.WriteLine();
        var twoLs = from l in stemPeople
                    where l.Name.Contains("ll")
                    select l;
        Console.WriteLine("People with two 'l's in their name: ");
        foreach (var l in twoLs)
        {
            Console.WriteLine($"{l.Name}");
        }

        // c) Count the number of people with birthdays after 1950
        Console.WriteLine();
        var bdayCount = (from bday in stemPeople
                        where bday.BirthYear > 1950
                        select bday).Count();
        Console.WriteLine("Printing number of people with birthdays after 1950: ");

            Console.WriteLine($"{bdayCount}");

        // d) Retrieve people with birth years between 1920 and 2000. Display their names and count the number of people in the list, then display the count.
        Console.WriteLine();
        var limitedBdayRangeCount = (from bdayCountRange in stemPeople
                                     where bdayCountRange.BirthYear > 1920
                                     where bdayCountRange.BirthYear < 2000
                                     select bdayCountRange).Count();
        Console.WriteLine($"There are {limitedBdayRangeCount} with birthdays between 1920 and 2000.");
        var limitedBdayRange = (from bdayCountRange in stemPeople
                                where bdayCountRange.BirthYear > 1920
                                where bdayCountRange.BirthYear < 2000
                                select bdayCountRange);
        Console.WriteLine($"People with birthdays bewteen 1920 and 2000: ");
        foreach (var r in limitedBdayRange)
        {
            Console.WriteLine(r.Name);
        }

        // e) Sort the list by BirthYear
        Console.WriteLine();
        var birthYearSort = from sp in stemPeople
                            orderby sp.BirthYear
                            select sp;
        Console.WriteLine("People sorted by birth year: ");
        foreach(var r in birthYearSort)
        {
            Console.WriteLine($"{r.Name} ({r.BirthYear})");
        }
        // f) Retrieve people with a death year after 1960 and before 2015, sort the list by name in ascending order.
        Console.WriteLine();
        var deathYear = from d in stemPeople
                        where d.DeathYear > 1960
                        where d.DeathYear < 2015
                        orderby d.Name
                        select d;
        Console.WriteLine("People with death year between 1960 and 2015, sorted by name: ");
        foreach (var r in deathYear)
        {
            Console.WriteLine(r.Name);
        }


    }
}
