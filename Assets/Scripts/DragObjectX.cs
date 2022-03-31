using UnityEngine;
using System.Collections;
public class DragObjectX : MonoBehaviour
{
    public float dragSpeed = 1f;
    Vector3 lastMousePos;

    public float minX;
    public float maxX;

    public bool isLocal;
    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
    }

    void OnMouseDrag()
    {


        if (!isLocal)
        {
            Vector3 delta = Input.mousePosition - lastMousePos;
            Vector3 pos = transform.position;
            if (minX >= pos.x + delta.x * dragSpeed)
                return;
            if (maxX <= pos.x + delta.x * dragSpeed)
                return;
            pos.x += delta.x * dragSpeed;
            transform.position = pos;
            lastMousePos = Input.mousePosition;
        }
        else
        {
            Vector3 delta = Input.mousePosition - lastMousePos;
            Vector3 pos = transform.localPosition;
            if (minX >= pos.x + delta.x * dragSpeed)
                return;
            if (maxX <= pos.x + delta.x * dragSpeed)
                return;
            pos.x += delta.x * dragSpeed;
            transform.localPosition = pos;
            lastMousePos = Input.mousePosition;
        }
    }
}