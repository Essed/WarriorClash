using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrownLeadership : MonoBehaviour
{
    [SerializeField] GameObject pref_Crown = null;

    private void OnEnable() => UnitJoiner.JoinUnitEvent += ActiveLeaderCrown;

    private void OnDisable() => UnitJoiner.JoinUnitEvent -= ActiveLeaderCrown;

    private void ActiveLeaderCrown()
    {
        pref_Crown.SetActive(true);
    }    
}
