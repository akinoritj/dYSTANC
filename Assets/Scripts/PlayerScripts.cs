using System;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    [SerializeField] private float velocidade;
    [SerializeField] private float pulo;
    [SerializeField] private float moveInput;
    [SerializeField] private bool bbb;
    [SerializeField] private bool ccc;
    [SerializeField] private Animator anim  ;
    private Rigidbody2D rb;
    void Start()
    {
        velocidade = 5f;
        pulo = 5f;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        if (moveInput != 0f)
        {
            transform.localScale = new Vector3(Mathf.Sign(moveInput), 1f, 1f);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInput * velocidade, rb.linearVelocity.y);
    }
}
