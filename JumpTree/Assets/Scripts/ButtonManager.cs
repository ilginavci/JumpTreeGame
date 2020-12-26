using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] DesignUi;
    public GameObject[] gameButtons ;
    GameObject[] trees;
    public void PlayButton()
    {
        foreach (var item in DesignUi)
        {
            item.SetActive(false);
        }
        foreach (var item in gameButtons)
        {
            item.SetActive(true);
        }
        string[] tags = { "tree", "tree2", "tree3" };
        foreach (var item in tags)
        {
            trees = GameObject.FindGameObjectsWithTag(item);
            foreach (var objects in trees)
            {
                objects.GetComponent<TreeDrag>().isOnPlay = false;
            }
        }
        
        GameObject.Find("Main Camera").GetComponent<CameraFollow>().onGame = true;
    }
}
