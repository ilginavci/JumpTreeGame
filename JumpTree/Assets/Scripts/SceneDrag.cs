using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDrag : MonoBehaviour
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
        if(downPointerDown && transform.position.y >= 0 )
        {
            transform.Translate(Vector3.up * (-power) * Time.fixedDeltaTime);
        }
    }
    public void UpButtonDown()
    {
        upPointerDown = true;
    }
    public void UpButtonUp()
    {
        upPointerDown = false;
    }
    public void DownButtonDown()
    {
        downPointerDown = true;
    }
    public void DownButtonUp()
    {
        downPointerDown = false;
    }
}
