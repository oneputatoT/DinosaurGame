using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Go;
    AudioSource gameOverSound;
    private void Start()
    {
        Time.timeScale = 1;
        gameOverSound = GetComponent<AudioSource>();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverSound.Play();
        Go.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene("MainScene");
    }
}
