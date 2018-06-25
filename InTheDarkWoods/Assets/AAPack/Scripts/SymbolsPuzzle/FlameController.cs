using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameController : MonoBehaviour {

    [SerializeField]
    float time = 1.5f;

    [SerializeField]
    AudioSource soundDeath;

    [SerializeField]
    FlameThrowers[] fireWalls;

    [SerializeField]
    int deltaTime;

    private float timer;
    private bool isOn;
    private bool flag;

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
        flag = true;
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
        }
    }

    public void Kill(Collider player)
    {
        if (flag)
        {
            flag = false;
            soundDeath.Play();
            StartCoroutine(Sleep(player));
        }
    }

    IEnumerator Sleep(Collider player)
    {
        yield return new WaitForSecondsRealtime(time);
        player.GetComponent<SwitchingSystem>().Kill();
        yield return new WaitForSecondsRealtime(0.5f);
        Stop();
    }

}
