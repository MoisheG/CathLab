using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieScript : MonoBehaviour
{
    //Initialize Movie texture and renderer
    Renderer r;
    MovieTexture movie;

    //Arbitrary trigger to start the movie
    static public bool StartTrigger;

    //Arbitrary trigger to start the movie
    static public bool StopTrigger;

    void Start ()
    {
        //Get renderer of the object
        r = GetComponent<Renderer>();

        //Get the movie texture that is attached to this object
        movie = (MovieTexture)r.material.mainTexture;

        //Make the movie loop after it ends
        movie.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        //// Press "A" to start the movie
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    StartTrigger = true;
        //    StopTrigger = false;
        //}
        //// Press "S" to stop the movie
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    StartTrigger = false;
        //    StopTrigger = true;
        //}

        ////Start playing the movie
        //if (StartTrigger)
        //{
            if (!movie.isPlaying)
                movie.Play();
        //}
        ////Pause the movie
        //else if (StopTrigger)
        //{
        //    if (movie.isPlaying)
        //        movie.Pause();
        //}
    }
}
