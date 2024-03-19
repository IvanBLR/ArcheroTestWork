using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Action<GunsSettings> GunWasChange;
    
    public List<GunsSettings> GunsSettings => _guns;
    
    [SerializeField] private Button _gunsButton;
    [SerializeField] private GunsSettingsProvider _gunsSettingsProvider;

    private List<GunsSettings> _guns;
    private int _currentGun = 0;
    private int _enumerator = 0;
    private void Awake()
    {
        _guns = _gunsSettingsProvider.GetGunsSettingsList();
        _gunsButton.onClick.AddListener(OnGunsButtonClick);
    }

    private void OnDestroy()
    {
        _gunsButton.onClick.RemoveListener(OnGunsButtonClick);
    }

    private void OnGunsButtonClick()
    {
        _enumerator++;
        _currentGun = _enumerator % _guns.Count;
        Sprite icon = _guns[_currentGun].Icon;
        _gunsButton.image.sprite = icon;
        GunWasChange?.Invoke(_guns[_currentGun]);
    }
}