using UnityEngine;

public class UIItemDrag : MonoBehaviour {
    
    public GameObject item;
    public GameObject itemObject;

    private Vector3 mOffset;

	void Update() {
		if (Input.GetMouseButtonUp(0)) {
			Vector3 camPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Instantiate(itemObject);
			Vector3 mOffset = itemObject.transform.position - camPos;
			Vector3 pos = camPos;// + mOffset;
			itemObject.transform.position = new Vector3(pos.x, pos.y, 0f);
			// Instantiate(itemObject);
			// //Vector3 pos = GetMouseWorldPos(); //item.transform.position; // 
			// itemObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);//itemObject.transform.position;
			// //Debug.Log(itemObject.transform.position + " " + item.transform.position);
			Destroy(item);

		} else {
			Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			item.transform.position = new Vector3(pos.x, pos.y, 0f);
			//Debug.Log(item.transform.position);
		}

		if (Input.GetMouseButtonDown(0)) {
			Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
		}
	}
}
