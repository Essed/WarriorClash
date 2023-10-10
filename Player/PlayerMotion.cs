using UnityEngine;

public class PlayerMotion : MonoBehaviour
{  
    [SerializeField] float moveSpeed = 0;
    [SerializeField] float sensivity = 0;

    public Transform target = null;

    Rigidbody me;

    Vector3 direction = Vector3.zero;


    private void Start()
    {
        me = GetComponent<Rigidbody>();
    }

    private void Update()
    {       
        RotatePlayer();        
               
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 direction = (target.position - transform.position);

        me.velocity = direction * moveSpeed * Time.fixedDeltaTime;
    }

    private void RotatePlayer()
    {
        Vector3 direction = (target.position - transform.position).normalized;      

        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));

        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * sensivity);
    }
}
