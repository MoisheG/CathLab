using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(SteamVR_TrackedObject))]

public class InteractObject : MonoBehaviour
{

   
    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
   // public GameObject Object;
    private GameObject StoredObject;
    private bool OneObject;

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        //ScriptEvent.StageEvent = -2;
    }


    void FixedUpdate()
    {

        device = SteamVR_Controller.Input((int)trackedObj.index);
        //=================================================================
        // When your holding it down
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
           // Debug.Log("Holding Touch");
        }
        //=================================================================
        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
           // Debug.Log("TouchDown");
        }
        //=================================================================
        if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        {
          //  Debug.Log("TouchUp");
        }
        //=================================================================
        //Press is when you hear that "press" sound
        if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            //Debug.Log("Holding Press");
        }
        //=================================================================
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
           // Debug.Log("PressDown");
        }
        //=================================================================
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
           // Debug.Log("PressUp");
        }
        //=================================================================
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
         //   ScriptEvent.StageEvent = -1;
           // Debug.Log("TouchPad");
           // Instantiate(Object, transform.position, transform.rotation);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag != "Placeable")
        {
            // Debug.Log("You have collided with" + col.name + " and activated OnTriggerStay");
            if ((device.GetTouch(SteamVR_Controller.ButtonMask.Trigger) || device.GetPress(SteamVR_Controller.ButtonMask.Touchpad)) && OneObject == false)
            {
                // Debug.Log("You have collided with" + col.name + " while holding down Touch");
                col.attachedRigidbody.isKinematic = true;
                col.gameObject.transform.SetParent(gameObject.transform);
                StoredObject = col.gameObject;
                OneObject = true;
                PlaceableManager.ObjectisHeld = true;
            }
            if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger) || device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
            {

                // Debug.Log("You have released Touch while colliding with " + col.name);
                col.gameObject.transform.SetParent(null);
                col.attachedRigidbody.isKinematic = false;
                OneObject = false;
                PlaceableManager.ObjectisHeld = false;
                // tossObject(col.attachedRigidbody);
            }
        }
       



    }

    //void tossObject(Rigidbody rigidBody)
    //{

    //    Transform origin = trackedObj.origin ? trackedObj.origin : trackedObj.transform.parent;
    //    if (origin != null)
    //    {
    //        rigidBody.velocity = origin.TransformVector(device.velocity);
    //        rigidBody.angularVelocity = origin.TransformVector(device.angularVelocity);
    //    }
    //    else
    //    {
    //        rigidBody.velocity = device.velocity;
    //        rigidBody.angularVelocity = device.angularVelocity;
    //    }



    //}
}
