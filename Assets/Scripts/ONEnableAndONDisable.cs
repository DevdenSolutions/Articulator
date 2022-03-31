using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class ONEnableAndONDisable : MonoBehaviour
{
    public UnityEvent invokeOnEnable;
    public UnityEvent invokeOnEnableDelayed;
    public UnityEvent invokeOnDisable;

    private void OnEnable()
    {
        invokeOnEnable.Invoke();
        Invoke(nameof(InvokeOnEnableDelayed), 0.05f);


    }
    public void OnDisable()
    {
        invokeOnDisable.Invoke(); 
    }


    public void InvokeOnEnableDelayed()
    {
        invokeOnEnableDelayed.Invoke();
    }

    public void RestartVideo(VideoPlayer videoPlayer)
    {
        videoPlayer.time = 0;
    }

}
