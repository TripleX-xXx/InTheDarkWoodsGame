using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowers : MonoBehaviour {

	[SerializeField]
    EllipsoidParticleEmitter[] particles;

    public bool isOn = false;

    public void OnOff(bool f)
    {
        isOn = f;
        foreach (EllipsoidParticleEmitter fire in particles)
        {
            fire.emit = f;
        }
    }
}
