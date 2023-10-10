using UnityEngine;

public class PointMover : MonoBehaviour
{    
    [SerializeField] float offset = 0;
    [SerializeField] Transform pointer = null;
    [SerializeField] Transform target = null;

    private void Awake()
    {
        pointer = GetComponent<Transform>();    
    }

    private void Update()
    {
        MovePointer();
    }

    private void MovePointer()
    {
        float movementZ = target.position.z + offset - transform.position.z;

        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + movementZ);
    }
}
