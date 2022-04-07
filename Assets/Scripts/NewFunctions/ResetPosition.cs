using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    [SerializeField] Transform[] transforms;
    [SerializeField] Transform[] copyTransforms;
    private void Start()
    {
        copyTransforms = new Transform[transforms.Length];
        int i = 0;
        foreach(var x in transforms)
        {
            GameObject GO = new GameObject(x.name);
            print("____________| " + x.name + "|________________");
            print(x.localPosition);
            print(x.localRotation);
            GO.transform.position = x.localPosition;
            GO.transform.rotation = x.localRotation;
            copyTransforms[i] = GO.transform;
            i++;
        }
    }

    public void ResetThePosition()
    {
        int i = 0;
        foreach(var x in transforms)
        {
            x.localPosition = copyTransforms[i].localPosition;
            x.localRotation = copyTransforms[i].localRotation;
            i++;
        }
    }
}
