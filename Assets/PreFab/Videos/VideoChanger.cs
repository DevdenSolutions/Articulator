using UnityEngine;
using UnityEngine.Video;

public class VideoChanger : MonoBehaviour
{

    VideoPlayer MainVideoPlayer;
    [SerializeField]
    VideoClip[] AllVideoClip;
    [SerializeField]
    RenderTexture MainRenderTexture;
    void Start()
    {
        MainVideoPlayer = gameObject.GetComponent<VideoPlayer>();
    }

    public void PlaySelectedVideo(int ID)
    {
        switch (ID)
        {
            case 0:
                MainVideoPlayer.clip = AllVideoClip[0];
                break;

            case 1:
                MainVideoPlayer.clip = AllVideoClip[1];
                break;

            
        }

    }


    public void RefreshRenderTexture()
    {
        MainRenderTexture.Release();
    }

}
