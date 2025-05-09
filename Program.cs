using System;
using System.Collections.Generic;
using System.Linq;

public class Cat
{
    public string Name { get; set; }
    public int Age { get; set; } 
    public DateTime BirthDate { get; set; }
}

public static class Cat_Helecopter
{
    // Поиск кота
    public static List<Cat> Find_Name(List<Cat> cats, string substring)
    {
        return cats.Where(c => c.Name.Contains(substring)).ToList();
    }

    // Поиск самого старого кота
    public static Cat Old_Cat(List<Cat> cats)
    {
        return cats.OrderByDescending(c => c.Age).First();
    }

    // Сортировка котов по дате рождения
    public static List<Cat> Sort_Birth_Date(List<Cat> cats)
    {
        return cats.OrderBy(c => c.BirthDate).ToList();
    }
}

class Program
{
    static void Main()
    {
        List<Cat> cats = new List<Cat>
        {
            new Cat { Name = "Мурка", Age = 3, BirthDate = new DateTime(2020, 5, 10) },
            new Cat { Name = "Котик", Age = 5, BirthDate = new DateTime(2018, 2, 15) },
            new Cat { Name = "Снежок", Age = 2, BirthDate = new DateTime(2021, 7, 3) },
            new Cat { Name = "Ииииигорь", Age = 4, BirthDate = new DateTime(2019, 11, 20) },
            new Cat { Name = "Старый", Age = 1, BirthDate = new DateTime(2022, 1, 5) },
            new Cat { Name = "Карамелька", Age = 7, BirthDate = new DateTime(2016, 8, 12) },
            new Cat { Name = "Компот", Age = 2, BirthDate = new DateTime(2021, 3, 30) },
            new Cat { Name = "Черныш", Age = 3, BirthDate = new DateTime(2020, 9, 17) },
            new Cat { Name = "Сомик", Age = 4, BirthDate = new DateTime(2019, 4, 22) },
            new Cat { Name = "Слоник", Age = 1, BirthDate = new DateTime(2022, 6, 8) }
        };

        Console.WriteLine("Все коты:");
        cats.ForEach(c => Console.WriteLine($"{c.Name}, {c.Age} лет, родился {c.BirthDate:dd.MM.yyyy}"));

        // Содержит ик
        var found_Cats = Cat_Helecopter.Find_Name(cats, "ик");
        Console.WriteLine("\nКоты, в имени есть 'ик':");
        found_Cats.ForEach(c => Console.WriteLine(c.Name));

        // Самый старый
        var oldest_Cat = Cat_Helecopter.Old_Cat(cats);
        Console.WriteLine($"\nСамый старый кот: {oldest_Cat.Name}, возраст: {oldest_Cat.Age} лет");

        // Сначала самый старый
        var sorted_Cats = Cat_Helecopter.Sort_Birth_Date(cats);
        Console.WriteLine("\nКоты, отсортированные по дате рождения:");
        sorted_Cats.ForEach(c => Console.WriteLine($"{c.Name}, {c.BirthDate:dd.MM.yyyy}"));

        Console.ReadLine();
    }
}