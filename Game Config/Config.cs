using  UnityEngine;
public class Config: MonoBehaviour
{
    [SerializeField] private float BORDER_X = 0; 

    public float _borderX
    {
        get { return BORDER_X; }
    }
 
}
