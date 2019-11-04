using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOver : MonoBehaviour {

    public MeshRenderer MeshRen;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MeshRen.materials[1].SetFloat("Thickness", 900);
	}

   

    }
