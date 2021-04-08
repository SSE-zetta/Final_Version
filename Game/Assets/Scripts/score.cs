using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    public GameObject Ball;
    // Update is called once per frame
    void Update()
    {
        scoreUI.text ="Score: " + (Ball.GetComponent<Ball>().platformcounter+1).ToString()+" Lives:"+ Ball.GetComponent<Ball>().life.ToString();
    }
}
