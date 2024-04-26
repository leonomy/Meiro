using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour
{
    public GameObject target;
    public CharacterController player;

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().PlayWarpPointClip();
            player.enabled = false;
            player.gameObject.transform.position = target.transform.position;
            Invoke("Reset", 0.5f);
        }
        
    }

    void Reset()
    {
        player.enabled = true;
    }
}
