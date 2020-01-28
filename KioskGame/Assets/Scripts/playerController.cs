using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rig;
    public float jumpHeight;
    // Use this for initialization
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    public void jump()
    {

        rig.velocity = new Vector2(0, jumpHeight);
        //or you can use addforce
    }
}
