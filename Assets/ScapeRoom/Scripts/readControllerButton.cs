using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class readControllerButton : MonoBehaviour
{
    [SerializeField]
    InputActionProperty m_ActivateActionBtnA;
    [SerializeField]
    InputActionProperty m_ActivateActionBtnB;
    [SerializeField]
    InputActionProperty m_ActivateActionBtnX;
    [SerializeField]
    InputActionProperty m_ActivateActionBtnY;
    public UnityEngine.Video.VideoPlayer vPlayVideo;

    private void OnEnable()
    {
        m_ActivateActionBtnA.action.performed += OnButtonPressedA;
        m_ActivateActionBtnA.action.Enable();
        m_ActivateActionBtnB.action.performed += OnButtonPressedB;
        m_ActivateActionBtnB.action.Enable();
        m_ActivateActionBtnX.action.performed += OnButtonPressedX;
        m_ActivateActionBtnX.action.Enable();
        m_ActivateActionBtnY.action.performed += OnButtonPressedY;
        m_ActivateActionBtnY.action.Enable();
    }

    private void OnDisable()
    {
        m_ActivateActionBtnA.action.performed += OnButtonPressedA;
        m_ActivateActionBtnA.action.Disable();
        m_ActivateActionBtnB.action.performed += OnButtonPressedB;
        m_ActivateActionBtnB.action.Disable();
        m_ActivateActionBtnX.action.performed += OnButtonPressedX;
        m_ActivateActionBtnX.action.Disable();
        m_ActivateActionBtnY.action.performed += OnButtonPressedY;
        m_ActivateActionBtnY.action.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnButtonPressedA(InputAction.CallbackContext context)
    {
        Debug.Log("Boton1 pulsado");
        //vPlayVideo.Play();
    }

    private void OnButtonPressedB(InputAction.CallbackContext context)
    {
        Debug.Log("Boton2 pulsado");
        //vPlayVideo.Stop();
    }
    private void OnButtonPressedX(InputAction.CallbackContext context)
    {
        Debug.Log("Boton2 pulsado");
        //vPlayVideo.Stop();
    }
    private void OnButtonPressedY(InputAction.CallbackContext context)
    {
        Debug.Log("Boton2 pulsado");
        //vPlayVideo.Stop();
    }

}
