using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlRadialFill : MonoBehaviour
{
    public bool usingGameObject;
    public Image img;
    public GameObject go;
    public bool x;
    public bool y;
    public bool z;
    public float offset;
    float ang;
    float theta;
    public bool usingLineRenderer;
    public LineRenderer lineRenderer1;
    public LineRenderer lineRenderer2;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (usingGameObject)
        {

            if (x)
            {
                ang = go.transform.localEulerAngles.x;
                ang = ang + offset;

                img.fillAmount = Mathf.InverseLerp(0, 360, ang);
            }
            if (y)
            {
                ang = go.transform.localEulerAngles.y;
                ang = ang + offset;

                img.fillAmount = Mathf.InverseLerp(0, 360, ang);
            }
            if (z)
            {
                ang = go.transform.localEulerAngles.z;
                ang = ang + offset;

                img.fillAmount = Mathf.InverseLerp(0, 360, ang);
            }
        }
        if (usingLineRenderer)
        {
            theta = -(Mathf.Atan2(lineRenderer1.GetPosition(0).y - lineRenderer1.GetPosition(1).y, lineRenderer1.GetPosition(0).x - lineRenderer1.GetPosition(1).x)*180/Mathf.PI)+(Mathf.Atan2(lineRenderer2.GetPosition(0).y - lineRenderer2.GetPosition(1).y, lineRenderer2.GetPosition(0).x - lineRenderer2.GetPosition(1).x) * 180 / Mathf.PI);
            theta = theta + offset;
            img.fillAmount = Mathf.InverseLerp(0, 360, theta);
        }
    }
}
