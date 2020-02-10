using UnityEngine;

public class Move_Left : MonoBehaviour
{
    public playerController player;
    private bool moveLeft;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(moveLeft)
        {
            player.moveLeft();
        }
    }

    public void MovePlayerLeft()
    {
        moveLeft = true;
    }
    public void StopMovement()
    {
        moveLeft = false;
        player.walking = false;
    }
}
