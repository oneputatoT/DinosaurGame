using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    float maxtime;
    float timer;
    int score;

    public Text hiScoreText;
    Text scoreText;
    AudioSource scoreSound;
    public GameObject gameObject;


    private void Start()
    {
        hiScoreText.text = "HI " + PlayerPrefs.GetInt("HIScore", 0).ToString("000000");
        score = 0;
        scoreText = GetComponent<Text>();
        scoreSound = GetComponent<AudioSource>();
        maxtime = 0.1f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > maxtime)
        {
            score++;
            scoreText.text = score.ToString("000000");
            timer = 0;
            if (score % 100 == 0)
            {
                scoreSound.Play();
                Time.timeScale += 0.1f;
            }

        }

        if (Time.timeScale == 0)
        {
            if (score > PlayerPrefs.GetInt("HIScore", 0))
            {
                PlayerPrefs.SetInt("HIScore", score);
                hiScoreText.text = "HI " + PlayerPrefs.GetInt("HIScore", 0).ToString("000000");
            }
            
        }

    }
}
