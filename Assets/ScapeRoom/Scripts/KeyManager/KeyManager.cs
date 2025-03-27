using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class KeyManager : MonoBehaviour
{
    public TextMeshPro  vMyText;
    [SerializeField] string vSecretCode;
    [SerializeField] public GameObject vAccesoSgteNivel;

    //Variables Sonido Puerta
    [SerializeField] Transform vPuerta2;
    bool vStatusSoundDoor;
    public AudioSource vAudioSourceDoor;
    [SerializeField] public AudioClip vAudioOpenDoor;


    //Variables Sonido KeyNumber
    public AudioSource vAudioSourceKeyNumber;
    [SerializeField] public AudioClip vAudioBotonKeyNumber;

    //Variables Sonido Clave Incorrecta
    public AudioSource vAudioSourceWrongPass;
    [SerializeField] public AudioClip vAudioBotonWrongPass;


    void Start()
    {

        vAudioSourceDoor.clip = vAudioOpenDoor;
        vStatusSoundDoor = true;

        vAudioSourceKeyNumber.clip = vAudioBotonKeyNumber;

        vAudioSourceWrongPass.clip = vAudioBotonWrongPass;
    }

    public void funcNumberKey(string myKey)
    {

        switch (myKey)
        {
            case "Boton0":
                funcScreenPrint("0");
                break;
            case "Boton1":
                funcScreenPrint("1");
                break;
            case "Boton2":
                funcScreenPrint("2");
                break;
            case "Boton3":
                funcScreenPrint("3");
                break;
            case "Boton4":
                funcScreenPrint("4");
                break;
            case "Boton5":
                funcScreenPrint("5");
                break;
            case "Boton6":
                funcScreenPrint("6");
                break;
            case "Boton7":
                funcScreenPrint("7");
                break;
            case "Boton8":
                funcScreenPrint("8");
                break;
            case "Boton9":
                funcScreenPrint("9");
                break;
            case "BotonOK":
                funcAbrirPuerta();
                break;
            case "BotonDel":
                funcDeleteChar();
                break;

            default:
                break;
        }
        
    }


    //AGREGA EL DIGITO A LA PANTALLA SI NO EXCEDE LOS 7 CARACTERES
    void funcScreenPrint(string vAddChar)
    {
        if (vMyText.text.Length < 7)
        {
            vMyText.text += vAddChar;
            funcPlaySoundBotonkeyNumber();
        }
    }

    //ELIMINA EL ULTIMO DIGITO EN LA PANTALLA
    void funcDeleteChar() {
        if (vMyText.text.Length > 0)
        {
            vMyText.text = vMyText.text[..^1];
            funcPlaySoundBotonkeyNumber();
        }
    }

    //ABRE LA PUERTA SI LA CLAVE ES CORRECTA
    void funcAbrirPuerta() 
    {

        if (vMyText.text == vSecretCode)
        {
            vPuerta2.GetComponent<Animator>().SetTrigger("triganimAbrirPuerta2");
            print("PUERTA ABIERTA");
            funcPlaySoundAbrirPuerta();
            funcPlaySoundBotonkeyNumber();
        }
        else 
        {
            funcPlaySoundClaveIncorrecta();
            vMyText.text = "";
        }
    }

    void funcPlaySoundAbrirPuerta()
    {
        if (vStatusSoundDoor == true)
        {
            vAudioSourceDoor.Play();
            vStatusSoundDoor = false;
            vAccesoSgteNivel.SetActive(true);
        }
    }

    void funcPlaySoundBotonkeyNumber() {
        vAudioSourceKeyNumber.Play();
    }

    void funcPlaySoundClaveIncorrecta()
    {
        vAudioSourceWrongPass.Play();
    }

}
