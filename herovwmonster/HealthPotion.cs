using System;

public class HealthPotion : Item
{
    public int HealAmount = 30;

    public override void Use(Character target)
    {
        target.Heal(HealAmount);
        Console.WriteLine($"{target.Name} использует зелье (+{HealAmount} HP)");
    }
}