using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
private float Rigidbody2D _rBody2d;
[SerialiceField] private playerSpeed;
[SerialiceField] private JumpeForce;
Animator _animatior;
{
    // Start is called before the first frame update
    void Start()
    {
        _rBody = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

    }

    void Jump()
    {

    }
    void Movimiento()
}
