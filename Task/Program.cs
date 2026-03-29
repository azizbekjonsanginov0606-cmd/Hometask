// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using task1;
List<Student> students = new List<Student>
        {
            new Student { Id = 1, FirstName = "Алиҷон", LastName = "Раҳимов", Age = 20, Gender = "Мард", Status = "Фаъол", StartDate = new DateTime(2022, 9, 1), GraduationDate = new DateTime(2026, 6, 30) },
            new Student { Id = 2, FirstName = "Мадина", LastName = "Саидова", Age = 16, Gender = "Зан", Status = "Фаъол", StartDate = new DateTime(2023, 9, 1), GraduationDate = new DateTime(2027, 6, 30) },
            new Student { Id = 3, FirstName = "Парвиз", LastName = "Ҳасанов", Age = 22, Gender = "Мард", Status = "Ғайрифаъол", StartDate = new DateTime(2020, 9, 1), GraduationDate = new DateTime(2024, 6, 30) },
            new Student { Id = 4, FirstName = "Нигора", LastName = "Зарипова", Age = 18, Gender = "Зан", Status = "Фаъол", StartDate = new DateTime(2021, 9, 1), GraduationDate = new DateTime(2025, 6, 30) },
            new Student { Id = 5, FirstName = "Рустам", LastName = "Азизов", Age = 23, Gender = "Мард", Status = "Ғайрифаъол", StartDate = new DateTime(2019, 9, 1), GraduationDate = new DateTime(2023, 6, 30) },
            new Student { Id = 6, FirstName = "Ситара", LastName = "Назарова", Age = 28, Gender = "Зан", Status = "Фаъол", StartDate = new DateTime(2016, 9, 1), GraduationDate = new DateTime(2026, 6, 30) },
            new Student { Id = 7, FirstName = "Азизбек", LastName = "Сангинов", Age = 20, Gender = "Мард", Status = "Фаъол", StartDate = new DateTime(2024, 9, 1), GraduationDate = new DateTime(2038, 6, 30) },
            new Student { Id = 8, FirstName = "Азизчон", LastName = "Азизов", Age = 38, Gender = "Мард", Status = "Фаъол", StartDate = new DateTime(2014, 9, 1), GraduationDate = new DateTime(2032, 6, 30) },
            new Student { Id = 9, FirstName = "Ботур", LastName = "Ниёзов", Age = 15, Gender = "Мард", Status = "Ғайрифаъол", StartDate = new DateTime(2020, 9, 1), GraduationDate = new DateTime(2030, 6, 30) },
            new Student { Id = 10, FirstName = "Носир", LastName = "Салимов", Age = 13, Gender = "Мард", Status = "Фаъол", StartDate = new DateTime(2019, 9, 1), GraduationDate = new DateTime(2029, 6, 30) },
            new Student { Id = 11, FirstName = "Мурод", LastName = "Махмудов", Age = 12, Gender = "Мард", Status = "Фаъол", StartDate = new DateTime(2018, 9, 1), GraduationDate = new DateTime(2028, 6, 30) }
        };
void PrintHeader()
{
    Console.WriteLine(new string('_', 85));
    Console.WriteLine($"{"ID",-5} | {"Ном",-12} | {"Насаб",-15} | {"Синн",-5} | {"Ҷинс",-8} | {"Статус",-10} | {"Санаи оғоз",-12}");
    Console.WriteLine(new string('_', 85));
}

Console.WriteLine("\nTask1");
//  Method Syntax
Console.WriteLine("\n--- Method Syntax (Усули методӣ) ---");
var male = students.Where(a => a.Gender == "Мард").ToList();

PrintHeader();
foreach (var item in male)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}

//  Query Syntax
Console.WriteLine("\n\n--- Query Expression (Усули дархостӣ) ---");
var male2 = (from m in students
             where m.Gender == "Мард"
             select m).ToList();

PrintHeader();

foreach (var item in male2)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}
Console.WriteLine("\nTask2");
//  Method Syntax
Console.WriteLine("\n--- Method Syntax (Усули методӣ) ---");
var status = students.Where(a => a.Status == "Ғайрифаъол").ToList();

PrintHeader();
foreach (var item in status)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}
//  Query Syntax
Console.WriteLine("\n\n--- Query Expression (Усули дархостӣ) ---");
var status2 = (from s in students
               where s.Status == "Ғайрифаъол"
               select s).ToList();

PrintHeader();
foreach (var item in status)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}

Console.WriteLine("\nTask3");
//  Method Syntax
Console.WriteLine("\n--- Method Syntax (Усули методӣ) ---");
var a = students.Where(a => (DateTime.Now.Year - a.Age) > 2000).ToList();

PrintHeader();
foreach (var item in a)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}
//  Query Syntax
Console.WriteLine("\n\n--- Query Expression (Усули дархостӣ) ---");
var a2 = (from s in students
          where (DateTime.Now.Year - s.Age) > 2000
          select s).ToList();

PrintHeader();
foreach (var item in a2)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}

Console.WriteLine("\nTask4");
//  Method Syntax
Console.WriteLine("\n--- Method Syntax (Усули методӣ) ---");
var agestatus = students.Where(s => s.Age > 20 && s.Status == "Фаъол").ToList();

PrintHeader();
foreach (var item in agestatus)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}
//  Query Syntax
Console.WriteLine("\n\n--- Query Expression (Усули дархостӣ) ---");
var agestatus2 = (from s in students
                  where s.Age > 20 && s.Status == "Фаъол"
                  select s).ToList();

PrintHeader();
foreach (var item in agestatus2)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}

Console.WriteLine("\nTask5");
//  Method Syntax
Console.WriteLine("\n--- Method Syntax (Усули методӣ) ---");
var age = students.Where(s => s.Age == 16).ToList();

PrintHeader();
foreach (var item in age)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}
//  Query Syntax
Console.WriteLine("\n\n--- Query Expression (Усули дархостӣ) ---");
var age2 = (from s in students
            where s.Age == 16
            select s).ToList();

PrintHeader();
foreach (var item in age2)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}

Console.WriteLine("\nTask6");
//  Method Syntax
Console.WriteLine("\n--- Method Syntax (Усули методӣ) ---");
var age18 = students.Where(s => s.Age >= 18).ToList();

PrintHeader();
foreach (var item in age18)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}
//  Query Syntax
Console.WriteLine("\n\n--- Query Expression (Усули дархостӣ) ---");
var age18_2 = (from s in students
               where s.Age >= 18
               select s).ToList();

PrintHeader();
foreach (var item in age18_2)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}

Console.WriteLine("\nTask7");
//  Method Syntax
Console.WriteLine("\n--- Method Syntax (Усули методӣ) ---");
var firstName = students.Where(s => s.FirstName.ToLower().StartsWith("а") || s.FirstName.ToLower().StartsWith("i")).ToList();

PrintHeader();
foreach (var item in firstName)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}
//  Query Syntax
Console.WriteLine("\n\n--- Query Expression (Усули дархостӣ) ---");
var firstName2 = (from s in students
                  where s.FirstName.ToLower().StartsWith("а") || s.FirstName.ToLower().StartsWith("i")
                  select s).ToList();

PrintHeader();
foreach (var item in firstName2)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}


Console.WriteLine("\nTask8");
//  Method Syntax
Console.WriteLine("\n--- Method Syntax (Усули методӣ) ---");
var firstName1 = students.Where(s => s.FirstName.ToLower()[0] == s.LastName.ToLower()[0]).ToList();

PrintHeader();
foreach (var item in firstName1)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}
//  Query Syntax
Console.WriteLine("\n\n--- Query Expression (Усули дархостӣ) ---");
var firstName22 = (from s in students
                   where s.FirstName.ToLower()[0] == s.LastName.ToLower()[0]
                   select s).ToList();

PrintHeader();
foreach (var item in firstName22)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}

Console.WriteLine("\nTask9");
//  Method Syntax
Console.WriteLine("\n--- Method Syntax (Усули методӣ) ---");
var ag1 = students.Where(s =>
            s.Age < 18 &&
      (s.Age + (s.GraduationDate.Year - s.StartDate.Year)) >= 18).ToList();

PrintHeader();
foreach (var item in ag1)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}
//  Query Syntax
Console.WriteLine("\n\n--- Query Expression (Усули дархостӣ) ---");
var ag22 = (from s in students
            where s.Age < 18 &&
      (s.Age + (s.GraduationDate.Year - s.StartDate.Year)) >= 18
            select s).ToList();

PrintHeader();
foreach (var item in ag22)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}

Console.WriteLine("\nTask10");
//  Method Syntax
Console.WriteLine("\n--- Method Syntax (Усули методӣ) ---");
var end1 = students.Where(s =>
            s.Age < 16 &&
            s.Gender == "Мард" &&
            s.Status == "Фаъол" &&
      (DateTime.Now.Year - s.StartDate.Year) > 2).ToList();

PrintHeader();
foreach (var item in end1)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}
//  Query Syntax
Console.WriteLine("\n\n--- Query Expression (Усули дархостӣ) ---");
var end2 = (from s in students
            where s.Age < 16 &&
            s.Gender == "Мард" &&
            s.Status == "Фаъол" &&
      (DateTime.Now.Year - s.StartDate.Year) > 2
            select s).ToList();

PrintHeader();
foreach (var item in end2)
{
    Console.WriteLine($"{item.Id,-5} | {item.FirstName,-12} | {item.LastName,-15} | {item.Age,-5} | {item.Gender,-8} | {item.Status,-10} | {item.StartDate,10:dd.MM.yyyy}");
}