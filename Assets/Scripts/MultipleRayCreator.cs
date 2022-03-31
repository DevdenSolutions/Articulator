using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleRayCreator : MonoBehaviour
{
    public List<Rray> rrays;


    private void OnEnable()
    {





    }

    private void Update()
    {
        for (int i = 0; i < rrays.Count; i++)
        {
            if (rrays[i].isUsingObjects)
            {
                rrays[i].lineRenderer.positionCount = rrays[i].gameObjects.Count;
                for (int j = 0; j < rrays[i].gameObjects.Count; j++)
                {
                    rrays[i].lineRenderer.SetPosition(j, rrays[i].gameObjects[j].transform.position);
                }
            }
            if (rrays[i].isUsingPoint)
            {
                rrays[i].lineRenderer.positionCount = rrays[i].points.Count;
                for (int j = 0; j < rrays[i].points.Count; j++)
                {
                    rrays[i].lineRenderer.SetPosition(j, rrays[i].points[j]);
                }
            }

        }
    }

    [System.Serializable]
    public class Rray
    {
        public LineRenderer lineRenderer;
        public bool isUsingPoint;
        public List<Vector3> points;
        public bool isUsingObjects;
        public List<GameObject> gameObjects;
    }


}
