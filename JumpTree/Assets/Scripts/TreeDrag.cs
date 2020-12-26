using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TreeDrag : MonoBehaviour
{   public bool isOnPlay= true;
    Vector3 cam;
    private void OnMouseDrag()
    {   
        if (! EventSystem.current.IsPointerOverGameObject() && isOnPlay)
        {
            cam = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(cam.x, cam.y, transform.position.z);
        }
       
    }
    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject() && isOnPlay)
        {
            gameObject.GetComponent<Rigidbody2D>().simulated = false;
        }
       
    }
    private void OnMouseUp()
    {
        var tempPos = Input.mousePosition;
        if (tempPos.x <= 172f && tempPos.x >= 72f && tempPos.y >= 55f && tempPos.y <= 161f)
        {
            Destroy(gameObject);
        }
        else
        {
           gameObject.GetComponent<Rigidbody2D>().simulated = true;
        }
    }
}
