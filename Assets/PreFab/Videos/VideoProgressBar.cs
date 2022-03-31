using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;
using TMPro;

public class VideoProgressBar : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    [SerializeField]
    VideoPlayer MainVideoPlayer;
    [SerializeField]
    TMP_Text TimeText;
    Image progress;
    [SerializeField]
    Image Icon;

    int Minutes, Seconds;

    public void OnDrag(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    private void Awake()
    {
        progress = GetComponent<Image>();
    }

    private void Update()
    {
        if (MainVideoPlayer.frameCount > 0)
        {
            progress.fillAmount = (float)MainVideoPlayer.frame / (float)MainVideoPlayer.frameCount;
        }

        MoveIcon2();
        SetTime();
       
    }

    void TrySkip(PointerEventData eventData)
    {
        Vector2 localPoint;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(progress.rectTransform,eventData.position, null, out localPoint))
        {
            float pct = Mathf.InverseLerp(progress.rectTransform.rect.xMin, progress.rectTransform.rect.xMax, localPoint.x);
            SkipToPercent(pct);
            MoveIcon(localPoint);
        }
    }

    void SkipToPercent(float pct)
    {
        var frame = MainVideoPlayer.frameCount * pct;
        MainVideoPlayer.frame = (long)frame;
    }
     
    void MoveIcon(Vector2 localPoint)
    {
        Icon.transform.localPosition = new Vector2(localPoint.x,0);

    }

    void MoveIcon2()
    {
        Icon.rectTransform.anchorMin = new Vector2(progress.fillAmount, Icon.rectTransform.anchorMin.y);
        Icon.rectTransform.anchorMax = new Vector2(progress.fillAmount, Icon.rectTransform.anchorMax.y);
        Icon.rectTransform.anchoredPosition = Vector2.zero;
    }

    void SetTime()
    {
        Minutes = (int)MainVideoPlayer.time / 60;
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
