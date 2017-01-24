using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VR = UnityEngine.VR;

public class TouchController : MonoBehaviour
{

    public OVRInput.Controller controller;
    // public OVRPlayerController player;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = OVRInput.GetLocalControllerPosition(controller) + new Vector3(0f, 0.5f, 0f);
        transform.localRotation = OVRInput.GetLocalControllerRotation(controller);
    }
}