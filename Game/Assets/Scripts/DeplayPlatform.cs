using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplayPlatform : MonoBehaviour
{
    [SerializeField] private GameObject plateform;
    [SerializeField] float respawnTime = 5.0f;
    private Vector2 screenbound;
    private int number;
    private GameObject level;
    private string levelname;

    // Start is called before the first frame update
    void Start()
    {
        screenbound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(platformmove());
    }
    private void deployfloor() {
        GameObject floor = Instantiate(plateform) as GameObject;
        number = Random.Range(1,4);
        levelname = "Level" + number.ToString();
        level = GameObject.Find(levelname);
        floor.transform.position = new Vector3(screenbound.x*-2,level.GetComponent<Transform>().position.y,level.GetComponent<Transform>().position.z);
    }
    // Update is called once per frame
    IEnumerator platformmove()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            deployfloor();
        }
    }
}
