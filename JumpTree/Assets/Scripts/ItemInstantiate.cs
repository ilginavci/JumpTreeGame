using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInstantiate : MonoBehaviour
{
    public Transform Cam;
    public GameObject item;
    public int numberTree1 = 3;
    GameObject tree1;
    int i = 0;
    Vector3 cam;
    public void StartDrag()
    {   if(numberTree1 > i)
        {
            cam = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            tree1 = Instantiate(item, new Vector3(cam.x, cam.y, transform.position.z), Quaternion.identity);
            i++;
        }
        
    }
    public void OnDrag()
    {   if( tree1 != null)
        {
            cam = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            tree1.transform.position = new Vector3(cam.x, cam.y, transform.position.z);
        }
    }
    public void StopDrag()
    {
        if (tree1 != null)
        { var tempPos = Input.mousePosition;
            if (tempPos.x <= 172f && tempPos.x >= 72f && tempPos.y >= 55f && tempPos.y <= 161f)
            {
                Destroy(tree1);
                tree1 = null;
            }
            else
            {
                tree1.GetComponent<Rigidbody2D>().simulated = true;
                tree1 = null;
            }
         
            
        }
    }
}
