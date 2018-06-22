using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaz : MonoBehaviour {

    [SerializeField]
    ParticleSystem gas;

    private bool isOn;

    public void OnOff(bool f)
    {
        isOn = f;
        if (f)
        {
            gas.Play();
        }
        else
        {
            gas.Stop();
            gas.Clear();
        }
    }

    public bool GetIsOn()
    {
        return isOn;
    }

    private void Start()
    {
        isOn = true;
        gas.Play();
    }

}
