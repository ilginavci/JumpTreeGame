using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInstantiate : MonoBehaviour
{
    public Transform Cam;
    public GameObject item;
    public GameObject particle;
    bool oneTime = true;
    GameObject tree1;
    public void OnDrag()
    {
        Vector3 cam = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (oneTime)
        {
            tree1 = Instantiate(item, new Vector3(cam.x, cam.y, transform.position.z), Quaternion.identity);
            oneTime = false;
        }
        tree1.transform.position = new Vector3(cam.x, cam.y, transform.position.z);
    }
}
