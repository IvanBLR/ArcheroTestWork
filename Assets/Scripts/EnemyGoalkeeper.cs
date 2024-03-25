using UnityEngine;

public class EnemyGoalkeeper : Enemy
{
    private void Start()
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

    public override void SetPlayer(Player player)
    {
       // base.SetPlayer(player);
        Player = player;
        Debug.Log(Player.transform.position);
        Debug.Log(this.Health);
    }

    public override void Fire()
    {
        Debug.Log("Enemy goalkeeper");
       // Debug.Log(Player.transform.position);
        Debug.Log(base.Health);
        Debug.Log(this.Health);
        Debug.Log(Health);
    }
}