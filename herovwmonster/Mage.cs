using System;

public class Mage : Character
{
    public Mage(string name)
        : base(name, 80, 20)
    {
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} бросает заклинание в {target.Name} ({Damage})");
        target.TakeDamage(Damage);

        // шанс захилиться
        if (random.Next(0, 100) < 30)
        {
            Heal();
        }
    }

    public void Heal()
    {
        int healAmount = 15;
        Health += healAmount;
        Console.WriteLine($"✨ {Name} лечит себя на {healAmount} (HP: {Health}/{maxHealth})");
    }
}