using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlashlightOnOff : MonoBehaviour
{

    public GameObject SpotLight;
    public bool flashlightson;

    void Start()
    {
        SpotLight.SetActive(false);
        flashlightson = false;
    }

    public void TurnOn()
    {
        SpotLight.SetActive(true);
    }

    public void TurnOff()
    {
        SpotLight.SetActive(false);
        flashlightson = false;
    }

    public void ToggleFlashlight()
    {
        if (flashlightson == true) { 
            TurnOn();
            Debug.Log("ON");
        }
        else { 
            TurnOff();
        }
    }
    void update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flashlightson = true;
            Debug.Log("Button pressed");
            
        }
        else
        {
            flashlightson = false;

        }
        ToggleFlashlight();
    }
}