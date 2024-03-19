using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health { get; protected set; }
    public float Cooldown { get; protected set; }
    public float Damage { get; protected set; }
    public bool CanFly { get; protected set; }
    public bool CanStrike { get; protected set; }

    public virtual void TakeDamage(float damage)
    {
    }

    public virtual void GiveDamage(float damage)
    {
    }
}