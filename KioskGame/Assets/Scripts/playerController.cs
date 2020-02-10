using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rig;
    public float jumpHeight;
    public float mvmtSpeed;
    private bool facingRight = true;
    public bool walking = false;
    public bool jumping = false;
    public Sprite jumpingSprite;
    public Sprite standingSprite;

    Animator myAnimation;
    // Use this for initialization
    void Start()
    {
        myAnimation = GetComponent<Animator>();
        myAnimation.enabled = false;
        rig = GetComponent<Rigidbody2D>();
    }

    public void jump()
    {
        transform.position += Vector3.up * jumpHeight * Time.deltaTime;
        jumping = true;
        //or you can use addforce
    }
    public void moveLeft()
    {
        transform.position -= Vector3.right * mvmtSpeed * Time.deltaTime;
        facingRight = false;
        walking = true;
    }
    public void moveRight()
    {
        transform.position += Vector3.right * mvmtSpeed * Time.deltaTime;
        facingRight = true;
        walking = true;
    }
    public void Update()
    {
        if(facingRight)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if(jumping)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = jumpingSprite;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = standingSprite;
        }

        if (Input.GetKey("left"))
            moveLeft();
        if (Input.GetKeyUp("left"))
            walking = false;

        if (Input.GetKey("right"))
            moveRight();
        if (Input.GetKeyUp("right"))
            walking = false;

        if (Input.GetKey("up"))
            jump();
        if (Input.GetKeyUp("up"))
            jumping = false;

        if (walking)
            myAnimation.enabled = true;
        else
            myAnimation.enabled = false;
    }
}
