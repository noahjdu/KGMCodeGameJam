using UnityEngine;
using UnityEngine.EventSystems;

public class UIItemCreate : MonoBehaviour, IPointerDownHandler {

	public GameObject item;

	public void OnPointerDown(PointerEventData pointerEventData) {
		Vector3 camPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Instantiate(item);
		Vector3 mOffset = item.transform.position - camPos;
		Vector3 pos = camPos + mOffset;
		item.transform.position = new Vector3(pos.x, pos.y, 0f);
		//Debug.Log(ScreenToWorldPoint(item.transform.position));
    }
}
