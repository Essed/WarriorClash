using UnityEngine;

public class GameEnder : MonoBehaviour
{
    public delegate void OnEnterZone();
    public static OnEnterZone EnterDeadZoneEvent;

    private int triggerCount = 0;


    private void OnTriggerEnter(Collider other)
    {
        triggerCount++;           
    }
}
