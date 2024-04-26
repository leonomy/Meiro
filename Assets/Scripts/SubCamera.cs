using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCamera : MonoBehaviour
{
    public float cameraTime;
    public float elapsedTime;

    void Update()
    {
        cameraTime += Time.deltaTime;

        if (cameraTime > elapsedTime)
        {
            gameObject.SetActive(false);
        }
    }
}
