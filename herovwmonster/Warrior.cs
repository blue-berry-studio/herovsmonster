using System;

public class Warrior : Character
{
    public Warrior(string name)
        : base(name, 120, 15)
    {
    }

    public override void Attack(Character target)
    {
        bool crit = random.Next(0, 100) < 25;
        int finalDamage = crit ? Damage * 2 : Damage;

        Console.WriteLine(
            crit
                ? $"💥 {Name} наносит КРИТИЧЕСКИЙ удар по {target.Name} ({finalDamage})"
                : $"{Name} атакует {target.Name} ({finalDamage})"
        );

        target.TakeDamage(finalDamage);
    }
}