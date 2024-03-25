using System;
using UnityEngine;

public class EnemyStriker : Enemy
{
    private void Awake()
    {
        Health = 11f;
        Damage = 0.2f;
        Cooldown = 0.4f;
        CanFly = false;
        CanStrike = true;
        //Debug.Log(Health);
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
        Debug.Log("Enemy striker");
    }
}