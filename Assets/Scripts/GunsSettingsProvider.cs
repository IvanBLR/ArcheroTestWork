using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/GunsSettingsProvider", fileName = "GunsSettingsProvider", order = 52)]
public class GunsSettingsProvider : ScriptableObject
{
    [SerializeField] private List<GunsSettings> _guns;

    public List<GunsSettings> GetGunsSettingsList()
    {
        return _guns;
    }
}