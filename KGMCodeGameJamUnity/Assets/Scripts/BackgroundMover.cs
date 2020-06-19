using UnityEngine;

public class BackgroundMover : MonoBehaviour {

	public Transform background;
	public Transform mainCam;

    // Update is called once per frame
    void Update() {
        background.position = new Vector3(mainCam.position.x, mainCam.position.y, background.position.z);
    }
}
