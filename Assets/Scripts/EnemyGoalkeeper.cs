using System;

public class EnemyGoalkeeper : Enemy
{
    private void Awake()
    {
        Health = 2.5f;
        Damage = 20f;
        Cooldown = 7f;
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