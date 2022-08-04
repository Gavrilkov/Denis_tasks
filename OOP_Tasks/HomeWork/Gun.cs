using System;
using System.Collections.Generic;

namespace HomeWork
{
    internal class Gun
    {
        public List<string> bullets = new List<string>() { };
        public List<string> bullets1 = new List<string>() { "тросирущий", "холостой", "шумовой", "световой", "светошумовой", "разрывной", "картечь", "запасной", "одниночный", "убойный" };

        public void Shot()
        {
            if (bullets.Count <= 0)
            {
                Console.WriteLine("oops!");
                Console.ReadLine();
                throw new InvalidOperationException("в магазине нет патронов");

            }
            else
            {
                Console.WriteLine("Boom!");
                Console.WriteLine($"произведен выстрел {bullets[0]} патроном");
                bullets.RemoveAt(0);

            }

        }

        public void Reload()
        {
            bullets.AddRange(new[] { "тросирущий", "холостой", "шумовой", "световой", "светошумовой", "разрывной", "картечь", "запасной", "одниночный", "убойный" });
            bullets.Reverse();
            Console.WriteLine("магазин полностью заряжен");
        }

        public void Reload(int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                bullets.Add(bullets1[i]);
            }
            bullets.Reverse();
        }

        public void showBullets()
        {
            Console.WriteLine($"В магазине осталось {bullets.Count} патронов");
        }
    }
}
