using System;

public class Monster : Character
{
    public Monster(string name, int hp, int dmg) : base(name, hp, dmg) { }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} атакует на {damage}");
        target.TakeDamage(damage);
    }
}