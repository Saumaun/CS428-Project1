using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetAudio : MonoBehaviour, ITrackableEventHandler
{
    public TrackableBehaviour t;
    public AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<TrackableBehaviour>();
        if (t)
            t.RegisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status prev, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            a.Play();
        }
        else
        {
            a.Stop();
        }
    }
}
 
