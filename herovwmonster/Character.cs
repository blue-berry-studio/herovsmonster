using System;

public abstract class Character
{
    public string Name { get; set; }

    protected int maxHealth;
    protected int health;

    public int Health
    {
        get => health;
        protected set
        {
            if (value < 0) health = 0;
            else if (value > maxHealth) health = maxHealth;
            else health = value;
        }
    }

    protected int damage;
    public int Damage
    {
        get => damage;
        protected set => damage = value < 0 ? 0 : value;
    }

    public int Level { get; private set; } = 1;
    public int Experience { get; private set; } = 0;

    protected static Random random = new Random();

    public Character(string name, int health, int damage)
    {
        Name = name;
        this.maxHealth = health;
        this.Health = health;
        this.Damage = damage;
    }

    public abstract void Attack(Character target);

    public virtual void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name} получает {amount} урона (HP: {Health}/{maxHealth})");
    }

    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"{Name} получает {exp} опыта");

        if (Experience >= Level * 50)
        {
            LevelUp();
        }
    }

    protected virtual void LevelUp()
    {
        Level++;
        Experience = 0;

        maxHealth += 20;
        Damage += 5;
        Health = maxHealth;

        Console.WriteLine($"🔥 {Name} повышает уровень! Теперь уровень {Level}");
    }

    public bool IsAlive => Health > 0;
}