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


    // Start is called before the first frame update
    void Start()
    {
        //Get Rigidbody in Inspector
        rb = GetComponent<Rigidbody2D>();
        puScript = PowerUP.GetComponent<PU>();
    }

    // Update is called once per frame
    void Update()
    {
        MovingPlayer();
        JumpingPlayer();
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
