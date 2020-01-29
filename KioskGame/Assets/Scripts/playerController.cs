using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rig;
    public float jumpHeight;
    public float mvmtSpeed;
    private bool facingRight = true;
    public bool jumping = false;
    public Sprite jumpingSprite;
    public Sprite standingSprite;
    // Use this for initialization
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    public void jump()
    {
        rig.velocity = new Vector2(0, jumpHeight);
        jumping = true;
        //or you can use addforce
    }
    public void moveLeft()
    {
        rig.velocity = new Vector2(-1 * mvmtSpeed, 0);
        facingRight = false;        
    }
    public void moveRight()
    {
        rig.velocity = new Vector2(mvmtSpeed, 0);
        facingRight = true;
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
    }
}
