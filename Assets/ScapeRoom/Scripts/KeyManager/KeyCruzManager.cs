using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class KeyCruzManager : MonoBehaviour
{

    public GameObject vCruzObject;

    //Cruz posicion oculta  Y=-0.093
    //Cruz posicion visible Y=0.00257

    public void funcCruzKey(string myKey)
    {

        switch (myKey)
        {

            case "GameObjectFingerCross":
                print("TOUCH CROSS");

                // Toma la posicion actual del  objeto
                Vector3 vNewPosicionY = vCruzObject.transform.position;
                vNewPosicionY.y = 0.00257f;
                vCruzObject.transform.position = vNewPosicionY;
                break;

            default:
                break;
        }
        
    }


}
