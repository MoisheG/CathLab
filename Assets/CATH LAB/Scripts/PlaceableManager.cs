using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceableManager : MonoBehaviour {

    public GameObject[] PlaceableOutlines;
    public static bool ObjectisHeld = false;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {



      }


    public void TurnOnHighlight(int s)    
    {
       
        if (s == ScriptEvent.StageEvent)
        {
            PlaceableOutlines[s].SetActive(true);
        }
    }
    public void TurnOffHighlight(int s)
    {
        if (s == ScriptEvent.StageEvent - 1)
        {           
            PlaceableOutlines[s].SetActive(false);
        }
    }

}

 

