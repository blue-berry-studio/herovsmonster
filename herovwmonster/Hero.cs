using System;

public class Hero
{
    public string Name { get; set; }

    private int health;
    public int Health
    {
        get => health;
        set => health = value < 0 ? 0 : value;
    }

    public int Damage { get; set; }

    public Hero(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void Attack(Monster target)
    {
        Console.WriteLine($"{Name} атакует {target.Name} и наносит {Damage} урона");
        target.TakeDamage(Damage);
    }
}