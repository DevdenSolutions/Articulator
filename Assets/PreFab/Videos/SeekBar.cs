using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class SeekBar : MonoBehaviour
{
    [SerializeField]
    VideoPlayer MainVideoPlayer;
    [SerializeField]
    Slider VideoSlider;
    [SerializeField]
    TMP_Text TimeText;
    int Minutes,Seconds;
    public bool canSeek = true;

    public float maxValue;
    private void Start()
    {

    }

    public void SetMaxValueOfSlider()
    {
        if (MainVideoPlayer.clip != null)
        {
            VideoSlider.maxValue = (float)MainVideoPlayer.clip.length;
            print((float)MainVideoPlayer.clip.length + "Max Value Set");
        }

        else
        {
            print("Clip not set");
        }

    }
    public void Seek()
    {
        VideoSlider.value = (float)MainVideoPlayer.time;
    }

    private void Update()
    {

        Seek();
        SetTime();
    }


    public void GoTo()
    {
        MainVideoPlayer.time = VideoSlider.value;
        MainVideoPlayer.Play();
    }

    void SetTime()
    {
        Minutes =(int)MainVideoPlayer.time / 60;
        Seconds = (int)MainVideoPlayer.time % 60;
        if (Seconds < 10)
        {
            TimeText.text = Minutes.ToString() + ":0" + Seconds.ToString();
        }
        else
        {
            TimeText.text = Minutes.ToString() + ":" + Seconds.ToString();
        }
        
    }
}
