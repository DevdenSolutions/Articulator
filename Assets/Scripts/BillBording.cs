using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBording : MonoBehaviour
{
    Camera cam;
    public bool inX;
    public bool inY;
    public bool inZ;
    Vector3 temp;
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {


        transform.LookAt(cam.transform);
        if (inY)
        {
            transform.localEulerAngles = new Vector3(0, this.gameObject.transform.localEulerAngles.y - 180, 0);

        }
        if (inX)
        {
            transform.localEulerAngles = new Vector3(this.gameObject.transform.localEulerAngles.y - 180, 0, 0);

        }
        if (inZ)
        {
            transform.localEulerAngles = new Vector3(0, 0, this.gameObject.transform.localEulerAngles.z - 180);
        }
    }
}
