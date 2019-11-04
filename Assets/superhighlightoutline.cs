using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superhighlightoutline : MonoBehaviour
{

    public ParticleSystem PlaceableOutlines;
    public int RequiredValue;
    // Use this for initialization
    void Start()
    {
        PlaceableOutlines.Stop();
    }

    // Update is called once per frame
    void Update()
    {


        if (ScriptEvent.HighlightPrompt == RequiredValue && ScriptEvent.StageEvent == RequiredValue)
        {
            PlaceableOutlines.Play();
        }
        else
        {
            PlaceableOutlines.Stop();
        }

    }
}
