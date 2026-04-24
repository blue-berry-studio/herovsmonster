using System;

public class Monster : Character
{
    public Monster(string name, int hp, int dmg)
        : base(name, hp, dmg)
    {
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} кусает {target.Name} ({Damage})");
        target.TakeDamage(Damage);
    }
}