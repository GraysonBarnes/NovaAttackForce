using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private float startTime = 0.0f;
    private float scoreTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTime = Mathf.Round((Time.time-startTime) * 100.0f);
        scoreText.text = "Score: " + scoreTime;
    }
}
