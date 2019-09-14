using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class button : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject buttonObject;
    public GameObject Model;
    public AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        buttonObject = GameObject.Find("VirtualButton");
        Model = GameObject.Find("Holden");
        Model.SetActive(false);
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Model.SetActive(true);
        a.Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Model.SetActive(false);
        a.Stop();
    }
}
