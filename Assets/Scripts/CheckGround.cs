using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

/// <summary>
/// Checks the ground of player, if true then player is in air and is unable to jump again, if false then player is on ground
/// </summary>
public class CheckGround : MonoBehaviour
{
    public float DistanceGround;

    public bool isGrounded = false; 

    // Start is called before the first frame update
    void Start()
    {
        DistanceGround = GetComponent<Collider> ().bounds.extents.y; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!Physics.Raycast(transform.position + 0.1f * Vector3.up, -Vector3.up, 1.0f))
        {
            isGrounded = false;
        }
        else
        {
            isGrounded = true; 
        }
    }

}
