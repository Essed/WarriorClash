using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitConnector : MonoBehaviour
{   
   [SerializeField] private int countCollision = 0;

    public delegate void OnConnect();
    public static OnConnect ConnectEvent;


    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerMotion>() && countCollision < 1)
        {
            ConnectEvent();
            countCollision++;
        }
    }
}
