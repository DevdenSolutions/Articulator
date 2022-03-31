using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SettingMaxValue : MonoBehaviour
{
    [SerializeField]
    SeekBar seekBar;

    VideoPlayer MainVideoPlayer;

  
    private void OnEnable()
    {
        seekBar.SetMaxValueOfSlider();
    }

  
}
