using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PointerController : MonoBehaviour, ISelectHandler, IPointerExitHandler
{
    public GameObject pointer;

    public Transform ButtonPosition1;
    public Transform ButtonPosition2;
    public Transform ButtonPosition3;
    public Button Button1;
    public Button Button2;
    public Button Button3;

    private void Start()
    {
        // Set the initial position of the pointer
        MovePointer(ButtonPosition1.position);
    }

    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log("selected");
      
    }
    public void OnDeselect(BaseEventData eventData)
    {
        Debug.Log("deselected");
    }
    private void MovePointer(Vector3 newPosition)
    {
        // Set the position of the pointer
        if (pointer != null)
        {
            pointer.transform.position = newPosition;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("pointer enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("pointer exit");
    }
}
