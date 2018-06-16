using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowers : MonoBehaviour {

	[SerializeField]
    ParticleSystem[] particles;

    public bool isOn = false;

    public void OnOff(bool f)
    {
        isOn = f;
        foreach (ParticleSystem fire in particles)
        {
            if (f)
            {
                fire.Play();
            }
            else
            {
                fire.Stop();
                fire.Clear();
            }
        }
    }
}
