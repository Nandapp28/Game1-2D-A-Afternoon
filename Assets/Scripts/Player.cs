using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 7;
    [SerializeField] float jumpPower = 7.5f;

    float hAxis;
    Vector2 dir;

    Rigidbody2D rb;

    public bool isAllowed = false;

    public GameObject PowerUP;
    PU puScript;

    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        //Get Rigidbody in Inspector
        rb = GetComponent<Rigidbody2D>();
        puScript = PowerUP.GetComponent<PU>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovingPlayer();
        JumpingPlayer();
        Facing();
        AnimationPlayer();
    }

    void MovingPlayer()
    {
        hAxis = Input.GetAxis("Horizontal");
        dir = new Vector2(hAxis, 0);
        transform.Translate(dir * Time.deltaTime * speed);
    }

    void JumpingPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAllowed == true)
        {
            rb.velocity = new Vector2(0, 1 * jumpPower);
        }
    }

    void Facing()
    {
        if (hAxis > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (hAxis < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void AnimationPlayer()
    {
        animator.SetFloat("Run", Mathf.Abs(hAxis));
        animator.SetBool("Jump", isAllowed == true);
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Ground")
        {
            isAllowed = true;
        }
        else if (player.tag == "PU")
        {
            puScript.DestroyPU();
        }
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if(player.tag == "Ground")
        {
            isAllowed = false;
        }
    }
}
