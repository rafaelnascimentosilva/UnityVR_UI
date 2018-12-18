using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverHandInRecipient : MonoBehaviour
{
    SoundManager sound;
    public GameObject go;

    void Start()
    {
        sound = FindObjectOfType<SoundManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sound.ExecutaSom();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            // go.transform.GetChild(0).gameObject.SetActive(true);
            go.transform.GetChild(1).gameObject.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            go.transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
