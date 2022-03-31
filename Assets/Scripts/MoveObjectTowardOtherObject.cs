using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveObjectTowardOtherObject : MonoBehaviour
{
    public List<GameObject> destinationObject;
    public float speed;
    public UnityEvent[] uintyEvent;
    Vector3 initalPos;
    int i = 0;
    void Start()
    {
        initalPos = transform.position;
    }

    private void OnEnable()
    {
        i = 0;
    }

    void Update()
    {
        try
        {

            transform.position = Vector3.MoveTowards(transform.position, destinationObject[i].transform.position, speed * Time.deltaTime);
            if (transform.position == destinationObject[i].transform.position)
            {
                try
                {

                    if (uintyEvent != null)
                    {
                        try
                        {
                            if (uintyEvent[i] != null)
                            {
                                uintyEvent[i].Invoke();
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                catch
                {

                }
                i++;
            }
        }

        catch (Exception e) { print("error" + e); }

    }
    private void OnDisable()
    {
        transform.position = initalPos;
    }
}