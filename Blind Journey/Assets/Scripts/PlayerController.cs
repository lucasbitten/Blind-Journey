using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;

    [SerializeField]
    float speed = 2;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        if (rb.velocity.x > 0){
            transform.localScale = Vector3.one;
        } else if (rb.velocity.x < -0.1f){
            transform.localScale = new Vector3(-1,1,1);
        }

        if(Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if(Input.GetKeyUp(KeyCode.D)){
            rb.velocity = Vector2.zero;
        }

        if(Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        if(Input.GetKeyUp(KeyCode.A)){
            rb.velocity = Vector2.zero;
        }
    }
}