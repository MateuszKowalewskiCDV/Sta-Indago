using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSpawn : MonoBehaviour
{
    private float timer;
    public GameObject prefab;
    public int howManyClientsTodayWeWant;
    private int howManyClientsTodayWeHaveAlready;

    void Start()
    {
        timer = 0;
        howManyClientsTodayWeHaveAlready = 0;
    }

    void Update()
    {
        if(howManyClientsTodayWeHaveAlready < howManyClientsTodayWeWant)
        timer += Time.deltaTime;
        if(timer >= 10)
        {
            howManyClientsTodayWeHaveAlready++;
            Instantiate(prefab, new Vector3(-63.79f, 4.71f, 48.34f), Quaternion.identity);
            timer = 0;
        }
    }
}
