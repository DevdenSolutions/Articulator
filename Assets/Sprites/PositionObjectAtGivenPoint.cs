using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionObjectAtGivenPoint : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public bool reverse;

    public void Update()
    {
        if (!reverse)
        {
            this.transform.position = lineRenderer.GetPosition(1);
            this.transform.LookAt(2 * lineRenderer.GetPosition(0) - lineRenderer.GetPosition(1));
        }
        else
        {
            this.transform.position = (lineRenderer.GetPosition(0)+lineRenderer.GetPosition(1))/2;
            this.transform.LookAt(2 * lineRenderer.GetPosition(1) - lineRenderer.GetPosition(0));
        }
    }
}
