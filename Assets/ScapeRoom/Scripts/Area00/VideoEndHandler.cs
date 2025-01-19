using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoEndHandler : MonoBehaviour
{
    private VideoPlayer vShowVideo;
    public cambiarEscena vGoTo;

    void Start()
    {
        // Obtener el componente VideoPlayer
        vShowVideo = GetComponent<VideoPlayer>();

        // Registrar el evento loopPointReached
        vShowVideo.loopPointReached += OnVideoEnd;
    }

    // Codigo que se ejecuta cuando el video termina
    private void OnVideoEnd(VideoPlayer vShowVideo)
    {
        print("VIDEO TERMINADO");
        //SceneManager.LoadScene(1);
        vGoTo.funcGoToArea(1);

    }

    void OnDestroy()
    {
        // Asegurarse de desregistrar el evento para evitar errores
        if (vShowVideo != null)
            vShowVideo.loopPointReached -= OnVideoEnd;
    }
}
