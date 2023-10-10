using UnityEngine;

[RequireComponent(typeof(UnitDistanceJoin))]
[RequireComponent(typeof(UnitItems))]
[RequireComponent(typeof(UnitMover))]
[RequireComponent(typeof(UnitConnector))]
public class UnitJoiner : MonoBehaviour
{
    [HideInInspector] public bool isJoin = false;

    private Transform target = null;
    
    private UnitDistanceJoin unitDist = null;
    private UnitItems unitItem = null;

    public delegate void OnJoinUnit();
    public static OnJoinUnit JoinUnitEvent;   
    

    private void Awake()
    {
        target = GetComponent<UnitDistanceJoin>().target;
        unitDist = GetComponent<UnitDistanceJoin>();
        unitItem = GetComponent<UnitItems>();
    }

    private void Update()
    {
         if (unitDist.GetDistanceToTarget() <= unitDist.joinRadius && isJoin == false)
         {
            JoinUnit();
            isJoin = true;
         } 
    }

    private void JoinUnit()
    {
        JoinUnitEvent();
        GetComponent<UnitMover>().enabled = true;
        GetComponent<UnitItems>().enabled = true;
    }

}
