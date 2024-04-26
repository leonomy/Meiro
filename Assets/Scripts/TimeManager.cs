using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public GameController gameController;
    public float currentTime;
    public TMP_Text currentTimeText;
    public TMP_Text fastestTimeText;
    public static float fastestTime = 999.999f;

    void start()
    {
        fastestTimeText.text = fastestTime.ToString();
    } 

    void Update()
    {
        if (!gameController.Isfinished())
        {
            currentTime += Time.deltaTime;
            currentTimeText.text = currentTime.ToString("0.000");
        }
    }

    public void UpdateFastestTime()
    {
        if (currentTime < fastestTime)
        {
            fastestTime = currentTime;
        }
    }
}
