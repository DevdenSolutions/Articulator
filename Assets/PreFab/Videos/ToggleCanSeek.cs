using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ToggleCanSeek : Slider
{

    [SerializeField]
    SeekBar seekBar;
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);

        // Your code here
        seekBar.canSeek = false;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);

        seekBar.canSeek = true;
    }
}
