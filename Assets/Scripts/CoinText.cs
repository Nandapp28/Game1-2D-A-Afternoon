using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinText : MonoBehaviour
{
    public int coinTotal = 0;
    TextMeshProUGUI coinText;

    [SerializeField] GameObject lives;


    // Start is called before the first frame update
    void Start()
    {
        coinText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        coinTotal++;
        coinText.text = "Coin: " + coinTotal;
    }
}
