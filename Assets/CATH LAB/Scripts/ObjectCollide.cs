using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectCollide : MonoBehaviour
{


    public GameObject HeldObject;
    public GameObject PlacedObject;
    public int ObjectNum;
    public AudioSource CS;
    public static bool Triggered = false;
    public PlaceableManager myPM;
    // Use this for initialization
    void Start()
    {
        CS = GameObject.FindWithTag("Sound").GetComponent<AudioSource>();
        myPM = GameObject.Find("PlacementOutlines").GetComponent<PlaceableManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPickUp()
    {
        if (!AudioTextCue.AudioPlayer.isPlaying)
        {
            if (ScriptEvent.StageEvent == ObjectNum)
            {
                if (Triggered == false)
                {
                    Triggered = true;
                 
                    if (!CS.isPlaying)
                    {
                        CS.Play();
                    }
                }

            }

        }
    }

    public void OnDrop()
    {
       
               
        
    }
    void OnTriggerStay(Collider col)
    {
        if (!AudioTextCue.AudioPlayer.isPlaying)
        {
            if (ScriptEvent.StageEvent == ObjectNum)
            {
                if (col.gameObject.tag == "Placeable")
                {
                    ScriptEvent.StageEvent = ScriptEvent.StageEvent + 1;
                    
                    PlacedObject.SetActive(true);
                    if (!CS.isPlaying)
                    {
                        CS.Play();
                    }
                    HeldObject.SetActive(false);
                }

            }
        }

    }


}
