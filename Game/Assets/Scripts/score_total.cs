using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class score_total : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    public GameObject Ball;

    void Start()
    {
        Ball = GameObject.FindWithTag("Ball");
    }
    void Update()
    {
        scoreUI.text = "Score: " + (Ball.GetComponent<Ball>().platformcounter + 1).ToString();
    }
}
