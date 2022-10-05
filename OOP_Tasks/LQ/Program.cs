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

            var selectedpeople = people.Where(p => p.Age > 25).OrderBy(p => p.Age);
            foreach (var pers in selectedpeople)
            {
                Console.WriteLine($" {pers.Name}");
            }

            people.Where(p => filterby(p)).OrderByDescending(p => p.Age).ToList().ForEach(p => print(p));

            void print(Person pers)
            {
                Console.WriteLine(pers.Name);
            }

            bool filterby(Person pers)
            {
                if (pers.Age > 25 && pers.Language.Contains("english") && pers.Language.Count < 2)
                    return true;
                else
                    return false;
            }

            List<string> s = new List<string> { "" };
            people.ToList().ForEach(p => printlanguage(p));

            void printlanguage(Person pers)
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
            var selectedPeople2 = people.SelectMany(u => u.Language).Distinct();

            foreach (var pers in selectedPeople2)
            {
                Console.WriteLine(pers);
            }

            var selectedpeople1 = people.SelectMany(p => p.Language,
                                    (person, lang) => new { lang = lang, person1 = person.Name });

            foreach (var pers1 in selectedpeople1)
            {
                Console.WriteLine(pers1);
            }


            Lookup<string, string> selectedpeople3 = (Lookup<string, string>)selectedpeople1.ToLookup(p => p.lang,
                p => p.person1);
            foreach (IGrouping<string, string> pers1 in selectedpeople3)
            {
                Console.WriteLine(pers1.Key);

                foreach (string str in pers1)
                    Console.WriteLine("    {0}", str);
            }
        }
    }
}

