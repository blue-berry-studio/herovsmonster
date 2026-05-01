using System;

public class Warrior : Character
{
    public Warrior(string name) : base(name, 120, 15) { }

    public override void Attack(Character target)
    {
        int dmg = damage;

        if (random.Next(100) < 25)
        {
            dmg *= 2;
            Console.WriteLine($"💥 КРИТ! {Name} наносит {dmg}");
        }
        else
        {
            Console.WriteLine($"{Name} атакует на {dmg}");
        }

        target.TakeDamage(dmg);
    }
}