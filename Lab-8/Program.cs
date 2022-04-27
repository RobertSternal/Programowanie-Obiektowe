using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_8
{
    class Program
    {   record Student (int Id, string Name, int Ects);
        static void Main(string[] args)
        {
            int[] ints = { 4, 6, 7, 3, 2, 8, 9 };
            IEnumerable<int> evenNumbers =
                from n in ints
                where !(n % 2 == 0) && n > 5
                select n;
            Console.WriteLine(string.Join(", ", evenNumbers));


            // zapisz linq ktor zwroci liczby wieksze od 5 z ints
            Predicate<int> intPredicate = n =>
            {
                Console.WriteLine("Wywołanie predykau dla " + n);
                return n % 2 == 0;
            };

            evenNumbers =
                from n in ints
                where intPredicate.Invoke(n)
                select n;
            evenNumbers =
                from n in evenNumbers
            where n > 5
            select n * 2;
            Console.WriteLine("Wywołanie ewaluacji wyrazenia LINQ");
            Console.WriteLine(string.Join(", ", evenNumbers));
            Console.WriteLine(evenNumbers.Sum());
            //Oblicz srednia
            Console.WriteLine();
            // ile jest liczb w EvenNumbers
            Console.WriteLine(evenNumbers.Min());
            Student[] students =
            {
                new Student(1, "Ewa", 67),
                new Student(2, "Karol", 66),
                new Student(3, "Ada", 63),
                new Student(4, "Ela", 62),
                new Student(5, "Emu", 61),
            };
            Console.WriteLine("*******************************");
            IEnumerable<string> enumerable =
                from s in students
                orderby s.Ects orderby s.Name descending
                select s.Name + " " + s.Ects;
        Console.WriteLine(string.Join("\n", enumerable));

            //Wyswietl liczby z ints malejaco
            Console.WriteLine(string.Join(", ",
                from i in ints
                orderby i descending
                select i
                ));
            Console.WriteLine(string.Join(", ", ints.OrderByDescending(i => i)));

            //dla identycznych imion kolejnosc ects
            Console.WriteLine(string.Join(", ", students.OrderByDescending(s => s.Name).ThenBy(s => s.Ects)));

            // Grupowanie
            IEnumerable<IGrouping<string, Student>> studentNameGroup =
                from s in students
                group s by s.Name;
            foreach(var item in studentNameGroup)
            {
                Console.WriteLine(item.Key + " " + string.Join(",", item));
            }
            IEnumerable<(string Key, int)> NameCounters = from s in students
            group s by s.Name into groupItem
            select (groupItem.Key, groupItem.Count());
            Console.WriteLine(string.Join(",", NameCounters));

            string str = "ala ma kota ala lubi koty karol lubi psy";
            //oblicz ile razy wystepuje kazde slowo w lancuchu str

            evenNumbers = ints.Where(i => i % 2 == 0).Select(i => i + 2);
            students.Where(s => s.Ects > 20).Select(s => (s.Id, s.Name));

            evenNumbers = ints.Where(i => i % 2 == 0).Select(i => i + 2);
            (int Id, string Name) p = students
                .Where(s => s.Ects > 20)
                .OrderBy(s => s.Id)
                .Select(s => (s.Id, s.Name))
                .FirstOrDefault(s => s.Name.StartsWith("2"));
            Console.WriteLine(p);

           // int[] powerInts = Enumerable
            //    .Range(0, ints.Length);
            //    .Select(ints => ints[i] * ints[i])
            //    .ToArray();
            //Console.WriteLine(string.Join(",", powerInts));
            Random random = new Random();
            random.Next(5);


            int[] randomInts = Enumerable.Range(0, 100).Select(i => random.Next(10)).ToArray();
            int page = 2;
            int size = 3;
            List<Student> pageStudent = students.Skip
        }
    }
}
