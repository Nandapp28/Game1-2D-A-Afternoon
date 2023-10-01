using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyPU()
    {
        Destroy(this.gameObject);
        print("Destroy PU");
    }
}
