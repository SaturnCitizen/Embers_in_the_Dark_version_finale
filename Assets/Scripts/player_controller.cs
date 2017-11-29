using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player_controller : MonoBehaviour
{

    [HideInInspector] public bool facingRight = true;
    [HideInInspector] public bool jump = false;

    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public Transform groundCheck;


    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rigid;

    private GameManager gameManagerObj;

    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        gameManagerObj = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (Input.GetButtonDown("Jump") && grounded)
        {
            jump = true;
        }
        if (Input.GetButtonDown("Change To White"))
        {
            GetComponent<SpriteRenderer>().color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
        }
        if (Input.GetButtonDown("Change To Orange"))
        {
            GetComponent<SpriteRenderer>().color = new Color32(0xFF, 0xBC, 0x69, 0xFF);
        }
        if (Input.GetButtonDown("Change To Green"))
        {
            GetComponent<SpriteRenderer>().color = new Color32(0x41, 0xA9, 0x41, 0xFF);
        }
        if (Input.GetButtonDown("Change To Blue"))
        {
            GetComponent<SpriteRenderer>().color = new Color32(0x3, 0xAF, 0xFF, 0xFF);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(h));

        /*if (rigid.velocity.x < maxSpeed)
            rigid.AddForce(Vector2.right * h * moveForce);
        if (Mathf.Abs(rigid.velocity.x > maxSpeed))
            rigid.velocity = new Vector2(Mathf.Sign(rigid.velocity.x) * maxSpeed, rigid.velocity.y);*/
        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();
        h *= moveForce;
        rigid.velocity = new Vector2(h, rigid.velocity.y);

        if (jump)
        {
            anim.SetTrigger("Jump");
            rigid.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spikes_trap")
        {
            gameManagerObj.player_lose_luminosity();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "luminosity_flame")
        {
            gameManagerObj.player_gain_luminosity();
            Destroy(collision.gameObject);
        }
        if (collision.tag == "death_limit")
        {
            gameManagerObj.player_die();
        }
        if (collision.tag == "wood_doors")
        {
            gameManagerObj.player_win();
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}