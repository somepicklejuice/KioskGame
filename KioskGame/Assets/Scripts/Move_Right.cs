using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Right : MonoBehaviour
{
    public playerController player;
    private bool moveRight;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            player.moveRight();
        }
    }

    public void MovePlayerRight()
    {
        moveRight = true;
    }
    public void StopMovement()
    {
        moveRight = false;
        player.walking = false;
    }
}
