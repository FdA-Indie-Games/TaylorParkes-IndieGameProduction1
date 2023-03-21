using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Counter : MonoBehaviour
{
    public float scoreDelayTimer;
    private float tempDelay;
    public int score;
    public int scoreIncrement;
     
     
     void Awake() {
        tempDelay = scoreDelayTimer;
    }

    private void Update() {
        
        tempDelay -= Time.deltaTime;


        if (tempDelay <= 0) {
            AddScore(scoreIncrement);
            tempDelay = scoreDelayTimer;
        }

        Debug.Log (score);
    }
    public void AddScore(int addScore){
        score = score + addScore;
    }
}