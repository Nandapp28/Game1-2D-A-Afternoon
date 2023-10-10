using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;

    [SerializeField] GameObject lives;
    Lives liveScript;
    // Start is called before the first frame update
    void Start()
    {
        liveScript = lives.GetComponent<Lives>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (player.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.tag == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            liveScript.healthBar--;
            Destroy(this.gameObject);
        }
    }
}
