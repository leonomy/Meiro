using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hourglass : MonoBehaviour
{
    public TimeManager timeManager;
    public float plusTime;

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().PlayHourglassClip();
            timeManager.currentTime += plusTime;
            Destroy(gameObject);
        }
    }
}
