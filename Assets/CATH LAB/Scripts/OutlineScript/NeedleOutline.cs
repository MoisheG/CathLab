using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleOutline : MonoBehaviour
{

    public GameObject NeedleOutlineMesh;
    public int RequiredValue;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void NeedleOutlineTRUE()
    {
        if (ScriptEvent.StageEvent < RequiredValue)
        {
            NeedleOutlineMesh.SetActive(true);
        }
    }
    public void NeedleOutlineFALSE()
    {
                
            NeedleOutlineMesh.SetActive(false);
        
    }
}
