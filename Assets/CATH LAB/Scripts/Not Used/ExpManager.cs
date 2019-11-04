using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ExpManager : MonoBehaviour {

    
    public static int eStage = 0;
    public Text ScreenText;
    public string[] eText;
    public AudioSource[] eSound;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
       
            ScreenText.text = eText[eStage].ToString();
        

        
	}
}
