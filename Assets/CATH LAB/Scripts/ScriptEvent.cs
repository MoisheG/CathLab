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
    public GameObject DYK1;
    public GameObject DYK2;
    public GameObject DYK3;
    public AudioClip[] AQ;
    public static AudioSource AP;
    public bool[] AS = new bool[5];
    public GameObject Video;
    public static int HighlightPrompt = -1;
    //  public GameObject[] ImagePrev;
    // Use this for initialization
    void Start()
    {
        DYK1.SetActive(false);
        DYK2.SetActive(false);
        DYK3.SetActive(false);
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
            DYK1.SetActive(true);
        }
        if(StageEvent == 2)
        {
            DYK1.SetActive(false);
        }
        if (StageEvent == 5)
        {
            DYK2.SetActive(true);
        }
        if (StageEvent == 6)
        {
            DYK2.SetActive(false);
        }
        if (StageEvent == 9)
        {
            HINK.SetActive(true);
            DYK3.SetActive(true);
        }
        if (StageEvent == 10)
        {
            DYK3.SetActive(false);
        }
    }
}
