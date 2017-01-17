using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour {

    private bool handFull;
    private GameObject objectHeld;
    public GameObject otherHand;
    private Component otherScript;

    // Use this for initialization
    void Start () {
        handFull = false;
        objectHeld = null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool getHandState()
    {
        return handFull;
    }

    public void holdObj(GameObject thing)
    {

        if (handFull == true && otherHand.GetComponent<HandScript>().handFull == false)
        {
            Debug.Log("Hand is already full! Switching hands...");
            otherHand.GetComponent<HandScript>().holdObj(thing);
            handFull = false;
        }
        else if (otherHand.GetComponent<HandScript>().handFull == true && handFull == true)
        {
            Debug.Log("Both hands are full!");
            dropObj();

        }
        else if ( Vector3.Distance(thing.transform.position, this.transform.position) < 10) { 
            handFull = true;
            objectHeld = thing;

            thing.transform.SetParent(this.transform, true);
            thing.transform.localPosition = new Vector3(0, 2, 0);
            thing.GetComponent<Rigidbody>().isKinematic = true;
            return;
        }
        else
        {
            Debug.Log("Too far to grab");
            return;
        }
    }

    public void dropObj()
    {
        handFull = false;
        objectHeld.transform.SetParent(null);
        objectHeld.GetComponent<Rigidbody>().isKinematic = false;
        objectHeld = null;

    }
}
