using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    private Rigidbody2D _thisBody;

    public UnityEvent PlayerWalkEvent;
    public UnityEvent PlayerStayEvent;

    private void Start()
    {
        _thisBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0f, 0f);
            PlayerWalkEvent?.Invoke();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1f, 0f, 0f);
            PlayerWalkEvent?.Invoke();
        }
        else
        {
            PlayerStayEvent?.Invoke();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _thisBody.AddForce(Vector2.up * _jumpForce * 2f);
        }
    }
}
