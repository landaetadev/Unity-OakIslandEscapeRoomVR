using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class irAlArea0 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "jugador")
        //if (other.gameObject.tag == "CubePlayer")
        if (other.gameObject.tag == "jugador")
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
