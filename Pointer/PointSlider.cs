using UnityEngine;

public class PointSlider : MonoBehaviour
{
     private float posX = 0f;
    
    [SerializeField] float speedSlider = 0f;
    [SerializeField] float leftBorder = 0f;
    [SerializeField] float RightBorder = 0f;

    [SerializeField] Transform pointer = null;  
    [SerializeField] UIGameSlider gameSlider = null;

    [SerializeField] Config cfg = null;

    private void Awake()
    {
        pointer = GetComponent<Transform>();        
    }

    private void Update()
    {

        if (transform.position.x >= cfg._borderX)
        {
            transform.position = new Vector3(RightBorder, transform.position.y, transform.position.z);
        }
        else
        {
            SlidePointer();
        }

        if(transform.position.x <= -cfg._borderX)
        {
            transform.position = new Vector3(leftBorder, transform.position.y, transform.position.z);
        }
        else
        {
            SlidePointer();
        }
        
    }

    private void SlidePointer()
    {
        float offset = 1 * speedSlider * Time.deltaTime;

        posX = transform.position.x + offset;

        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}
