using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowers : MonoBehaviour {

	[SerializeField]
    ParticleSystem[] particles;
    [SerializeField]
    AudioSource sound;
    [SerializeField]
    FlameController fc;

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
            Kill(other);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && isOn)
        {
            Kill(other);
        }
    }

    private void Kill(Collider player)
    {
        fc.Kill(player);
    }

}
