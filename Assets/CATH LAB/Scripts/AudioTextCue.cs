using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioTextCue : MonoBehaviour {

    public int Cue;
    public Text TabletText;
    
    public AudioClip[] AudioClips;
    public string[] StringClips;
    public string TaskText;
    public static AudioSource AudioPlayer;
  //  private bool[] AudioPlayed;
    private int CueStage = 0;
    public static bool[] HighlightEnd = new bool[10];
	// Use this for initialization
	void Start () {
        AudioPlayer = GameObject.FindWithTag("Audio").GetComponent<AudioSource>();
        //AudioPlayed = new bool[AudioClips.Length];
	}
	
	// Update is called once per frame
	void Update () {
        if (ScriptEvent.StageEvent == Cue)
        {
            if (Cue > 0)
            {
                HighlightEnd[Cue - 1] = true;
            }
            if (!AudioPlayer.isPlaying)
            {
                if (CueStage == AudioClips.Length)
                {
                    ScriptEvent.HighlightPrompt = Cue;
                    TabletText.text = TaskText;
                }
                else
                {
                    AudioPlayer.clip = AudioClips[CueStage];
                    TabletText.text = StringClips[CueStage];
                    AudioPlayer.Play();
                    CueStage++;
                }
            }            
            
        }
	}
}
