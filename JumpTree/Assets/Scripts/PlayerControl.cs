using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControl : MonoBehaviour
{
    bool leftDown = false;
    bool rightDown = false;
    bool faceRight= true;
    Rigidbody2D playerRB;
    Animator playerAnim;
    public float speed;
    public float pow;
    public float cooldown;
    float nextJumpTime = 0;
    private void Start()
    {
        playerAnim = GetComponent<Animator>();
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {  if(playerRB.velocity.x <=0 )
        {
            playerAnim.SetFloat("velocity", -playerRB.velocity.x);
        }
        else
        {
            playerAnim.SetFloat("velocity", +playerRB.velocity.x);
        }
       if(leftDown)
        {
            if (faceRight)
            {
                transform.Rotate(0f, 180f, 0f, Space.Self);
                faceRight = false;
            }
            Vector3 tempVelocity = Vector3.Lerp(playerRB.velocity , Vector3.left * speed, 0.7f);
            playerRB.velocity = new Vector2(tempVelocity.x, playerRB.velocity.y);
        }
       else if(rightDown)
        {
            
            if(!faceRight)
            {
                transform.Rotate(0f, 180f, 0f, Space.Self);
                faceRight = true;
            }

            Vector3 tempVelocity = Vector3.Lerp(playerRB.velocity, Vector3.right * speed, 0.7f);
            playerRB.velocity = new Vector2(tempVelocity.x, playerRB.velocity.y);
        }
       else if(!rightDown && !leftDown)
        {
            Vector3 tempVelocity = Vector3.Lerp(playerRB.velocity, new Vector3(0,0,0) , 0.1f);
            playerRB.velocity = new Vector2(tempVelocity.x, playerRB.velocity.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("tree") && collision.transform.position.y <= transform.position.y )
        {
            pow = 525f;
        }
        else if (collision.gameObject.CompareTag("tree2") && collision.transform.position.y <= transform.position.y)
        {
            pow = 625f;
        }
        else if (collision.gameObject.CompareTag("tree3") && collision.transform.position.y <= transform.position.y)
        {
            pow = 725f;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        pow = 425f;
    }
    public void LeftButtonDown()
    {
        leftDown = true;
    }
    public void LeftButtonUp()
    {
        leftDown = false;
    }
    public void RightButtonDown()
    {
        rightDown= true;

    }
    public void RightButtonUp()
    {
        rightDown = false;
    }
    public void Jump()
    { print("asd");
        if(GetComponentInChildren<GroundCheck>().onGround && nextJumpTime < Time.timeSinceLevelLoad )
        {
            nextJumpTime = Time.timeSinceLevelLoad + cooldown;
            playerRB.AddForce(Vector3.up * pow, ForceMode2D.Force);
        }
    }
}
