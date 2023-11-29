using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
private Rigidbody2D _rBody;
  [SerializeField] private float _playerSpeed = 5;
  [SerializeField] private float _jumpForce = 5;
  Animator _animator;
private float _playerInputHorizontal;


    // Start is called before the first frame update
    void Start()
    {
        _rBody = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<animator>();
    }


   void Update()
  {
    if(Input.GetButtonDown("Jump") && GroundSensor._isGrounded);
    {
        Jump();
    }

    _animator.SetBool("isJumping", !GroundSensor._isGrounded);
  }




  void Movment()
  {
        _playerInputHorizontal = Input.GetAxis("Horizontal");


        _rBody2D.velocity = new Vector2(_playerInputHorizontal * _playerSpeed, _rBody2D.velocity.y);


        if(_playerInputHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            _animator.SetBool("isRunning", true);


        }


        else if(_playerInputHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            _animator.SetBool("isRunning", true);
        }


        else
        {
             _animator.SetBool("isRunning", false);
        }
  }
  void Jump()
  {
    _rBody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
  }
   

}      