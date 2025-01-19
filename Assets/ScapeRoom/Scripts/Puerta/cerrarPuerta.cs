using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerrarPuerta : MonoBehaviour
{

    [SerializeField] Transform vPuerta1;        // Definir el objeto a modificar en Unity
    bool vStatusDoor = true;                    //true PUERTA ABIERTA - false PUERTA CERRADA

    public AudioSource vAudioSource;
    [SerializeField] public AudioClip vAudioDoor;

    void Start()
    {
        vAudioSource.clip = vAudioDoor;

    }

    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "jugador")
        {
            print("CERRAR PUERTA");

            if (vStatusDoor == true) {
                vPuerta1.GetComponent<Animator>().SetTrigger("triganimCerrarPuerta");
                vAudioSource.Play();
                vStatusDoor = false;
            }
            
        }

    }



}
