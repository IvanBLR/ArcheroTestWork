using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GunsSettings", menuName = "ScriptableObjects/GunsSettings", order = 51)]
public class GunsSettings : ScriptableObject
{
    public string Name => _name;
    public int Damage => _damage;
    public float CooldownTime => _cooldownTime;
    public Sprite Icon => _icon;
    
    [SerializeField] private string _name;
    [SerializeField] private int _damage;
    [SerializeField] private float _cooldownTime;
    [SerializeField] private Sprite _icon;
}