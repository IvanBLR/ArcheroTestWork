using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health { get; protected set; }
    public float Cooldown { get; protected set; }
    public float Damage { get; protected set; }
    public bool CanFly { get; protected set; }
    public bool CanStrike { get; protected set; }

    public Player Player { get; protected set; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            Fire();
    }

    public virtual void TakeDamage(float damage)
    {
    }

    public virtual void GiveDamage(float damage)
    {
    }

    public virtual void SetPlayer(Player player)
    {
    }

    public virtual void Fire()
    {
//        Debug.Log($"Distance = {Vector3.Distance(transform.position, PlayerPrefab.transform.position)}");
    }
}