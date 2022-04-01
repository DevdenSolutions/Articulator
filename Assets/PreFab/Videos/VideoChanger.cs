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

        MainVideoPlayer.clip = AllVideoClip[ID];
    }


    public void RefreshRenderTexture()
    {
        MainRenderTexture.Release();
    }

}
