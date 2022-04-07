using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class RotateObjectInZOnDrag : MonoBehaviour
{
    public float dragSpeed = 1f;
    public Vector3 lastMousePos;

    public bool rotateInX;
    public bool rotateInY;
    public bool rotateInZ;

    public bool dragX;
    public bool dragY;

    public float minAngle;
    public float maxAngle;

    public UnityEvent onClick;
    bool draged;
    float time;
    private void OnEnable()
    {
        draged = false;
    }

    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        draged = true;
        print("hello");

        Vector3 delta = Input.mousePosition - lastMousePos;
        delta = delta * -1;
        Vector3 ang = transform.eulerAngles;
        Vector3 pos = transform.eulerAngles;
        time += Time.deltaTime;
        if (dragX)
        {

            if (rotateInX)
            {

                if (minAngle >= ang.x + delta.x * dragSpeed)
                {
                    ang.x = minAngle;
                    transform.eulerAngles = ang;
                    return;
                }
                if (maxAngle <= ang.x + delta.x * dragSpeed)
                {
                    ang.x = maxAngle;
                    transform.eulerAngles = ang;
                    return;
                }

                ang.x += delta.x * dragSpeed;
                transform.eulerAngles = ang;
                lastMousePos = Input.mousePosition;
            }
            if (rotateInY)
            {

                if (minAngle >= ang.y + delta.x * dragSpeed)
                {
                    ang.y = minAngle;
                    transform.eulerAngles = ang;
                    return;
                }
                if (maxAngle <= ang.z + delta.x * dragSpeed)
                {
                    ang.y = maxAngle;
                    transform.eulerAngles = ang;
                    return;
                }

                ang.y += delta.x * dragSpeed;
                transform.eulerAngles = ang;
                lastMousePos = Input.mousePosition;
            }
            if (rotateInZ)
            {

                if (minAngle >= ang.z + delta.x * dragSpeed)
                {
                    ang.z = minAngle;
                    transform.eulerAngles = ang;
                    return;
                }
                if (maxAngle <= ang.z + delta.x * dragSpeed)
                {
                    ang.z = maxAngle;
                    transform.eulerAngles = ang;
                    return;
                }

                ang.z += delta.x * dragSpeed;
                transform.eulerAngles = ang;
                lastMousePos = Input.mousePosition;
            }
        }
        if (dragY)
        {
            if (rotateInX)
            {

                if (minAngle >= ang.x + delta.y * dragSpeed)
                {
                    ang.x = minAngle;
                    transform.eulerAngles = ang;
                    if (transform.eulerAngles.x == 90)
                    {
                        ang.x = 91;
                        transform.eulerAngles = ang;
                    }
                    return;
                }
                if (maxAngle <= ang.x + delta.y * dragSpeed)
                {
                    ang.x = maxAngle;
                    transform.eulerAngles = ang;
                    return;
                }

                ang.x += delta.y * dragSpeed;
                transform.eulerAngles = ang;
                lastMousePos = Input.mousePosition;
            }
            if (rotateInY)
            {

                if (minAngle >= ang.y + delta.y * dragSpeed)
                {
                    ang.y = minAngle;
                    transform.eulerAngles = ang;
                    return;
                }
                if (maxAngle <= ang.z + delta.y * dragSpeed)
                {
                    ang.y = maxAngle;
                    transform.eulerAngles = ang;
                    return;
                }

                ang.y += delta.y * dragSpeed;
                transform.eulerAngles = ang;
                lastMousePos = Input.mousePosition;
            }
            if (rotateInZ)
            {

                if (minAngle >= ang.z + delta.y * dragSpeed)
                {
                    ang.z = minAngle;
                    transform.eulerAngles = ang;
                    return;
                }
                if (maxAngle <= ang.z + delta.y * dragSpeed)
                {
                    ang.z = maxAngle;
                    transform.eulerAngles = ang;
                    return;
                }

                ang.z += delta.y * dragSpeed;
                transform.eulerAngles = ang;
                lastMousePos = Input.mousePosition;
            }
        }

    }

    private void OnMouseUp()
    {
        draged = false;
        time = 0;
    }



    private void OnMouseUpAsButton()
    {
        if (time<0.1f)
        {
            onClick.Invoke();        
        }
        draged = false;
        time = 0;
    }

}