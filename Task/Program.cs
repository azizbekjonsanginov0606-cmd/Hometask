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
while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
    Console.WriteLine("║                МЕНЮИ ВАЗИФАҲОИ LINQ                      ║");
    Console.WriteLine("╠══════════════════════════════════════════════════════════╣");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("║  1. 👤 Танҳо мардҳо                                      ║ ");
    Console.WriteLine("║  2. 🛑 Ғайрифаъолҳо                                      ║ ");
    Console.WriteLine("║  3. 📅 Соли таваллуд > 2000                              ║ ");
    Console.WriteLine("║  4. ✅ Синн > 20 ва Фаъол                                ║ ");
    Console.WriteLine("║  5. 🎂 Синни 16                                          ║ ");
    Console.WriteLine("║  6. 🎓 Калонсолон (18+)                                  ║ ");
    Console.WriteLine("║  7. 🅰️  Ном бо 'А' ё 'I'                                  ║  ");
    Console.WriteLine("║  8. 🔄 Ном ва Насаб бо як ҳарф                           ║ ");
    Console.WriteLine("║  9. 🚀 Калонсол шудан ҳангоми таҳсил                     ║ ");
    Console.WriteLine("║ 10. 🔍 Мард, Фаъол, < 16 ва собиқаи > 2                  ║ ");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"║ {"0. ❌ БАРОМАД",-55} ║");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
    Console.ResetColor();
    
    Console.Write("Интихоб кунед: ");
    string? choice = Console.ReadLine();

    if (choice == "0") break;

    Console.Clear();
    switch (choice)
    {
        case "1": Task1(students); break;
        case "2": Task2(students); break;
        case "3": Task3(students); break;
        case "4": Task4(students); break;
        case "5": Task5(students); break;
        case "6": Task6(students); break;
        case "7": Task7(students); break;
        case "8": Task8(students); break;
        case "9": Task9(students); break;
        case "10": Task10(students); break;
        default: Console.WriteLine("Рақами нодуруст!"); break;
    }

    Console.WriteLine("\n\nБарои баргаштан Enter-ро пахш кунед...");
    Console.ReadLine();
}

// --- ВАЗИФАҲО БО ҲАРДУ УСУЛ ---
void Task1(List<Student> students)
{
    Console.WriteLine("\n[Task 1: Танҳо мардҳо]");
    // Method Syntax
    var res1 = students.Where(s => s.Gender == "Мард").ToList();
    // Query Syntax
    var res2 = (from s in students where s.Gender == "Мард" select s).ToList();

    DisplayCompare(res1, res2);
}

void Task2(List<Student> students)
{
    Console.WriteLine("\n[Task 2: Ғайрифаъолҳо]");
    var res1 = students.Where(s => s.Status == "Ғайрифаъол").ToList();
    var res2 = (from s in students where s.Status == "Ғайрифаъол" select s).ToList();
    DisplayCompare(res1, res2);
}

void Task3(List<Student> students)
{
    Console.WriteLine("\n[Task 3: Соли таваллуд > 2000]");
    var res1 = students.Where(s => (DateTime.Now.Year - s.Age) > 2000).ToList();
    var res2 = (from s in students where (DateTime.Now.Year - s.Age) > 2000 select s).ToList();
    DisplayCompare(res1, res2);
}

void Task4(List<Student> students)
{
    Console.WriteLine("\n[Task 4: Синн > 20 ва Фаъол]");
    var res1 = students.Where(s => s.Age > 20 && s.Status == "Фаъол").ToList();
    var res2 = (from s in students where s.Age > 20 && s.Status == "Фаъол" select s).ToList();
    DisplayCompare(res1, res2);
}

void Task5(List<Student> students)
{
    Console.WriteLine("\n[Task 5: Синни 16]");
    var res1 = students.Where(s => s.Age == 16).ToList();
    var res2 = (from s in students where s.Age == 16 select s).ToList();
    DisplayCompare(res1, res2);
}

void Task6(List<Student> students)
{
    Console.WriteLine("\n[Task 6: Калонсолон (18+)]");
    var res1 = students.Where(s => s.Age >= 18).ToList();
    var res2 = (from s in students where s.Age >= 18 select s).ToList();
    DisplayCompare(res1, res2);
}

void Task7(List<Student> students)
{
    Console.WriteLine("\n[Task 7: Ном бо 'А' ё 'I']");
    var res1 = students.Where(s => s.FirstName.ToLower().StartsWith("а") || s.FirstName.ToLower().StartsWith("i")).ToList();
    var res2 = (from s in students
                where s.FirstName.ToLower().StartsWith("а") || s.FirstName.ToLower().StartsWith("i")
                select s).ToList();
    DisplayCompare(res1, res2);
}

void Task8(List<Student> students)
{
    Console.WriteLine("\n[Task 8: Ном ва Насаб бо як ҳарф]");
    var res1 = students.Where(s => s.FirstName.ToLower()[0] == s.LastName.ToLower()[0]).ToList();
    var res2 = (from s in students where s.FirstName.ToLower()[0] == s.LastName.ToLower()[0] select s).ToList();
    DisplayCompare(res1, res2);
}

void Task9(List<Student> students)
{
    Console.WriteLine("\n[Task 9: Калонсол шудан ҳангоми таҳсил]");
    var res1 = students.Where(s => s.Age < 18 && (s.Age + (s.GraduationDate.Year - s.StartDate.Year)) >= 18).ToList();
    var res2 = (from s in students
                where s.Age < 18 && (s.Age + (s.GraduationDate.Year - s.StartDate.Year)) >= 18
                select s).ToList();
    DisplayCompare(res1, res2);
}

void Task10(List<Student> students)
{
    Console.WriteLine("\n[Task 10: Мард, Фаъол, < 16 ва собиқаи таҳсил > 2]");
    var res1 = students.Where(s => s.Age < 16 && s.Gender == "Мард" && s.Status == "Фаъол" && (DateTime.Now.Year - s.StartDate.Year) > 2).ToList();
    var res2 = (from s in students
                where s.Age < 16 && s.Gender == "Мард" && s.Status == "Фаъол" && (DateTime.Now.Year - s.StartDate.Year) > 2
                select s).ToList();
    DisplayCompare(res1, res2);
}

// --- Ёрирасонҳо ---
void PrintHeader()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(new string('-', 95));
    Console.WriteLine($"{"ID",-5} | {"Исм",-12} | {"Насаб",-15} | {"Синн",-5} | {"Ҷинс",-8} | {"Статус",-10} | {"Санаи оғоз",-12}");
    Console.WriteLine(new string('-', 95));
    Console.ResetColor();
}
void DisplayCompare(List<Student> mSyntax, List<Student> qSyntax)
{
    Console.WriteLine("--- Method Syntax ---");
    PrintList(mSyntax);
    Console.WriteLine("\n--- Query Syntax ---");
    PrintList(qSyntax);
}

void PrintList(List<Student> list)
{
    Console.ForegroundColor = ConsoleColor.Red;
    if (!list.Any()) { Console.WriteLine("Маълумот ёфт нашуд."); return; }
    Console.ResetColor();
    PrintHeader();
    Console.ForegroundColor = ConsoleColor.Green;
    foreach (var s in list)
    {
        Console.WriteLine($"{s.Id,-5} | {s.FirstName,-12} | {s.LastName,-15} | {s.Age,-5} | {s.Gender,-8} | {s.Status,-10} | {s.StartDate:dd.MM.yyyy,}");
    }
    Console.ResetColor();
}