using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class irALaSgteArea : MonoBehaviour
{
    public cambiarEscena vGoTo;
    public string vNroSgteNivel;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "jugador")
        {
            //SceneManager.LoadScene(2);
            vGoTo.funcGoToArea(System.Convert.ToInt32(vNroSgteNivel));
        }
        
    }

}
