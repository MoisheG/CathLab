using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPadOutline : MonoBehaviour
{
    public int RequiredValue;
    public Renderer _renderer;
    private Material[] _mats;
    public Material[] _addMaterials;

    // Use this for initialization
    void Start()
    {
        _mats = _renderer.sharedMaterials;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (ScriptEvent.HighlightPrompt == RequiredValue)
        {
            _mats[_mats.Length - 1] = _addMaterials[0];
            _renderer.sharedMaterials = _mats;
        }
        else if(ScriptEvent.HighlightPrompt != RequiredValue)
        {
            _mats[_mats.Length - 1] = _addMaterials[1];
            _renderer.sharedMaterials = _mats;
        }
    }
}
