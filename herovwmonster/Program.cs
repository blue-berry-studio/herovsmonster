using System;

//                       __  __                   _    _______    __  ___                 __           
//                      / / / /__  _________     | |  / / ___/   /  |/  /___  ____  _____/ /____  _____
//                     / /_/ / _ \/ ___/ __ \    | | / /\__ \   / /|_/ / __ \/ __ \/ ___/ __/ _ \/ ___/
//                    / __  /  __/ /  / /_/ /    | |/ /___/ /  / /  / / /_/ / / / (__  ) /_/  __/ /    
//                   /_/ /_/\___/_/   \____/     |___//____/  /_/  /_/\____/_/ /_/____/\__/\___/_/     

class Program
{
    static void Main()
    {
        Console.WriteLine("    __  __                   _    _______    __  ___                 __           ");
        Console.WriteLine("   / / / /__  _________     | |  / / ___/   /  |/  /___  ____  _____/ /____  _____");
        Console.WriteLine("  / /_/ / _ \\/ ___/ __ \\    | | / /\\__ \\   / /|_/ / __ \\/ __ \\/ ___/ __/ _ \\/ ___/");
        Console.WriteLine(" / __  /  __/ /  / /_/ /    | |/ /___/ /  / /  / / /_/ / / / (__  ) /_/  __/ /    ");
        Console.WriteLine("/_/ /_/\\___/_/   \\____/     |___//____/  /_/  /_/\\____/_/ /_/____/\\__/\\___/_/     ");

        Warrior hero = new Warrior("Танк");
        Monster monster = new Monster("Гоблин", 80, 10);

        // 🎒 даём предметы
        hero.AddItem(new HealthPotion { Name = "Зелье лечения" });
        hero.AddItem(new Bomb { Name = "Бомба" });

        Console.WriteLine("\n⚔️ Бой начинается!\n");

        while (hero.IsAlive && monster.IsAlive)
        {
            Console.WriteLine("\n1 - Атака | 2 - Предмет");
            string input = Console.ReadLine();

            if (input == "2")
            {
                hero.ShowInventory();
                Console.Write("Выбери предмет: ");

                if (int.TryParse(Console.ReadLine(), out int index))
                {
                    hero.UseItem(index);
                }
            }
            else
            {
                hero.Attack(monster);
            }

            if (!monster.IsAlive)
                break;

            monster.Attack(hero);
        }

        Console.WriteLine("\n🏁 Конец боя");

        if (hero.IsAlive)
            Console.WriteLine("Герой победил!");
        else
            Console.WriteLine("Монстр победил!");
    }
}