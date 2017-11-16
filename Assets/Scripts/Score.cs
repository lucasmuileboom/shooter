using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoretxt;
    [SerializeField] private Text highscoretxt;
    private int score = 0;
    private int highscore = 0;
    //save highscore
    private void Start()
    {
        scoretxt.text = "Score: " + score;
        highscoretxt.text = "Highscore: " + highscore;
    }
    public void SetScore(int setscore)
    {
        score += setscore;
        scoretxt.text = "Score: " + score;
        if (score > highscore)
        {
            highscore = score;
            highscoretxt.text = "Highscore: " + highscore;
        }
    }
}