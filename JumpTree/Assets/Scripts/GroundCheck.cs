using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool onGround = false;
    Animator playerAnim;
    private void Start()
    {
        playerAnim = GetComponentInParent<Animator>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {   
        onGround =true;
        playerAnim.SetBool("onGround", onGround);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        onGround = false;
        playerAnim.SetBool("onGround", onGround);
    }
}
