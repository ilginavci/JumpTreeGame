using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Target;
    public bool onGame=false;
    void Update()
    {
        if ((Target.transform.position.y >  0 || transform.position.y > 0 ) && (onGame))
        {
            Vector3 tempPos = Vector3.Lerp(transform.position, Target.transform.position, 0.03f);
            transform.position = new Vector3(transform.position.x , tempPos.y, transform.position.z);
        }

    }
}
