using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject subCamera;

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().PlayMapClip();
            subCamera.SetActive(true);
            Destroy(gameObject);
        }
    }
}
