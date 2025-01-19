using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cambiarEscena : MonoBehaviour
{
   
    public void funcGoToArea(int vSgteArea)
    {
        print("FUNC SGTE AREA" + vSgteArea);
        SceneManager.LoadScene(vSgteArea);
        
    }
}
