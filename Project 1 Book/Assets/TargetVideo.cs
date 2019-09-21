using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class TargetVideo : MonoBehaviour, ITrackableEventHandler
{
    public TrackableBehaviour t;
    public  VideoPlayer video;
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
            video.Play();
        }
        else
        {
            video.Stop();
        }
    }
}
