using UnityEngine;
using System.Collections;

public class timeCounterCollision : MonoBehaviour
{

    private float _seconds;
    public bool pause;

    void Update()
    {
        if (!pause)
        {
            _seconds += Time.deltaTime;

        }
    }

    public float seconds
    {
        get { return _seconds; }
    }
}