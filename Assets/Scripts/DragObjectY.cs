
using UnityEngine;
using System.Collections;
public class DragObjectY : MonoBehaviour
{
    public float dragSpeed = 1f;
    Vector3 lastMousePos;

    public float minLocalY;
    public float maxLocalY;
    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
    }

    void OnMouseDrag()
    {


        Vector3 delta = Input.mousePosition - lastMousePos;
        Vector3 pos = transform.position;
        if (minLocalY >= pos.y + delta.y * dragSpeed)
            return;
        if (maxLocalY <= pos.y + delta.y * dragSpeed)
            return;
        pos.y += delta.y * dragSpeed;
        transform.position = pos;
        lastMousePos = Input.mousePosition;
    }
}