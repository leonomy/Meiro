using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameController gameController;

    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>().Stop();
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().PlayGoalClip();
            gameController.Goal();
        }
    }
}
