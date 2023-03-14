using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollectableCounter : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
        {
        tempDelay = scoreDelayTimer;
    }
    }

    void Start() => UpdateCount();

    void OnEnable() => Collectable.OnCollected += OncollectibleCollected;
    void OnDisable() => Collectable.OnCollected += OncollectibleCollected;

    void OncollectibleCollected()
    {
        count++;
        UpdateCount();
    }
    void UpdateCount()
    {
        text.text = $"{count}";
    }

    public float scoreDelayTimer;
    private float tempDelay;
    public int score;
    public int scoreIncrement;
     

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