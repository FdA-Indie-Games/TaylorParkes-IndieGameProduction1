using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    public TMPro.TMP_Text scoreText;
    float score;

    public void IncreaseScore(float amount)
    {
        score += amount;
        UpdateScoreDispay();
    }

    public void UpdateScoreDispay()
    {
        scoreText.text = "Score:" + score;
    }
}
