using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaySameRotation : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 rot;
    void Start()
    {
        rot = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = rot;
    }
}
