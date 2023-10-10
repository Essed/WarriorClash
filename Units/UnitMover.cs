using UnityEngine;

public class UnitMover : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    [SerializeField] private float sensivity = 0f;
    [SerializeField] private Transform moveTarget = null;
    [SerializeField] private Transform loockTarget = null;

    private Vector3 direction = Vector3.zero;

    private UnitDistanceJoin unitDistance = null;

    Rigidbody unitRb; 

    private void Start()
    {
        unitRb = GetComponent<Rigidbody>();
        unitDistance = GetComponent<UnitDistanceJoin>();        
    }

    private void Update()
    {        
        LoockToTarget();                 
    }

    private void FixedUpdate()
    {
        if (transform.position.z < moveTarget.position.z)
        { 
            direction = moveTarget.position - transform.position;

            MoveToTarget(direction);
        }
        else
        {
            direction = transform.forward;

            MoveToTarget(direction);
        }

    }

    private void MoveToTarget(Vector3 direction)
    {
        unitRb.velocity = direction * speed * Time.fixedDeltaTime;
    }

    private void LoockToTarget()
    {
        Vector3 direction = (loockTarget.position - transform.position).normalized;

        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));

        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * sensivity);
    }

}
