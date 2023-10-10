using UnityEngine;
using UnityEngine.EventSystems;

public class UIGameSlider : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{   

    Vector2 inputVector = Vector2.zero;
    [SerializeField] RectTransform rectPanelScreen = null; 

    public virtual void OnPointerDown(PointerEventData eventData)
    {        
        OnDrag(eventData);
    }

    public virtual void OnDrag(PointerEventData eventData)
    {
        Vector2 pos;

         rectPanelScreen = GetComponent<RectTransform>();

        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(rectPanelScreen, eventData.position, eventData.pressEventCamera, out pos))
        {
            inputVector = new Vector2(pos.x, pos.y);

            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

            rectPanelScreen.anchoredPosition = new Vector2(inputVector.x * (rectPanelScreen.sizeDelta.x / 2), inputVector.y * (rectPanelScreen.sizeDelta.y / 2));
        }

    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {
        inputVector = Vector2.zero;

        rectPanelScreen.anchoredPosition = Vector2.zero;
    }

    
    public float Horizontal()
    {
        if (inputVector.x != 0) return inputVector.x;
        else return Input.GetAxis("Horizontal");
    }

    public float Vertical()
    {
        if (inputVector.y != 0) return inputVector.y;
        else return Input.GetAxis("Vertical");
    }

}
