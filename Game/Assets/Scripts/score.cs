using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public TextMesh scoretext;
    public GameObject Ball;
    // Update is called once per frame
    void Update()
    {
        scoretext.text ="Score: " + Ball.GetComponent<Ball>().platformcounter.ToString();
    }
}
