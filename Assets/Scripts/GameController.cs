using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TimeManager timemanager;
    public bool finished;

    void Start()
    {

    }

    public void Goal()
    {
        finished = true;
        timemanager.UpdateFastestTime();
    }

    public bool Isfinished()
    {
        return finished;
    }
}
