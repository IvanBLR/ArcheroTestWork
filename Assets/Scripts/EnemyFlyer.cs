using System;
using UnityEngine;

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

    public override void SetPlayer(Player player)
    {
        Player = player;
    }

    public override void Fire()
    {
      //  Debug.Log($"Distance = {Vector3.Distance(transform.position, PlayerPrefab.transform.position)}");
        Debug.Log("Enemy flyer");
    }
}