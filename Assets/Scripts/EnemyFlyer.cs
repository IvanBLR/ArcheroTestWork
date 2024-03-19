using System;

public class EnemyFlyer : Enemy
{
    private void Awake()
    {
        Health = 6f;
        Damage = 10f;
        Cooldown = 1.5f;
        CanFly = true;
        CanStrike = false;
    }
    public override void TakeDamage(float damage)
    {
        Health -= damage;
    }

    public override void GiveDamage(float damage)
    {
        
    }
}