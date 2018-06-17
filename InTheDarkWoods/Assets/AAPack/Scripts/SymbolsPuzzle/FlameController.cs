using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameController : MonoBehaviour {

    [SerializeField]
    FlameThrowers[] fireWalls;

    [SerializeField]
    int deltaTime;

    private float timer;
    private bool isOn;

    public void Stop()
    {
        foreach (FlameThrowers ft in fireWalls)
        {
            ft.OnOff(false);
        }
        isOn = false;
    }

    public void Run()
    {
        Stop();
        timer = 0;
        isOn = true;
    }

    private void Start()
    {
        timer = 0;
        isOn = false;
        Stop();
    }

    private void Update()
    {
        if (isOn)
        {
            timer += Time.deltaTime;
            if (((int)(timer / deltaTime)) < fireWalls.Length &&
                !fireWalls[(int)(timer / deltaTime)].isOn)
            {
                fireWalls[(int)(timer / deltaTime)].OnOff(true);
            }
            if (fireWalls.Length < timer)
            {
                //todo kill
            }
        }
    }
}
