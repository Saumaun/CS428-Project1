using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class button2 : MonoBehaviour, IVirtualButtonEventHandler
{
    public int counter;
    public GameObject buttonObject;
    public GameObject Model;
    public GameObject Model2;
    public GameObject Model3;
    public VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        buttonObject = GameObject.Find("VirtualButton2");
        Model = GameObject.Find("Default text");
        Model2 = GameObject.Find("Text Reviews");
        Model3 = GameObject.Find("Video");
        Model2.SetActive(false);
        Model3.SetActive(false);

        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (counter == 2)
        {
            Model3.SetActive(true);
            Model2.SetActive(false);
            Model.SetActive(false);
            video.Play();
            counter = 0;
        }
        else if (counter == 1)
        {
            Model2.SetActive(true);
            Model.SetActive(false);
            Model3.SetActive(false);
            counter += 1;
        }
        else
        {
            video.Stop();
            Model.SetActive(true);
            Model2.SetActive(false);
            Model3.SetActive(false);
            counter += 1;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }
}
