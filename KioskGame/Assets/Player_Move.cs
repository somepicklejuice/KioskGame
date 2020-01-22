using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public int playerSpeed = 10;
    public bool facingRight = true;
    public int playerJumpPower = 100;
    public float moveX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player_Move();
    }

    //void Player_Move()
	//{
  //      //Controls
  //      moveX = Input.GetAxis("Horizontal");
  //      if (moveX < 0.0f && facingRight == false)
		//{
  //          FlipPlayer();
		//}
  //      else if(moveX > 0.0f && facingRight == true)
		//{
  //          FlipPlayer();
		//}
  //      //Animations 
  //      //Player Direction
  //      //Physics
  //      gameObject.GetComponent<RigidBody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<RigidBody2D>().velocity.y);
	//}

    void Jump()
	{
        //Jumping code
	}
    void FlipPlayer()
	{

	}
}
