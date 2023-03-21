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
}
