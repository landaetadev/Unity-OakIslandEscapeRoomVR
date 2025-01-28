using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class KeyMacBookManager : MonoBehaviour
{

    //Variables pantallas
    [SerializeField] public GameObject vScreenMac;
    [SerializeField] public GameObject vScreenTV;
    private VideoPlayer vVideoPlayer;

    public void funcMacBookKey(string myKey)
    {

        switch (myKey)
        {

            case "TeclaMacEnter":
                print("TOUCH ENTER");
                funcPlayVideo();
                break;
            case "TeclaMacTrack":
                print("TOUCH TRACKPAD");
                funcPlayVideo();
                break;

            default:
                break;
        }
        
    }

    void funcPlayVideo() {
        print("PLAY VIDEO");
        vVideoPlayer = vScreenTV.GetComponent<VideoPlayer>();
        vVideoPlayer.Prepare();
        vVideoPlayer.Play();
        vVideoPlayer = vScreenMac.GetComponent<VideoPlayer>();
        vVideoPlayer.Prepare();
        vVideoPlayer.Play();
    }


}
