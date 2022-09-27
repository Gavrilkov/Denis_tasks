using System;
using System.Collections.Generic;
using System.Text;

namespace LQ
{
    public class Person
    {
        public List<string> Language { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age, List<string> language)
        {
            Name = name;
            Age = age;
            Language = language;
        }
    }
}
