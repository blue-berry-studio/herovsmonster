using System;

public class Bomb : Item
{
    public int Damage = 25;

    public override void Use(Character target)
    {
        Console.WriteLine($"💣 {target.Name} кидает бомбу и наносит {Damage} урона врагу!");
    }
}