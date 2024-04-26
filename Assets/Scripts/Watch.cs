using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch : MonoBehaviour
{
    public TimeManager timeManager;
    public float minusTime;

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().PlayWatchClip();
            timeManager.currentTime -= minusTime;
            Destroy(gameObject);
        }
    }
}
