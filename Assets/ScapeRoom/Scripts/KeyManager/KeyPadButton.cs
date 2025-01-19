using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadButton : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        try
        {
            gameObject.transform.parent.GetComponent<KeyManager>().funcNumberKey(gameObject.name);
        }
        catch (System.NullReferenceException) { }
        
        try
        {
            gameObject.transform.parent.GetComponent<KeyMacBookManager>().funcMacBookKey(gameObject.name);
        }
        catch (System.NullReferenceException) { }

        try
        {
            gameObject.transform.parent.GetComponent<KeyCruzManager>().funcCruzKey(gameObject.name);
        }
        catch (System.NullReferenceException) { }

    }


}
