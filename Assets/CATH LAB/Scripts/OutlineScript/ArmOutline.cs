using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmOutline : MonoBehaviour {

    public Renderer _renderer; // renderer
    public Material[] _addMaterials; // store material outline for swapping
   private Material[] _mats; //store all materials currently active

    // Use this for initialization
    void Start () {
        _renderer = GetComponent<Renderer>();
        _mats = _renderer.sharedMaterials;
    }
	
	// Update is called once per frame
	void Update () {
		
        if(ScriptEvent.StageEvent > 2)
        {
            _mats[_mats.Length - 1] = _addMaterials[0];
            _renderer.sharedMaterials = _mats;
        }
        else
        {
            _mats[_mats.Length - 1] = _addMaterials[1];
            _renderer.sharedMaterials = _mats;
        }
	}
}
