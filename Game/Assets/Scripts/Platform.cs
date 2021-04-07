using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    private Rigidbody rb;
    private Vector2 screenbound;
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.Find("Ball");
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-speed, 0,0);
        screenbound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < screenbound.x*2)
        {
            Destroy(this.gameObject);
            Ball.GetComponent<Ball>().platformcounter = Ball.GetComponent<Ball>().platformcounter + 1;
            Debug.Log(Ball.GetComponent<Ball>().platformcounter);
        }
    }
}
