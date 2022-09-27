using System;
using System.Collections.Generic;
using System.Linq;

namespace LQ
{
    //1. выбери всех людей старше 25 лет и отсортировать по старшинству
    //2. выведи только имена людей которые старше 25 лет и говорят на английском и отсортировать по убыванию возраста
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
{
    new Person ("Tom", 23, new List<string> {"english", "german"}),
    new Person ("Bob", 27, new List<string> {"english", "french" }),
    new Person ("Sam", 29, new List<string>  { "english", "spanish" }),
    new Person ("Greg", 39, new List<string>  { "english" }),
    new Person ("Alice", 24, new List<string> {"spanish", "german" })
};

            var selectedPeople = people.Where(p => p.Age > 25).OrderBy(p => p.Age);
            foreach (var pers in selectedPeople)
            {
                Console.WriteLine($" {pers.Name}");
            }

            people.Where(p => Filterby(p)).OrderByDescending(p => p.Age).ToList().ForEach(p => Print(p));

            void Print(Person pers)
            {
                Console.WriteLine(pers.Name);
            }

            bool Filterby(Person pers)
            {
                if (pers.Age > 25 && pers.Language.Contains("english") && pers.Language.Count < 2)
                    return true;
                else
                    return false;
            }

            List<string> s = new List<string> { "" };
            people.ToList().ForEach(p => PrintLanguage(p));

            void PrintLanguage(Person pers)
            {
                for (int i = 0; i < pers.Language.Count; i++)
                {
                    if (s.Contains(pers.Language[i])) { }

                    else
                    {
                        Console.WriteLine(pers.Language[i]);
                        s.Add(pers.Language[i]);
                    }
                }
            }
        }
    }
}
