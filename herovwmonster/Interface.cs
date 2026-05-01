public interface IDamageable
{
    void TakeDamage(int amount);
    bool IsAlive { get; }
}

public interface IUsable
{
    void Use(Character target);
}