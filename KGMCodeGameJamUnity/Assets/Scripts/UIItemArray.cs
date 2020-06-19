using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItemArray : MonoBehaviour {

	public Item[] items;
	public Image[] images;

    // Start is called before the first frame update
    void Start() {
        int itemlen = items.Length;
        int imagelen = images.Length;
        //Debug.Log("This level has " + itemlen + " items");
        
        for (int i = 0; i < imagelen; i++) {
        	if (i >= itemlen) {
        		//Debug.Log("Disabled item " + i);
        		images[i].enabled = false;
        	}
        }
    }
}
