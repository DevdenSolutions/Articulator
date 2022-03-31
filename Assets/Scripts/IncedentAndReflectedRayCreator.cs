using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncedentAndReflectedRayCreator : MonoBehaviour
{

    public GameObject startObject;
    public GameObject focusObject;
    public GameObject curvatureObject;
    public LineRenderer incedentRay;
    public LineRenderer reflectedRay;
    public LineRenderer virtualRay;
    public LineRenderer curvatureLine;

    public bool check;
    public bool extendCurvatureLine;
    public bool extendVirtualLine;
    // in convex mirror virtual ray is refeclectedray and vice versa


    Ray ray;
    RaycastHit hit;
    float temp;
    void Start()
    {
        incedentRay.SetPosition(0, startObject.transform.position);
        reflectedRay.SetPosition(0, focusObject.transform.position);
        curvatureLine.SetPosition(0, curvatureObject.transform.position);

        if (virtualRay != null)
        {
            virtualRay.SetPosition(0, new Vector3(0, 0, 0));

        }
        temp = 2f;
    }

    // Update is called once per frame
    void Update()
    {

        incedentRay.SetPosition(0, startObject.transform.position);
        reflectedRay.SetPosition(0, focusObject.transform.position);
        curvatureLine.SetPosition(0, curvatureObject.transform.position);


        if (virtualRay != null)
        {
            virtualRay.SetPosition(0, new Vector3(0, 0, 0));

        }


        incedentRay.SetPosition(0, startObject.transform.position);
        if (Physics.Raycast(startObject.transform.position, startObject.transform.right, out hit))
            if (hit.collider.gameObject.tag == "mirror")
            {
                incedentRay.SetPosition(1, hit.point);
                reflectedRay.SetPosition(1, hit.point);
                if (check)
                {
                    Vector3 temp;
                    temp = focusObject.transform.localPosition;
                    temp.x = focusObject.transform.localPosition.x + reflectedRay.GetPosition(0).x - reflectedRay.GetPosition(1).x;
                    curvatureObject.transform.localPosition = temp;
                }


                curvatureLine.SetPosition(1, hit.point);
                if (virtualRay != null)
                {
                    virtualRay.SetPosition(0, hit.point);
                    virtualRay.SetPosition(1, new Vector3(-0.07f, ((hit.point.y - reflectedRay.GetPosition(0).y) / (hit.point.x - reflectedRay.GetPosition(0).x) * ((-0.07f) - hit.point.x) + hit.point.y), hit.point.z));


                }

                if (extendCurvatureLine)
                {
                 //Vector3 temp = 2 * curvatureLine.GetPosition(1) - curvatureLine.GetPosition(0);
                    curvatureLine.SetPosition(2, 2 * curvatureLine.GetPosition(1) - curvatureLine.GetPosition(0));
                    curvatureLine.SetPosition(2, new Vector3((curvatureLine.GetPosition(0).x + 2 * curvatureLine.GetPosition(2).x) / (3), (curvatureLine.GetPosition(0).y + 2 * curvatureLine.GetPosition(2).y) / (3), (curvatureLine.GetPosition(0).z + 2 * curvatureLine.GetPosition(2).z) / (3)));
                }
            }
            else
            {

            }

    }
}
