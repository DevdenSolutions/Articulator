using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleBasedOnLineRendererPoints : MonoBehaviour
{
    public LineRenderer lineRenderer1;
    public Image img;
    public float offset;
    public bool inX;
    public bool inY;
    public bool inZ;
    float theta;
    Vector3 angle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inX)
        {
            theta = (Mathf.Atan2(lineRenderer1.GetPosition(0).y - lineRenderer1.GetPosition(1).y, lineRenderer1.GetPosition(0).x - lineRenderer1.GetPosition(1).x) * 180 / Mathf.PI);
            theta = theta + offset;
            angle = img.transform.localEulerAngles;
            angle.x = theta;
            img.transform.localEulerAngles = angle;
        }
        if (inY)
        {
            theta = (Mathf.Atan2(lineRenderer1.GetPosition(0).y - lineRenderer1.GetPosition(1).y, lineRenderer1.GetPosition(0).x - lineRenderer1.GetPosition(1).x) * 180 / Mathf.PI);
            theta = theta + offset;
            angle = img.transform.localEulerAngles;
            angle.y = theta;
            img.transform.localEulerAngles = angle;
        }
        if (inZ)
        {
            theta = (Mathf.Atan2(lineRenderer1.GetPosition(0).y - lineRenderer1.GetPosition(1).y, lineRenderer1.GetPosition(0).x - lineRenderer1.GetPosition(1).x) * 180 / Mathf.PI);
            theta = theta + offset;
            angle = img.transform.localEulerAngles;
            angle.z = theta;
            img.transform.localEulerAngles = angle;
        }

    }
}
