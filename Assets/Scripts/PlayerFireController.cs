using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private UI _uiController;

    private PlayerMovementController _player;

    private float _cooldownTime;
    private float _currentTime;

    private void Start()
    {
        _player = GetComponent<PlayerMovementController>();
        _uiController.GunWasChange += ChangeCurrentBattleSettings;
        _cooldownTime = _uiController.GunsSettings[0].CooldownTime;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (!_player.IsPlayerMoving)
        {
            if (_currentTime >= _cooldownTime)
            {
                _currentTime = 0;
                _particleSystem.Play();
            }
        }
    }

    private void ChangeCurrentBattleSettings(GunsSettings settings)
    {
        _cooldownTime = settings.CooldownTime;
    }

    private void OnDestroy()
    {
        _uiController.GunWasChange -= ChangeCurrentBattleSettings;
    }
}