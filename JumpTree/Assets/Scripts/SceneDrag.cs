using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneOneCamera : MonoBehaviour
{
    bool upPointerDown = false;
    bool downPointerDown = false;
    public float power;
    private void FixedUpdate()
    {
        if(upPointerDown)
        {
            transform.Translate(Vector3.up * power * Time.fixedDeltaTime);
        }
        if(downPointerDown)
        {
            transform.Translate(Vector3.back * power * Time.fixedDeltaTime);
        }
    }
    public void UpButtonDown()
    {

    }
    public void UpButtonUp()
    {

    }
    public void DownButtonDown()
    {

    }
    public void DownButtonUp()
    {

    }
}
