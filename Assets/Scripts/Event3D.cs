using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Event3D : MonoBehaviour
{
    public UnityEvent onMouseDown;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        onMouseDown.Invoke();
    }
}
