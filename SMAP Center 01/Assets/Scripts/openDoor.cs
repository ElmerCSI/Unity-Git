using UnityEngine;
using System.Collections;

public class openDoor : MonoBehaviour {

	public GameObject rotateAround;
	private bool isClicked;
	// Use this for initialization
	void Start () {
		isClicked = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClicked(){

		if (isClicked == false) {
			this.transform.RotateAround (rotateAround.transform.position, Vector3.up, 90);
			isClicked = true;
		} 
		else if (isClicked == true) {
			this.transform.RotateAround (rotateAround.transform.position, Vector3.up, 270);
			isClicked = false;
		}
	}
}
