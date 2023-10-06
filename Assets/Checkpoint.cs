using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private int checkpointID;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager gameManager = FindAnyObjectByType<GameManager>();
        gameManager.currentCheckpoint = checkpointID;
    }
}
