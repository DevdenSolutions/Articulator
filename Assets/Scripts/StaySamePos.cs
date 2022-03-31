using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaySamePos : MonoBehaviour
{
    Vector3 pos;
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos;
    }
}
