using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSwitch : MonoBehaviour
{

    public GameObject finish, nofinish;
    void Start()
    {

    }

    public void OnChangeValue()
    {
        bool onoffToggle = gameObject.GetComponent<Toggle>().isOn;

        if (onoffToggle)
        {
          
            finish.SetActive(true);
        }
        else
        {           
            finish.SetActive(false);
        }
    }
}
