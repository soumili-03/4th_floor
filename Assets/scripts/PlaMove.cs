using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaMove : MonoBehaviour
{
    [SerializeField]
    CharacterController chari;
    [SerializeField]
    float speed=12;
    [SerializeField]
    Transform orientation;

    
    float x, y;
    void FixedUpdate()
    {
        x=Input.GetAxis("Horizontal");
        y=Input.GetAxis("Vertical");
        Vector3 mov = -transform.right*x + -transform.forward*y;
        if (chari.isGrounded == false)
         {
             //Add our gravity Vecotr
             mov += Physics.gravity;
         }
        chari.Move(mov*speed);

    }
}
