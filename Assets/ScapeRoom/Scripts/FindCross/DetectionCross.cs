using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCross: MonoBehaviour
{
    public GameObject vSonidoCerca;
    public GameObject vSonidoMuyCerca;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "tagCross1")
        {
            vSonidoCerca.SetActive(true);
            print("SONIDO CERCA");
        }

        if (other.tag == "tagCross2")
        {
            vSonidoMuyCerca.SetActive(true);
            print("SONIDO MUY CERCA");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "tagCross1")
        {
            vSonidoCerca.SetActive(false);
        }
        if (other.tag == "tagCross2")
        {
            vSonidoMuyCerca.SetActive(false);
        }
    }
}
