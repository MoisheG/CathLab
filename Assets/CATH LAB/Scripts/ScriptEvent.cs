using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScriptEvent : MonoBehaviour
{


    public Text StageText;
    public static float StageEvent = -1;
    public GameObject ECG;
    public GameObject HINK;
    public AudioClip[] AQ;
    public static AudioSource AP;
    public bool[] AS = new bool[5];
    public GameObject Video;
    public static int HighlightPrompt = -1;
    //  public GameObject[] ImagePrev;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (StageEvent == -1)
        {

            if (ObjectCollide.Triggered == true)
            {

                StageEvent = 0;

            }


        }

        if (StageEvent == 1)
        {
            ECG.SetActive(true);
        }
        if (StageEvent == 9)
        {
            HINK.SetActive(true);
        }
    }
}
