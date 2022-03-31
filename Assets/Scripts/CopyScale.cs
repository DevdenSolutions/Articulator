using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyScale : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject copyingObject;
    public bool copyX;
    public bool copyY;
    public bool copyZ;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            if (copyX)
            {
                transform.localScale = new Vector3(copyingObject.transform.localScale.x, transform.localScale.y, transform.localScale.z);
            }
            if (copyY)
            {
                transform.localScale = new Vector3(transform.localScale.x, copyingObject.transform.localScale.y, transform.localScale.z);
            }
            if (copyZ)
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, copyingObject.transform.localScale.z);
            }

        

        
    }
}
