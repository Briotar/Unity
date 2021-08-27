using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float jumpForce;
    private Rigidbody2D _thisBody;
    private Animator _animator;

    private void Start()
    {
        _thisBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0f, 0f);
            _animator.SetFloat("Speed", 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1f, 0f, 0f);
            _animator.SetFloat("Speed", 1);
        }
        else
        {
            _animator.SetFloat("Speed", 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _thisBody.AddForce(Vector2.up * jumpForce);
        }
    }
}
