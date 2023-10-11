using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayMenu : MonoBehaviour
{
    [SerializeField] GameObject[] buttonGameplay;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;

        buttonGameplay[0].SetActive(false);
        buttonGameplay[1].SetActive(false);
        buttonGameplay[2].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        
        buttonGameplay[0].SetActive(true);
        buttonGameplay[1].SetActive(true);
        buttonGameplay[2].SetActive(false);
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;

        buttonGameplay[0].SetActive(false);
        buttonGameplay[1].SetActive(false);
        buttonGameplay[2].SetActive(true);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
