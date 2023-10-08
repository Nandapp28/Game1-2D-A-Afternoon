using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 7;
    [SerializeField] float jumpPower = 7.5f;

    float hAxis;
    Vector2 dir;

    Rigidbody rb;

<<<<<<< Updated upstream
    bool isAllowed = false;
=======
    public bool isAllowed = true;
>>>>>>> Stashed changes

    public GameObject PowerUP;
    PU puScript;

    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        //Get Rigidbody in Inspector
        rb = GetComponent<Rigidbody>();
        puScript = PowerUP.GetComponent<PU>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovingPlayer();
        JumpingPlayer();
        Facing();
        Anims();
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

<<<<<<< Updated upstream
    private void OnTriggerEnter(Collider player)
=======
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

    void Anims()
    {
        animator.SetFloat("Moving", Mathf.Abs(hAxis));
        animator.SetBool("isGround", isAllowed);
    }

    private void OnTriggerEnter2D(Collider2D player)
>>>>>>> Stashed changes
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

    private void OnTriggerExit(Collider player)
    {
        if(player.tag == "Ground")
        {
            isAllowed = false;
        }
    }
}
