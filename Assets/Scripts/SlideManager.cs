using Lean.Transition;
using Lean.Transition.Method;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;

public class SlideManager : MonoBehaviour
{
    public TextMeshProUGUI slideTitleText;
    public TextMeshProUGUI slideDefinationText;
    public Image slideImg;
    public GameObject subTitle;
    public RawImage videoImg;
    public VideoPlayer videoPlayer;
    public int current;//HII
    public GameObject slide3DContent;
    public GameObject nextBtn;
    public GameObject previousBtn;
    public List<Slide> slides;
    public List<UnityEvent> resetEvents;
    public Transform DropDownListParent;
    public Color selectItemInListColor;
    public Color unSelectItemInListColor;
    private void OnEnable()
    {
        current = 0;
        ChangeSlideContent();
        ChangeColorOfCurrentItemInList();

    }

    public void Start()
    {
        for (int i = 0; i < slides.Count; i++)
        {
            int k = i;
            DropDownListParent.GetChild(k).GetComponent<Button>().onClick.AddListener(() => { ChangeSlide(k); print(k); });
            DropDownListParent.GetChild(k).GetChild(0).GetComponent<TextMeshProUGUI>().text = (k + 1) + ". " + slides[k].title;
        }
    }


    [System.Serializable]
    public class Slide
    {
        public string title;
        public string subTitle;
        public string defination;
        public Sprite img;
        public VideoClip videoClip;

    }

    public void ChangeSlideContent()
    {
        ChangeSlide3DObject();

        if (current < 0)
            current = 0;
        if (current > slides.Count - 1)
            current = slides.Count - 1;

        if (slides[current].title != null)
        {
            slideTitleText.gameObject.SetActive(false);
            slideTitleText.text = slides[current].title;
            transform.EventTransition(() =>
            {
                slideTitleText.gameObject.SetActive(true);
            }, 0.18f);
        }

        if (slides[current].defination != null)
            slideDefinationText.text = slides[current].defination;

        if (slides[current].img != null)
        {
            slideImg.gameObject.SetActive(true);
            slideImg.sprite = slides[current].img;
        }
        else
        {
            slideImg.gameObject.SetActive(false);
        }

        if (slides[current].subTitle != "")
        {
            subTitle.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = slides[current].subTitle;
            subTitle.gameObject.SetActive(true);
        }
        else
        {
            subTitle.gameObject.SetActive(false);
        }
        if (slides[current].videoClip != null)
        {
            //videoImg.gameObject.SetActive(true);
            //videoPlayer.clip = slides[current].videoClip;
        }
        else
        {
            // videoImg.gameObject.SetActive(false);
        }

    }

    public void ChangeSlide3DObject()
    {
        for (int i = 0; i < slide3DContent.transform.childCount; i++)
        {
            slide3DContent.transform.GetChild(i).gameObject.SetActive(false);
        }
        if (current < slide3DContent.transform.childCount)
            slide3DContent.transform.GetChild(current).gameObject.SetActive(true);


    }

    public void ChangeSlide(int i)
    {
        current = i;
        if (current == slides.Count - 1)
        {
            nextBtn.SetActive(false);
        }
        else
        {
            nextBtn.SetActive(true);
        }
        if (current <= 0)
        {
            previousBtn.SetActive(false);
        }
        else
        {
            previousBtn.SetActive(true);

        }
        ChangeColorOfCurrentItemInList();
    }



    public void Next()
    {
        current++;
        if (current == slides.Count - 1)
        {
            nextBtn.SetActive(false);
        }
        else
        {
            nextBtn.SetActive(true);
        }
        if (current <= 0)
        {
            previousBtn.SetActive(false);
        }
        else
        {
            previousBtn.SetActive(true);

        }
        ChangeColorOfCurrentItemInList();
    }

    public void Previous()
    {
        current--;
        if (current <= 0)
        {
            previousBtn.SetActive(false);
        }
        else
        {
            previousBtn.SetActive(true);
        }
        if (current == slides.Count - 1)
        {
            nextBtn.SetActive(false);
        }
        else
        {
            nextBtn.SetActive(true);

        }
        ChangeColorOfCurrentItemInList();
    }




    public void ResetSlide()
    {
        resetEvents[current].Invoke();
    }

    public void ChangeColorOfCurrentItemInList()
    {

        for (int i = 0; i < slides.Count; i++)
        {
            DropDownListParent.GetChild(i).GetChild(0).GetComponent<LeanGraphicColor>().BeginThisTransition();
        }
        Invoke(nameof(ChangeCurrentColor), 0.1f);

    }

    public void ChangeCurrentColor()
    {
        if (current < DropDownListParent.childCount)
            DropDownListParent.GetChild(current).GetComponent<LeanGraphicColor>().BeginThisTransition();
    }
}
