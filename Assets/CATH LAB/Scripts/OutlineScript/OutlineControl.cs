using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineControl : MonoBehaviour
{
    public Renderer _renderer; // renderer
    public Material[] _addMaterials; // store material outline for swapping
    public Material[] _mats; //store all materials currently active

    Color _color;
    // Use this for initialization
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _mats = _renderer.sharedMaterials;
    }

    // Update is called once per frame
    void Update()
    {
        //Toggle
        if (Input.GetKeyDown(KeyCode.W))
        {
            _mats[_mats.Length-1] = _addMaterials[0];
            _renderer.sharedMaterials = _mats;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _mats[_mats.Length-1] = _addMaterials[1];
            _renderer.sharedMaterials = _mats;
        }
    }
}
