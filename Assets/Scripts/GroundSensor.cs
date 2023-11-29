
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public static bool _isGrounded;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
            _isGrounded = true;
        }
   
    }


        void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
            _isGrounded = false;
        }
   
    }


        void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
            _isGrounded = true;
        }
   
    }

}

