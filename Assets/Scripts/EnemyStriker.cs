using System;

public class EnemyStriker : Enemy
{
    private void Awake()
    {
        Health = 11f;
        Damage = 0.2f;
        Cooldown = 0.4f;
        CanFly = false;
        CanStrike = true;
    }
    public override void TakeDamage(float damage)
    {
        Health -= damage;
    }

    public override void GiveDamage(float damage)
    {
        
    }
}