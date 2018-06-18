using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowers : MonoBehaviour {

	[SerializeField]
    ParticleSystem[] particles;
    [SerializeField]
    AudioSource sound;

    public bool isOn = false;

    public void OnOff(bool f)
    {
        isOn = f;
        foreach (ParticleSystem fire in particles)
        {
            if (f)
            {
                fire.Play();
                sound.Play();
            }
            else
            {
                sound.Stop();
                fire.Stop();
                fire.Clear();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && isOn)
        {
            //ToDo kill
            Debug.Log("kill");
        }
    }

}
