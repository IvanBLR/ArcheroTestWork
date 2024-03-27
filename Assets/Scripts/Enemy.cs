using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health => _health;
    public float Damage => _damage;
    public float Cooldown => _cooldown;
    public Player Player => _player;
    public string Name => _name;

    private float _health;
    private float _damage;
    private float _cooldown;
    private Player _player;
    private string _name;

    public void InitializeEnemy(float health, float damage, float cooldown, string name, Player player)
    {
        _health = health;
        _damage = damage;
        _cooldown = cooldown;
        _name = name;
        _player = player;
    }
}