using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertAngle : MonoBehaviour
{

    public GameObject copyFromObj;
    public bool invertInX;
    public bool invertInY;
    public bool invertInZ;

    Vector3 ang;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ang = copyFromObj.transform.eulerAngles;
        if (invertInX)
        {
            ang.x = ang.x * -1;
        }
        if (invertInY)
        {
            ang.y = ang.y * -1;
        }
        if (invertInZ)
        {
            ang.z = ang.z * -1;
        }
        transform.eulerAngles = ang;
    }
}
