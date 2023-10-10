using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU : MonoBehaviour
{
    Coin coinScript;
    [SerializeField] private GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        coinScript = coin.GetComponent<Coin>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.tag == "Player")
        {
            coinScript.AddScore();
            Destroy(this.gameObject);
        }
    }
}
