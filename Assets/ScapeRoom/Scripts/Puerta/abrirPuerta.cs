using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class abrirPuerta : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "jugador")
        {
            //SceneManager.LoadScene(1);
            print("ABRIR PUERTA");
        }
        
    }
}
