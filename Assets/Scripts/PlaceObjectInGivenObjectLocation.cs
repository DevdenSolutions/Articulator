using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjectInGivenObjectLocation : MonoBehaviour
{
    // Start is called before the first frame 
    public GameObject copyPosObject;
    public GameObject copyRotObject;
    public LineRenderer lineRenderer;
    public bool copyPos;
    public bool copyRotX;
    public float deltaX;
    public bool copyRotY;
    public float deltaY;
    public bool copyRotZ;
    public float deltaZ;
    public bool placeAtLineRendererPos;
    public int lineRendererPosPOint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (copyPos)
        {
            CopyPositoin();
        }
        if (copyRotX)
        {
            CopyRotationX();
        }
        if (copyRotY)
        {
            CopyRotationY();
        }
        if (copyRotZ)
        {
            CopyRotationZ();
        }
        if (placeAtLineRendererPos)
        {
            PlaceObjectAtLineRendererPos(lineRendererPosPOint);
        }
    }


    public void CopyPositoin()
    {
        this.gameObject.transform.position = copyPosObject.transform.position;

    }
    public void PlaceObjectAtLineRendererPos(int pos)
    { 
        this.gameObject.transform.position = lineRenderer.GetPosition(pos);

    }

    public void CopyRotationX()
    {
        Vector3 temp = this.gameObject.transform.eulerAngles;
        temp.x = copyRotObject.transform.eulerAngles.x+deltaX;
        this.gameObject.transform.eulerAngles = temp ;
    }
    public void CopyRotationY()
    {
        Vector3 temp = this.gameObject.transform.eulerAngles;
        temp.y = copyRotObject.transform.eulerAngles.y+deltaY;
        this.gameObject.transform.eulerAngles = temp ;
    }
    public void CopyRotationZ()
    {
        Vector3 temp = this.gameObject.transform.eulerAngles;
        temp.z = copyRotObject.transform.eulerAngles.z+deltaZ;
        this.gameObject.transform.eulerAngles = temp ;
    }
}
