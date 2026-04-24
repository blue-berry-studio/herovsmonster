using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Character> heroes = new List<Character>
        {
            new Warrior("Танк"),
            new Mage("Гендальф")
        };

        List<Character> monsters = new List<Character>
        {
            new Monster("Гоблин", 70, 10),
            new Monster("Орк", 100, 12)
        };

        Console.WriteLine("⚔️ Бой начинается!\n");

        while (heroes.Exists(h => h.IsAlive) && monsters.Exists(m => m.IsAlive))
        {
            // Ход героев
            foreach (var hero in heroes)
            {
                if (!hero.IsAlive) continue;

                var target = monsters.Find(m => m.IsAlive);
                if (target == null) break;

                hero.Attack(target);

                if (!target.IsAlive)
                {
                    Console.WriteLine($"☠️ {target.Name} погиб!");
                    hero.GainExperience(30);
                }
            }

            // Проверка после хода
            if (!monsters.Exists(m => m.IsAlive))
                break;

            // Ход монстров
            foreach (var monster in monsters)
            {
                if (!monster.IsAlive) continue;

                var target = heroes.Find(h => h.IsAlive);
                if (target == null) break;

                monster.Attack(target);

                if (!target.IsAlive)
                {
                    Console.WriteLine($"☠️ {target.Name} погиб!");
                }
            }

            Console.WriteLine("\n--- Следующий раунд ---\n");
            Console.ReadLine();
        }

        Console.WriteLine("\n🏁 Бой окончен!");

        if (heroes.Exists(h => h.IsAlive))
            Console.WriteLine("Герои победили!");
        else
            Console.WriteLine("Монстры победили!");
    }
}