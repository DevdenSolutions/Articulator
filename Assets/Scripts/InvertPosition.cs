using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertPosition : MonoBehaviour
{

    public GameObject copyFromObj;
    public bool invertInX;
    public bool invertInY;
    public bool invertInZ;

    Vector3 pos;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = copyFromObj.transform.localPosition;
        if (invertInX)
        {
            pos.x = pos.x * -1;
        }
        if (invertInY)
        {
            pos.y = pos.y * -1;
        }
        if (invertInZ)
        {
            pos.z = pos.z * -1;
        }
        transform.localPosition = pos;
    }
}
