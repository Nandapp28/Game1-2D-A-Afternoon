using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    [SerializeField] public int healthBar = 3;

    [SerializeField] GameObject Health1;
    [SerializeField] GameObject Health2;
    [SerializeField] GameObject Health3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBar >= 3)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(true);
        }
        else if (healthBar == 2)
        {
            Health1.SetActive(true);
            Health2.SetActive(true);
            Health3.SetActive(false);
        }
        else if (healthBar == 1)
        {
            Health1.SetActive(true);
            Health2.SetActive(false);
            Health3.SetActive(false);
        }
        else if (healthBar == 0)
        {
            Health1.SetActive(false);
            Health2.SetActive(false);
            Health3.SetActive(false);
        }
    }
}
