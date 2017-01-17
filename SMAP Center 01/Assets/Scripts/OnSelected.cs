using UnityEngine;
using System.Collections;

public class OnSelected : MonoBehaviour {

	private bool isSelected;

	public GameObject playerCamera;
	public GameObject button;
    public GameObject playerController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void clicked(){
		playerCamera.transform.SetParent(this.transform, true);
		
		playerCamera.transform.localPosition = new Vector3(0, 0, 0);
		button.SetActive (true);
		isSelected = true;
	}

	public void detach()
	{
		playerCamera.transform.SetParent (playerController.transform, true);

        playerCamera.transform.localPosition = new Vector3(0, 0, 0);
        playerCamera.transform.localRotation = new Quaternion(0, 0, 0, 0);
		button.SetActive (false);
		isSelected = false;
	}
}
