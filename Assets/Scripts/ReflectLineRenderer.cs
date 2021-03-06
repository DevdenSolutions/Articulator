using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReflectLineRenderer : MonoBehaviour
{
    public int reflections;
    public float maxLength;
    public Vector3 initialRayDir;
    public LineRenderer lineRenderer;
    Ray ray;
    RaycastHit hit;
    Vector3 direction;

    private void Update()
    {
        ray = new Ray(transform.position, initialRayDir);
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
        float remainglength = maxLength;

        for (int i = 0; i < reflections; i++)
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hit, remainglength))
            {
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, hit.point);
                remainglength -= Vector3.Distance(ray.origin, hit.point);
                ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));
                if (hit.collider.tag != "IrregularMirror")
                {
                    break;
                }
                {
                    lineRenderer.positionCount += 1;
                    lineRenderer.SetPosition(lineRenderer.positionCount - 1, ray.origin + ray.direction * remainglength);
                
                }
            }
        }


    }


}
