using System;
using System.Collections.Generic;

public abstract class Character
{
    public string Name { get; set; }

    protected int maxHealth;
    protected int health;
    public int Health => health;

    protected int damage;
    public int Damage => damage;

    public List<Item> Inventory { get; private set; } = new List<Item>();

    protected static Random random = new Random();

    public Character(string name, int hp, int dmg)
    {
        Name = name;
        maxHealth = hp;
        health = hp;
        damage = dmg;
    }

    public abstract void Attack(Character target);

    public virtual void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0) health = 0;

        Console.WriteLine($"{Name} получает {amount} урона (HP: {health}/{maxHealth})");
    }

    public void Heal(int amount)
    {
        health += amount;
        if (health > maxHealth) health = maxHealth;
    }

    public bool IsAlive => health > 0;

    

    public void AddItem(Item item)
    {
        Inventory.Add(item);
        Console.WriteLine($"{Name} получил: {item.Name}");
    }

    public void ShowInventory()
    {
        if (Inventory.Count == 0)
        {
            Console.WriteLine("Инвентарь пуст");
            return;
        }

        Console.WriteLine("Инвентарь:");
        for (int i = 0; i < Inventory.Count; i++)
        {
            Console.WriteLine($"{i}: {Inventory[i].Name}");
        }
    }

    public void UseItem(int index)
    {
        if (index < 0 || index >= Inventory.Count)
        {
            Console.WriteLine("Неверный выбор");
            return;
        }

        var item = Inventory[index];
        item.Use(this);
        Inventory.RemoveAt(index);
    }
}