using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int currentCheckpoint;
    public Transform[] checkpoints;
    void Start()
    {
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
    }

    private void Load()
    {
        currentCheckpoint = PlayerPrefs.GetInt("Checkpoint");
        player.transform.position = checkpoints[currentCheckpoint].position;
        
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Checkpoint", currentCheckpoint);
    }
}
