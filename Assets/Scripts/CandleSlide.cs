using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleSlide : MonoBehaviour
{
    Vector3 candleDefaultPosition;
    Camera cam;
    Ray ray;
    Vector3 lineRendererLastPos;
    Vector3 orignalCandlePos;
    public GameObject candle;
    public LineRenderer lineRenderer;
    public float holeRadius;
    public GameObject cube;
    private void OnEnable()
    {
        if (cam != null)
        {
            candle.transform.localPosition = orignalCandlePos;
            lineRenderer.SetPosition(1, lineRendererLastPos);
        }

    }
    private void Start()
    {
        orignalCandlePos = candle.transform.localPosition;
        lineRendererLastPos = lineRenderer.GetPosition(1);

    }


    private void Update()
    {

        if (Mathf.Abs(candle.transform.localPosition.y - orignalCandlePos.y) <= holeRadius)
        {
            lineRenderer.SetPosition(1, lineRendererLastPos);


        }
        else
            lineRenderer.SetPosition(1, cube.transform.localPosition);

    }





}
