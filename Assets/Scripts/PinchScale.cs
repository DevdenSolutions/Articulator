using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchScale : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 scale;
    Vector2 touch1deltaPos;
    Vector2 touch2deltaPos;
    public float minScale;
    public float maxScale;
    Vector2 startTouch1Pos;
    Vector2 startTouch2Pos;
    Vector2 touch1Pos;
    Vector2 touch2Pos;
    bool started;
    float startDis;
    float updatedDis;
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 2)
        {
            if (!started)
            {
                startTouch1Pos = Input.touches[0].position;
                startTouch2Pos = Input.touches[1].position;
                startDis = Vector2.Distance(startTouch1Pos, startTouch2Pos);

                started = true;
            }

            //touch1deltaPos = Input.touches[0].deltaPosition;
            //touch2deltaPos = Input.touches[1].deltaPosition;

            touch1Pos = Input.touches[0].position;
            touch2Pos = Input.touches[1].position;

            updatedDis = Vector2.Distance(touch1Pos, touch2Pos);
            updatedDis = updatedDis - startDis;
            scale = this.transform.localScale;
            if (minScale > scale.x + (updatedDis) * speed)
            {
                return;
            }
            if (maxScale < scale.x + (updatedDis) * speed)
            {
                return;
            }

            this.transform.localScale = scale + new Vector3((updatedDis) * speed, (updatedDis) * speed, (updatedDis) * speed);



        }
        else
        {
            started = false;
        }
    }
}
