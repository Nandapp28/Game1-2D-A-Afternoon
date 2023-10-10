using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] int coinTotal = 0;
    TextMeshProUGUI coinText;

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
