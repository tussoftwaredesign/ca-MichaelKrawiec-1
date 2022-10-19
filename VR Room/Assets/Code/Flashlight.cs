using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlashlightOnOff : MonoBehaviour
{

    public GameObject SpotLight;
    bool flashlightson;

    void Start()
    {
        SpotLight.SetActive(false);
        flashlightson = false;
    }

    public void TurnOn()
    {
        SpotLight.SetActive(true);
        flashlightson = true;
    }

    public void TurnOff()
    {
        SpotLight.SetActive(false);
        flashlightson = false;
    }

    /*public void ToggleFlashlight()
    {
        if (flashlightson)
            TurnOff();
        else
            TurnOn();
    }*/
    void update()
    {
        if (Input.GetDown(""))
        {
            TurnOn();
            Debug.Log("Button pressed");
        }
        else
        {
            TurnOff();
        }
    }
}