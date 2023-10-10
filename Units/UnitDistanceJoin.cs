using UnityEngine;

public class UnitDistanceJoin : MonoBehaviour
{
    [Header("Максимальная дистанция")]
    public float joinRadius = 0f;

    [Header("Текущая дистанция")]
    [SerializeField] float distance = 0f;

    [Header("Цель")]
    public Transform target = null;

    private void Awake()
    {        
        target = FindObjectOfType<PlayerMotion>().transform;
    }

    private void Update()
    {
       distance = GetDistanceToTarget();
    }


    public float GetDistanceToTarget()
    {
        float dist = Vector3.Distance(target.position, transform.position);      

        return dist;
    }

}

