using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Units/Counter", fileName = "New Counter")]
public class UnitsCounter : ScriptableObject
{
    [SerializeField] private int unitCount;

    private void OnEnable() => UnitConnector.ConnectEvent += CountUnits;

    private void OnDisable() => UnitConnector.ConnectEvent -= CountUnits;

    private void CountUnits()
    {
        unitCount++;
    }
}
