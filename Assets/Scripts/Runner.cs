using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public enum POSE
    {
        FLOATING,
        SLIDING,
        JUMPPING,
        RUNNING,
    }
    POSE pos;
    Rigidbody2D rb;
    Animator anim;
    float jumpForce = 50;
    bool isGround;
    public LayerMask groundLayer; //地面のレイヤー
    // Use this for initialization
    void Start()
    {
        pos = POSE.FLOATING;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics2D.Linecast(
           transform.position,
            transform.position - transform.up * GetComponent<SpriteRenderer>().bounds.size.y / 2,
            groundLayer);
        if (isGround && Input.GetKey(KeyCode.UpArrow))
        {
            Jump();
        }
        if (isGround && Input.GetKey(KeyCode.DownArrow))
        {
            Slide();
        }
        Anim();
    }
    void Slide()
    {
        pos = POSE.SLIDING;
        anim.SetTrigger("Sliding");
    }
    void Jump(){
        pos = POSE.JUMPPING;
        anim.SetTrigger("Jump");
        rb.AddForce(Vector2.up * jumpForce);
    }
    void Anim()
    {
        anim.SetBool("isGround", isGround);
    }
    public POSE getPose()
    {
        return pos;
    }
}
