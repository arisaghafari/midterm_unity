using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlacer : MonoBehaviour
{
    public static float y;
    public float timerMaxTime;
    private float currentTimerValue;
    public GameObject squre;
    public DoodleMove doodle;

    public float minX;
    public float maxX;
    void Start()
    {
        currentTimerValue = timerMaxTime;
        y = transform.position.y;
        while (y < 4)
        {
            GameObject go;
            go = Instantiate(squre);
            go.AddComponent<PlatformManager>();
            go.transform.position = new Vector3(UnityEngine.Random.Range(minX, maxX), y, transform.position.z);
            y += 2.5f;
        }
    }

    void Update()
    {
        if (!doodle.gameOver)
        {
            if (currentTimerValue > 0)
            {
                currentTimerValue -= Time.deltaTime;
            }
            else
            {
                GameObject go;
                go = Instantiate(squre);
                go.AddComponent<PlatformManager>();
                go.transform.position = new Vector3(UnityEngine.Random.Range(minX, maxX), y, transform.position.z);
                currentTimerValue = timerMaxTime;
                y += 2f;
            }
        }
    }
}
