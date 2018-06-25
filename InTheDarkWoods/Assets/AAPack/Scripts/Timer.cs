using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    [SerializeField]
    SwitchingSystem ss;

    [SerializeField]
    Text screen;

    [SerializeField]
    float startTime;

    [SerializeField]
    GameObject explosion;

    [SerializeField]
    Transform bomb;

    [SerializeField]
    AudioSource saund;

    [SerializeField]
    AudioSource ticTac;

    [SerializeField]
    float punishment;

    private float time;
    private bool isOn;

    public void OnOFF(bool flag)
    {
        if (flag)
        {
            ticTac.Play();
        }
        else
        {
            ticTac.Stop();
        }
        isOn = flag;
    }

    public void Restart()
    {
        time = startTime;
    }

    // Use this for initialization
    void Start () {
        isOn = false;
        time = startTime;
        SetScreen();
    }
	
	// Update is called once per frame
	void Update () {
        if (isOn)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                time = 0;
                isOn = false;
                End();
            }
            SetScreen();
        }
	}

    private void SetScreen()
    {
        int secAll = (int)time;
        int min = secAll / 60;
        int sec = secAll % 60;
        string timeString ="";
        if (min > 9)
        {
            timeString += min + ":";
        }
        else
        {
            timeString += "0" + min + ":";
        }
        if (sec > 9)
        {
            timeString +=sec;
        }
        else
        {
            timeString +="0" + sec;
        }
        screen.text = timeString;
    }

    private void End()
    {
        ss.Kill();
        Instantiate(explosion, bomb);
        ticTac.Stop();
        saund.Play();
    }

    public void WrongCode()
    {
        time -= punishment;
    }
}
